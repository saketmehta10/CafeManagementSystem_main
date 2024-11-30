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
    public partial class LoginPage : Form
    {
        SqlConnection conn;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();//Open the register Form 
            this.Hide();//Close this Form(Login Form) 

        }

        private bool ifEmpty()
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void login_show_CheckedChanged(object sender, EventArgs e)
        {
            //If Checked Show  Password 
            login_password.PasswordChar = login_show.Checked ? '\0' : '*';


        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (ifEmpty())
            {
                MessageBox.Show("All Fields Are  required to be  filled ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                        string searchQuery = "Select * from  users where username=@usern and password =@pass and status=@status";

                        using (SqlCommand cmd = new SqlCommand(searchQuery,conn))
                        {

                            cmd.Parameters.AddWithValue("@usern", login_username.Text);
                            cmd.Parameters.AddWithValue("@pass", login_password.Text);
                            cmd.Parameters.AddWithValue("@status", "Active");
                            cmd.ExecuteNonQuery();
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table=new DataTable();
                            adapter.Fill(table);

                            // if their is a ny data in the table means the query matched And  Login will be sucessfull 
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("login Sucessfull", "Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Calling  AdminMainForm  after login password match 
                                AdminMainForm adminForm = new AdminMainForm();
                                adminForm.Show();
                                this.Hide();
                            }
                            else 
                            {
                                MessageBox.Show("Login or Password incorrect ", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception arise " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }
        }
    }
}
