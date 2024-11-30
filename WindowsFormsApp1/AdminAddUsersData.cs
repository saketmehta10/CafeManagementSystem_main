using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class AdminAddUsersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");

        public int ID { set; get; }//auto-implemented properties managed by compiler  automatically 
        public string Username { set; get; }
        public string Password { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }
        public string DateRegistered { set; get; }
        public string Image { set; get; }

        public List<AdminAddUsersData> usersListData()
        {
            List<AdminAddUsersData> listData = new List<AdminAddUsersData>();  // List to store user data

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();  // Open DB connection
                    string selectdata = "SELECT * FROM users";

                    using (SqlCommand cmd = new SqlCommand(selectdata, connect))  // Execute query
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())  // Read rows and advance the reader to next row 
                        {
                            AdminAddUsersData userData = new AdminAddUsersData();  // Create new user that object hold the current row's data.
                            userData.ID = reader["ID"] as int? ?? 0;  // Safe casting
                            userData.Username = reader["username"].ToString();
                            userData.Password = reader["password"].ToString();
                            userData.Role = reader["role"].ToString();
                            userData.Status = reader["status"].ToString();
                            userData.Image = reader["profile_image"].ToString();
                            userData.DateRegistered = reader["date_reg"].ToString();

                            listData.Add(userData);  // Add user to list
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }
                finally
                {
                    connect.Close(); 
                }
            }
            return listData;  // Return populated list
        }
    }
}
