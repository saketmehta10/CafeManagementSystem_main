using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CashierOrderForm : UserControl
    {

        public static int getCustID;
        public float totalItemPrice;
        private float totalPrice;
        public int quantity;

        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");

        public int idGen = 0;
        public CashierOrderForm()
        {
            InitializeComponent();
            displayAvailableProds();
            displayAllOrders();
            displayTotalPrice();
        }

        private void CashierOrderForm_Load(object sender, EventArgs e)
        {

        }

        public void IDGenerator()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\cafe2.mdf;Integrated Security=True;"))
            {
                connect.Open();
                string selectID = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectID, connect))
                {
                    object result = cmd.ExecuteScalar();
                    idGen = (result != DBNull.Value && result != null) ? Convert.ToInt32(result) + 1 : 1;
                    getCustID = idGen; // Ensure `getCustID` is updated correctly
                }
            }
        }
        public void displayAvailableProds()
        {
            CashierOrderFormProdData allProds = new CashierOrderFormProdData();
            List<CashierOrderFormProdData> listData = allProds.availableProductsData();
            cashierOrderForm_menuTable.AutoGenerateColumns = true;//ensure all colum are shown 
            cashierOrderForm_menuTable.DataSource = listData;
        }

        public void displayAllOrders()
        {
            CashierOrdersData allOrders = new CashierOrdersData();
            List<CashierOrdersData> listData = allOrders.ordersListData();
            cashierOrderForm_orderTable.DataSource = listData;
        }


        public void displayTotalPrice()
        {

            IDGenerator();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT SUM(prod_price) FROM orders WHERE customer_id = @custId";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@custID", idGen);


                        object result = cmd.ExecuteScalar();


                        totalPrice = Convert.ToSingle(result);


                        cashierOrderForm_orderPrice.Text = totalPrice.ToString();





                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (cashierOrderForm_type.SelectedIndex == -1 || cashierOrderForm_productID.SelectedIndex == -1
                || cashierOrderForm_prodName.Text == "" || cashierOrderForm_quantity.Value == 0
                || cashierOrderForm_price.Text == "")
            {
                MessageBox.Show("Please select the rpoduct first ", " Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        float getPrice = 0;

                        string selectData = " SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand getOrder = new SqlCommand(selectData, connect))
                        {
                            getOrder.Parameters.AddWithValue(@"prodID", cashierOrderForm_productID.Text.Trim());


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

                        string insertOrder = "INSERT INTO orders (customer_id,prod_id,prod_name,prod_type,qty,prod_price,order_date) VALUES (@customerID,@prodID,@prodName,@prodType,@qty,@prodPrice,@orderDate)";

                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertOrder, connect))
                        {
                            cmd.Parameters.AddWithValue(@"customerID", idGen);
                            cmd.Parameters.AddWithValue(@"prodID", cashierOrderForm_productID.Text.Trim());
                            cmd.Parameters.AddWithValue(@"prodName", cashierOrderForm_prodName.Text.Trim());
                            cmd.Parameters.AddWithValue(@"prodType", cashierOrderForm_type.Text.Trim());
                            cmd.Parameters.AddWithValue(@"qty", cashierOrderForm_quantity.Value);
                            float toatalPrice = (getPrice * ((int)cashierOrderForm_quantity.Value));
                            cmd.Parameters.AddWithValue(@"prodPrice", toatalPrice);
                            cmd.Parameters.AddWithValue(@"orderDate", today);

                            cmd.ExecuteNonQuery();

                            displayTotalPrice();
                            displayAllOrders();

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed " + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }


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

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = $"Select * from products where prod_type='{selectedValue}'";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
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
                    connect.Close();

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
                    using (SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\cafe2.mdf;Integrated Security = True;"))
                    {
                        try
                        {
                            connect.Open();
                            string selectData = $"Select * from  products where  prod_id='{selectedValue}'And prod_status=@status and date_delete is null";
                            using (SqlCommand cmd = new SqlCommand(selectData, connect))
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

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection  error Occured" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
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
                    MessageBox.Show("Invalid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrderForm_amount.Text = "";
                    cashierOrderForm_change.Text = "";
                }
            }
        }

        public float enteredAmount;
        private void cashierOrderForm_payBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(cashierOrderForm_amount.Text) ||
               cashierOrderForm_orderTable.Rows.Count <= 0 ||
               !float.TryParse(cashierOrderForm_amount.Text, out enteredAmount) ||
               enteredAmount < totalPrice)
            {
                MessageBox.Show("Something went wrong.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure for paying?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            IDGenerator();


                            string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, date) " +
                                "VALUES(@custID, @totalprice, @amount, @change, @date)";

                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
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
                            connect.Close();
                        }
                    }
                }
            }
            displayTotalPrice();
        }
    }
}