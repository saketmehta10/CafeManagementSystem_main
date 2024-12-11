using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
    public partial class CashierOrderForm : UserControl
    {

        public static int getCustID;
        public float totalItemPrice;
        private float totalPrice;

        public int quantity;


       
        public CashierOrderForm()
        {
            InitializeComponent();
            displayAvailableProds();
            displayAllOrders();
            displayTotalPrice();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAvailableProds();
            displayAllOrders();

            displayTotalPrice();
        }

        private void CashierOrderForm_Load(object sender, EventArgs e)
        {

        }

        private int idGen = 0;

        public void IDGenerator()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;"))
            {

                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string selectID = "SELECT MAX(customer_id) FROM customers";

                        using (SqlCommand cmd = new SqlCommand(selectID, conn))
                        {
                            object result = cmd.ExecuteScalar();

                            if (result != DBNull.Value)
                            {
                                int temp = Convert.ToInt32(result);

                                if (temp == 0)
                                {
                                    idGen = 1;
                                }
                                else
                                {
                                    idGen = temp + 1;
                                }
                            }
                            else
                            {
                                idGen = 1;
                            }
                            getCustID = idGen;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
         }
        

        public void displayAvailableProds()
        {
            CashierOrderFormProdData allProds = new CashierOrderFormProdData();
            List<CashierOrderFormProdData> listData = allProds.availableProductsData();
            cashierOrderForm_menuTable.AutoGenerateColumns = true;
            cashierOrderForm_menuTable.DataSource = listData;
        }

        public void displayAllOrders()
        {
            CashierOrdersData allOrders = new CashierOrdersData();
            List<CashierOrdersData> listData = allOrders.ordersListData();
            if (listData.Count > 0)
            {
                cashierOrderForm_orderTable.DataSource = listData;
            }
            else
            {
                MessageBox.Show("No orders found for this customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        public void displayTotalPrice()
        {
            IDGenerator();
            using (SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;"))
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT SUM(prod_price) FROM orders WHERE customer_id = @custId";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@custId", idGen);

                            object result = cmd.ExecuteScalar();

                            if (result != DBNull.Value)
                            {
                                totalPrice = Convert.ToSingle(result);

                                cashierOrderForm_orderPrice.Text = totalPrice.ToString("0.00");
                            }
                            else
                            {

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
        {

            IDGenerator();

            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;"))
            {
                if (cashierOrderForm_type.SelectedIndex == -1 || cashierOrderForm_productID.SelectedIndex == -1
                || cashierOrderForm_prodName.Text == "" || cashierOrderForm_quantity.Value == 0
                || cashierOrderForm_price.Text == "")
                {
                    MessageBox.Show("Please select the product first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        try
                        {
                            conn.Open();
                            float getPrice = 0;
                            string selectOrder = "SELECT * FROM products WHERE prod_id = @prodID";

                            using (SqlCommand getOrder = new SqlCommand(selectOrder, conn))
                            {
                                getOrder.Parameters.AddWithValue("@prodID", cashierOrderForm_productID.Text.Trim());

                                using (SqlDataReader reader = getOrder.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        object rawValue = reader["prod_price"];
                                        if (rawValue != DBNull.Value)
                                        {
                                            getPrice = Convert.ToSingle(rawValue);
                                        }
                                    }
                                }
                            }

                            string insertOrder = "INSERT INTO orders (customer_id, prod_id, prod_name, prod_type, qty, prod_price, order_date) " +
                                "VALUES(@customerID, @prodID, @prodName, @prodType, @qty, @prodPrice, @orderDate)";

                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertOrder, conn))
                            {
                                cmd.Parameters.AddWithValue("@customerID", idGen);
                                cmd.Parameters.AddWithValue("@prodID", cashierOrderForm_productID.Text.Trim());
                                cmd.Parameters.AddWithValue("@prodName", cashierOrderForm_prodName.Text);
                                cmd.Parameters.AddWithValue("@prodType", cashierOrderForm_type.Text.Trim());

                                float totalPrice = (getPrice * (int)cashierOrderForm_quantity.Value);

                                cmd.Parameters.AddWithValue("@qty", cashierOrderForm_quantity.Value);
                                cmd.Parameters.AddWithValue("@prodPrice", totalPrice);
                                cmd.Parameters.AddWithValue("@orderDate", today);

                                cmd.ExecuteNonQuery();


                                displayAllOrders();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                displayTotalPrice();

            }
        }


        public void clearFields()
        {
            cashierOrderForm_type.SelectedIndex = -1;
            cashierOrderForm_productID.Items.Clear();
            cashierOrderForm_prodName.Text = "";
            cashierOrderForm_price.Text = "";
            cashierOrderForm_quantity.Value = 0;
        }


        private void cashierOrderForm_menuTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cashierOrderForm_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashierOrderForm_productID.Items.Clear();
            cashierOrderForm_productID.SelectedIndex = -1;
            cashierOrderForm_prodName.Text = "";
            cashierOrderForm_orderPrice.Text = "";

            string selectedValue = cashierOrderForm_type.SelectedItem as string;
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;"))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    { 
                        conn.Open();
                        string selectData = $"Select * from products where prod_type='{selectedValue}'";
                        using (SqlCommand cmd = new SqlCommand(selectData, conn))
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();
                                    cashierOrderForm_productID.Items.Add(value);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception Occured in Cashier order" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();

                    }
                }
            }
        }
     

        private void cashierOrderForm_productID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrderForm_productID.SelectedItem as string;
            if (selectedValue != null)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;"))
                    {
                        try
                        {
                            conn.Open();
                            string selectData = $"Select * from  products where  prod_id='{selectedValue}'And prod_status=@status and date_delete is null";
                            using (SqlCommand cmd = new SqlCommand(selectData, conn))
                            {
                                cmd.Parameters.AddWithValue("@status", "Available");

                                using (SqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {

                                        string prodName = reader["prod_name"].ToString();
                                        string prodPrice = reader["prod_price"].ToString();

                                        cashierOrderForm_prodName.Text = prodName.ToString();
                                        cashierOrderForm_price.Text = prodPrice.ToString();





                                    }
                                }

                                displayTotalPrice();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection  error Occured" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex, " Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cashierOrderForm_amount_TextChanged(object sender, EventArgs e)
        {

        }


        private void cashierOrderForm_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(cashierOrderForm_amount.Text);

                    float getChange = (getAmount - totalPrice);

                    if (getChange <= -1)
                    {
                        cashierOrderForm_amount.Text = "";
                        cashierOrderForm_change.Text = "";
                    }
                    else
                    {
                        cashierOrderForm_change.Text = getChange.ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid"+ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrderForm_amount.Text = "";
                    cashierOrderForm_change.Text = "";
                }
            }
        }

        public float enteredAmount;

        //Add  data of Customers 
        private void cashierOrderForm_payBtn_Click(object sender, EventArgs e)
        {




            if (cashierOrderForm_amount.Text == "" || cashierOrderForm_orderTable.Rows.Count < 0)
            {
                MessageBox.Show("Something went wrong.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure for paying?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;"))
                    {
                        if (conn.State == ConnectionState.Closed)
                        {
                            try
                            {
                                IDGenerator();
                                conn.Open();




                                string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, date) " +
                                    "VALUES(@custID, @totalprice, @amount, @change, @date)";

                                DateTime today = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, conn))
                                {
                                    cmd.Parameters.AddWithValue("@custID", idGen);
                                    cmd.Parameters.AddWithValue("@totalprice", totalPrice);
                                    cmd.Parameters.AddWithValue("@amount", cashierOrderForm_amount.Text);
                                    cmd.Parameters.AddWithValue("@change", cashierOrderForm_change.Text);
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Paid successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                    }
                }
                displayTotalPrice();
            }
        }

        private int rowIndex = -1;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            displayTotalPrice();

            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "YoUrCoFfEe Cafe Shop";
            y = margin + count * headerFont.GetHeight(e.Graphics) + headerMargin;
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black,
                (e.MarginBounds.Left + e.MarginBounds.Right) / 2 - e.Graphics.MeasureString(headerText, headerFont).Width / 2, y, alignCenter);

            count++;
            y += tableMargin;

            string[] header = { "CID", "ProdID", "ProdName", "ProdType", "Qty", "Price" };

            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            rowIndex++;  // Increment at the start of the loop
            while (rowIndex < cashierOrderForm_orderTable.Rows.Count)
            {
                DataGridViewRow row = cashierOrderForm_orderTable.Rows[rowIndex];

                for (int i = 0; i < cashierOrderForm_orderTable.Columns.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            int labelMargin = (int)Math.Min(rSpace, 200);
            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            string totalText = string.Format("Total Price: \t${0}\nAmount: \t${1}\n\t\t------------\nChange: \t${2}",
                                            totalPrice, cashierOrderForm_amount.Text, cashierOrderForm_change.Text);
            e.Graphics.DrawString(totalText, labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, 40);
            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width, y);
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = -1;
        }

        private void cashierOrderForm_orderPrice_Click(object sender, EventArgs e)
        {

        }

        private void cashierOrderForm_receipitBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void cashierOrderForm_change_Click(object sender, EventArgs e)
        {

        }
        private int getOrderID = 0;
        private void cashierOrderForm_removeBtn_Click(object sender, EventArgs e)
        {
            if (getOrderID == 0)
            {
                MessageBox.Show("Select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove the Order ID: " + getOrderID + "?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;"))
                    {  if (connect.State == ConnectionState.Closed)
                        {
                            try
                            {
                                connect.Open();

                                string deleteData = "DELETE FROM orders WHERE order_id = @id";

                                using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@id", getOrderID);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                connect.Close();
                            }
                        }
                        }
                }
            }

            displayAllOrders();
            displayTotalPrice();
        }







        private void cashierOrderForm_clearBtn_Click(object sender, EventArgs e)
        {
            displayAllOrders();
            displayTotalPrice();
            clearFields();

        }

        private void cashierOrderForm_orderTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = cashierOrderForm_menuTable.Rows[e.RowIndex];

            // Check if the cell value is not null before casting
            if (row.Cells[0].Value != null)
            {
                getOrderID = (int)row.Cells[0].Value;
            }
            else
            {
                MessageBox.Show("Order ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}