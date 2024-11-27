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
using System.Data;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool check_for_empty()
        {
            if(register_password.Text == "" || register_username.Text == "" || register_CPass.Text == "")
            {
                return true;
            }
            else
            {
                 return false;
            }
        }
        private void register_password_TextChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_show.Checked ? '\0' : '*';
            //Represents the null character, which means no masking. When set, the password field will display the actual characters typed
            register_CPass.PasswordChar= register_show.Checked ? '\0' : '*';
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (check_for_empty())
            {
                MessageBox.Show("All Fields are required  to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State == ConnectionState.Closed) 
                {

                    try
                    {
                        connection.Open();
                        //Checking if  username us already taken 
                        string selectusername = "SELCET * FROM users WHERE username=@admin";
                        //using here is used  for  resouce  management  when no  longer in used will be disposed 
                        using (SqlCommand checkUsername = new SqlCommand(selectusername, connection))
                        {
                            checkUsername.Parameters.AddWithValue(@"usern", register_username.Text.Trim());


                            SqlDataAdapter adapter = new SqlDataAdapter();// allows you to retrieve data from a database, store it in memory in a DataSet or DataTable

                            DataTable table = new DataTable();//The DataTable is an in-memory representation of a single table of data. It can store rows and columns retrieved from a database.
                            adapter.Fill(table);

                            if (table.Rows.Count > 1)
                            {
                                string usern = register_username.Text.Substring(0, 1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show(usern + " Already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text != register_CPass.Text)
                            {
                                MessageBox.Show("Password Dosen't  Match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else if (register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Password Length Too short " + "At least 8 characters needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else 
                            {
                                string insertData = "insert into users (username,password,profile_image,role,status,date_req )" +
                                    "Values(@usern,@pass,@image,@role,@status,@date)";
                                DateTime today =DateTime.Today;
                                using (SqlCommand cmd = new SqlCommand(insertData, connection)) 
                                {
                                    cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image",null);
                                    cmd.Parameters.AddWithValue("@role", "Cashier");
                                    cmd.Parameters.AddWithValue("@status", "Approve");
                                    cmd.Parameters.AddWithValue("@date",today);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registered Sucessfullu!!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                       MessageBox.Show("Connection failed","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Information)
                    }
                    finally
                    {

                        connection.Close();
                    }
                }
               
                
            }
        }
    }
}
