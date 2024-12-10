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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class AdminAddUsers : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");

        public AdminAddUsers()
        {
            InitializeComponent();

            displayAddUsersData(); //calling method
        }

        // Purpose: To display user data in a DataGridView.
        public void displayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();

            List<AdminAddUsersData> listData = usersData.usersListData();

            dataGridView1.DataSource = listData;
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAddUsersData();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Purpose: To check if any field is empty.
        public bool emptyField()
        {
            if (adminAddUser_password.Text == "" || adminAddUser_role.Text == "" || adminAddUser_username.Text == "" || adminAddUser_status.Text == "" || adminAddUser_imageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Purpose: Add a new user to the database.
        private void adminAddUser_addbtn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("All fields are required to be Filled ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        using (SqlCommand ch = new SqlCommand("Select * from users where username=@usern", connect))
                        {
                            ch.Parameters.AddWithValue("@usern", adminAddUser_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(ch);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Username already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "insert into users (username, password, profile_image, role, status, date_reg) values (@usern , @pass, @image, @role, @status, @date)";
                                DateTime today = DateTime.Today;

                                // Path to the image in User Directory  
                                string path = Path.Combine(@"C:\Users\Dell\Desktop\Project1\WindowsFormsApp1\WindowsFormsApp1\User_Directory\" + adminAddUser_username.Text.Trim() + ".jpg"); //Trim() removes space from front and end  

                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(adminAddUser_imageView.ImageLocation, path, true);
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", adminAddUser_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", adminAddUser_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@role", adminAddUser_role.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", adminAddUser_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayAddUsersData(); // Refresh the DataGridView to show the updated data
                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        // Purpose: To import and display image from file system.
        private void adminAddUser_importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image file(*.jpg;*.png)|*.jpg;*.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    adminAddUser_imageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int id = 0;

        // Purpose: To populate fields with selected row's data from DataGridView.
        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        //    id = (int)row.Cells[0].Value;
        //    adminAddUser_username.Text = row.Cells[1].Value.ToString();
        //    adminAddUser_password.Text = row.Cells[2].Value.ToString();
        //    adminAddUser_role.Text = row.Cells[3].Value.ToString();
        //    adminAddUser_status.Text = row.Cells[4].Value.ToString();



        //string imagePath = row.Cells[5].Value.ToString();

        //    if (!string.IsNullOrEmpty(imagePath))
        //    {
        //        try
        //        {
        //            // Ensure the path is valid and absolute
        //            string fullImagePath = Path.Combine(@"C:\Users\Dell\Desktop\Project1\WindowsFormsApp1\WindowsFormsApp1\User_Directory", imagePath);

        //            // Check if the file exists before trying to load it
        //            if (File.Exists(fullImagePath))
        //            {
        //                adminAddUser_imageView.Image = Image.FromFile(fullImagePath);
        //            }
        //            else
        //            {
        //                adminAddUser_imageView.Image = null; // Optionally, show a default image
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            // Log or display an error message if there is an issue loading the image
        //            MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        adminAddUser_imageView.Image = null; // Optionally, show a default image
        //    }

        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the selected row index is valid
                if (e.RowIndex >= 0)
                {
                    // Retrieve the selected row
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Assign values from the selected row to your form fields
                    id = (int)row.Cells[0].Value;
                    adminAddUser_username.Text = row.Cells[1].Value.ToString();
                    adminAddUser_password.Text = row.Cells[2].Value.ToString();
                    adminAddUser_role.Text = row.Cells[3].Value.ToString();
                    adminAddUser_status.Text = row.Cells[4].Value.ToString();

                    // Retrieve the image path from the 'ProfileImage' column (e.g., 5th column in DataGridView)
                    string imagePath = row.Cells[5].Value?.ToString();

                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        // Construct the full image path
                        string fullImagePath = Path.Combine(
                            @"C:\Users\Dell\Desktop\Project1\WindowsFormsApp1\WindowsFormsApp1\User_Directory",
                            imagePath
                        );

                        // Check if the file exists
                        if (File.Exists(fullImagePath))
                        {
                            adminAddUser_imageView.Image = Image.FromFile(fullImagePath);
                        }
                        else
                        {
                            // Use a placeholder image if the file doesn't exist
                            string placeholderPath = @"C:\Users\Dell\Desktop\Project1\WindowsFormsApp1\WindowsFormsApp1\User_Directory\prashant.jpg";
                            if (File.Exists(placeholderPath))
                            {
                                adminAddUser_imageView.Image = Image.FromFile(placeholderPath);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Image file does not exist, and placeholder image is missing.",
                                    "Image Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
                                );
                                adminAddUser_imageView.Image = null;
                            }
                        }
                    }
                    else
                    {
                        // Display placeholder for null or empty image paths
                        string placeholderPath = @"C:\Users\Dell\Desktop\Project1\WindowsFormsApp1\WindowsFormsApp1\placeholder.jpg";
                        if (File.Exists(placeholderPath))
                        {
                            adminAddUser_imageView.Image = Image.FromFile(placeholderPath);
                        }
                        else
                        {
                            adminAddUser_imageView.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message for unexpected issues
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Purpose: To update user data in the database.
        private void addUserdata_updatebtn_Click(object sender, EventArgs e)
        {
            if (emptyField())
            {
                MessageBox.Show("All Fields are required to be filled", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update Username: " + adminAddUser_username.Text.Trim(), "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "Update users Set username = @usern, password = @pass, role = @role, status = @status Where id = @id";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", adminAddUser_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", adminAddUser_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", adminAddUser_role.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", adminAddUser_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayAddUsersData(); // Refresh the DataGridView to show the updated data
                                clearFields();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Problem while updating data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        public void clearFields()
        {
            adminAddUser_username.Text = "";
            adminAddUser_password.Text = "";
            adminAddUser_role.SelectedIndex = -1;
            adminAddUser_status.SelectedIndex = -1;
            adminAddUser_imageView.Image = null;
        }
        private void adminAddUser_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();

        }

        private void adminAddUser_deletebtn_Click(object sender, EventArgs e)

        {
            if (emptyField())
            {
                MessageBox.Show("All fields are required to be Filled ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        // Check if the user exists before deleting
                        using (SqlCommand ch = new SqlCommand("Select * from users where username=@usern", connect))
                        {
                            ch.Parameters.AddWithValue("@usern", adminAddUser_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(ch);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count == 0)
                            {
                                MessageBox.Show("User does not exist", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Prepare the delete query
                                string deleteData = "DELETE FROM users WHERE username=@usern";

                                using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", adminAddUser_username.Text.Trim());

                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("User deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayAddUsersData(); // Refresh the DataGridView to show the updated data
                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
