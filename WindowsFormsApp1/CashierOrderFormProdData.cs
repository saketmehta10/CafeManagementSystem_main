using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
   class CashierOrderFormProdData
    {
        public int ID { set; get; }
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public string Type { set; get; }
        public string Stock { set; get; }
        public string Price { set; get; }
        public string Status { set; get; }

        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");


        public List<CashierOrderFormProdData> availableProductsData()
        {
            List<CashierOrderFormProdData> listData = new List<CashierOrderFormProdData>();
            try
            {

                if (connect.State == ConnectionState.Closed) // Ensure connection is open
                {
                    connect.Open();
                }
                string selectData = "SELECT * FROM products WHERE prod_status= @stats";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@stats", "Available");
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                         CashierOrderFormProdData apd = new CashierOrderFormProdData();

                        apd.ID = (int)reader["id"];
                        apd.ProductID = reader["prod_id"].ToString();
                        apd.ProductName = reader["prod_name"].ToString();
                        apd.Type = reader["prod_type"].ToString();
                        apd.Stock = reader["prod_stock"].ToString();
                        apd.Price = reader["prod_price"].ToString();
                        apd.Status = reader["prod_status"].ToString();
                        //For Debugging Remove after checking --saket
                        Console.WriteLine($"Fetched: {apd.ProductName}");
                        listData.Add(apd);
                    }

                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Failed to fetch products: " + ex.Message);
            }
            finally
            {
                
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
