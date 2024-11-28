 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
     class AdminAddUsersData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");

        public int ID{set; get;}
        public string Username{ set; get; }
        //This line creates a property called username in a class. It allows you to:
        // Store a value(e.g., "john_doe") using set.
        // Retrieve the value(e.g., get the name "john_doe") using get.

        public string Password { set; get; }
        public string Role { set; get; }  //Represents the role of the user (e.g., "Admin", "User", "Manager").

        public string Status { set; get; } //Represents the current status of the user (e.g., "Active", "Inactive")

        public string DateRegistered { set; get; }

        public List<AdminAddUsersData>usersListData()  //1. public List<AdminAddUsersData> usersListData()
                                                       //Explanation: This is a method declaration in C# that returns a List of AdminAddUsersData objects when called.
                                                       //AdminAddUsersData: A custom class (likely defined elsewhere) to hold user data.
                                                       //List<AdminAddUsersData>: A collection to store multiple user data objects.
        {
            List<AdminAddUsersData> listData = new List<AdminAddUsersData> ();  //Explanation: Instantiates an empty List of AdminAddUsersData. This list will store all user data fetched from the database.


            if (connect.State != ConnectionState.Open)  //Checks if the database connection is not already open
            {
                try                                    //  Starts a try block to safely handle potential exceptions during database operations.
                {
                    connect.Open ();                    // Opens the database connection for executing queries.
                    string selectdata = "select * from users";

                    using (SqlCommand cmd = connect.CreateCommand())  //Creates an SqlCommand object for executing the SQL query.
                    {
                        SqlDataReader reader = cmd.ExecuteReader ();  // Executes the SQL query and retrieves the results as a SqlDataReader object for row-by-row reading of the data.
                        
                        while (reader.Read())                          // Loops through the rows in the result set.
                                                                       //reader.Read(): Advances the reader to the next record (row).                    
                        {
                            AdminAddUsersData userData = new AdminAddUsersData ();  //Creates a new instance of the AdminAddUsersData class to hold the current row's data.
                            userData.ID = (int)reader["ID"];
                            userData.Username = reader["username"].ToString();
                            userData.Password = reader["password"].ToString();
                            userData.Role = reader["role"].ToString();
                            userData.Status = reader["status"].ToString();
                            userData.DateRegistered = reader["date_reg"].ToString();

                            listData.Add (userData);                 //Adds the populated userData object to the listData list.
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine (ex.Message);

                }
                finally
                {
                    connect.Close ();
                }
            }
            return listData;   //Returns the populated listData list containing all the user data retrieved from the database.
        }
    }
}
