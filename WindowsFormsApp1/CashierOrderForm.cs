using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class CashierOrderForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");

        public CashierOrderForm()
        {
            InitializeComponent();
            displayAvailableProds();
        }

        private void CashierOrderForm_Load(object sender, EventArgs e)
        {

        }

        public void displayAvailableProds()
        {
            CashierOrderFormProdData allProds = new CashierOrderFormProdData();
            List<CashierOrderFormProdData> listData = allProds.availableProductsData();
            cashierOrderForm_menuTable.AutoGenerateColumns = true;//ensure all colum are shown 
            cashierOrderForm_menuTable.DataSource = listData;
        }

        private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Exception Occured in Casheier order" + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                using (SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;"))
                {
                    try
                    {
                        connect.Open();
                        string selectData = $"Select * from  products where  prod_id='{selectedValue}'And prod_status=@status and date_delete is null";
                        using (SqlCommand cmd = new SqlCommand(selectData,connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {

                                    string prodName = reader["prod_name"].ToString();
                                    string prodPrice = reader["prod_price"].ToString();

                                    cashierOrderForm_prodName.Text= prodName.ToString();
                                    cashierOrderForm_orderPrice.Text=prodPrice.ToString();

                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection  error Occured" + ex.Message , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally 
                    {
                        connect.Close();
                    }

                }
            }
        }
    }
}