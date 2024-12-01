using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    internal class AdminAddProductsData
    {

        public int ID { set; get; }
        public string ProductID { set; get; }
        public string ProductName { set; get; }

        public string Type { set; get; }

        public string Stock { set; get; }
        public string Price { set; get; }
        public string Status { set; get; }

        public string Image { set; get; }

        public string DateInsert { set; get; }
        public string DateUpdate { set; get; }

        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");


        public List<AdminAddProductsData> productsListData()
        {

            List<AdminAddProductsData> listData = new List<AdminAddProductsData>();

            if (connect.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    //The query fetches only the records of products that are still active or not deleted
                    string selectData = "SELECT * FROM products WHERE date_delete IS NULL";
                    
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            //This object (apd) will hold the data for a single product retrieved from the database.
                            AdminAddProductsData apd = new AdminAddProductsData();

                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.Type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                            apd.Status = reader["prod_status"].ToString();
                            apd.Image = reader["prod_image"].ToString();
                            apd.DateInsert = reader["date_insert"].ToString();
                            apd.DateUpdate = reader["date_update"].ToString();

                            //The object(apd) data stored in the list 
                            listData.Add(apd);
                        }
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Failed connection " + ex);
                }
                finally
                {
                    connect.Close();
                }


            }
            return listData;
        }


        public List<AdminAddProductsData> availableProductsData()
        {
            List<AdminAddProductsData> listData = new List<AdminAddProductsData>();
            try
            {
                // Ensure connection is open
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                // Define your SQL query (ensure the table name is correct)
                string selectData = "SELECT * FROM products WHERE date_delete IS NULL";
                // Execute the query and read data
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AdminAddProductsData apd = new AdminAddProductsData();

                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.Type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                                //Status = reader["prod_status"].ToString(),
                                //Image = reader["prod_image"].ToString(),
                                //DateInsert = reader["date_insert"].ToString(),
                                //DateUpdate = reader["date_update"].ToString()
                            

                            // Add the product to the list
                            listData.Add(apd);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine("Failed to fetch products: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed
                if (connect.State == ConnectionState.Open)
                {
                    connect.Close();
                }
            }

            // Return the populated list
            return listData;
        }

    }
}
    
