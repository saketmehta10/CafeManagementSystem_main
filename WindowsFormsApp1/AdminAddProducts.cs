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
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");

        public AdminAddProducts()
        {
            InitializeComponent();
            displayData();
        }



        public bool emptyFields()
        {
            if (adminAddProducts_id.Text == "" || adminAddProducts_name.Text == "" || adminAddProducts_type.SelectedIndex == -1 || adminAddProducts_stock.Text == ""
                || adminAddProducts_price.Text == "" || adminAddProducts_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayData()
        {
            AdminAddProductsData prodData = new AdminAddProductsData();
            List<AdminAddProductsData> listData = prodData.productsListData();
            dataGridView1.DataSource = listData;
        }


        //Update Button Functionallity
        private void adminAddProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update Product ID " + adminAddProducts_id.Text.Trim() + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE products SET prod_name = @prodName, prod_type = @prodType, prod_stock = @prodStock, prod_price = @prodPrice, prod_status = @prodStatus, date_update = @dateUpdate WHERE prod_id = @prodID";

                            DateTime today = DateTime.Today;

                            //Parameterized Query for update
                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodType", adminAddProducts_type.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodStock", adminAddProducts_stock.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodPrice", adminAddProducts_price.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.Text.Trim());
                                updateD.Parameters.AddWithValue("@dateUpdate", today); // Current timestamp
                                updateD.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());

                                updateD.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void adminAddProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Delete Product ID " + adminAddProducts_id.Text.Trim() + "?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE products SET date_delete = @dateDelete WHERE prod_id = @prodID";

                            DateTime today = DateTime.Today;
                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@dateDelete", today); // Set deletion date
                                updateD.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());

                                updateD.ExecuteNonQuery();
                                clearFields();
                                MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void adminAddProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectProdId = "SELECT * FROM products Where prod_id = @prodID";

                        using (SqlCommand selectPID = new SqlCommand(selectProdId, connect))
                        {
                            selectPID.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(selectPID);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Product Id " + adminAddProducts_id.Text.Trim() + " is already taken", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO products (prod_id,prod_name,prod_type,prod_stock,prod_price,prod_status,prod_image,date_insert)" +
                                    " VALUES (@prodID,@prodName,@prodType,@prodStock,@prodPrice,@prodStatus,@prodImage,@dateInsert)";

                                DateTime today = DateTime.Today;


                                //file path where the product's image will be saved.
                                string path = Path.Combine(@"C:\Product_Images\" + adminAddProducts_id.Text.Trim() + ".jpg");  // Change path as needed

                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }


                                File.Copy(adminAddProducts_imageView.ImageLocation, path, true);  //Copies the selected image file to the specified path. 
                                                                                                  // //adminAddProducts_imageView.ImageLocation: The full path of the source image file(selected by the user in the UI).
                                                                                                  //path: The destination where the image will be saved.
                                                                                                  //true: Overwrites the file at the destination if it already exists.

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodType", adminAddProducts_type.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStock", adminAddProducts_stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodPrice", adminAddProducts_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodImage", path);
                                    cmd.Parameters.AddWithValue("@dateInsert", today);

                                    cmd.ExecuteNonQuery();
                                    clearFields();
                                    MessageBox.Show("Added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayData();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void adminAddProducts_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();   //This is a built-in Windows dialog that allows the user to browse their file system and select files
                dialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";  //Restricts the types of files the user can select

                if (dialog.ShowDialog() == DialogResult.OK)  //DialogResult.OK: Indicates that the user selected a file and clicked OK.
                {
                    adminAddProducts_imageView.ImageLocation = dialog.FileName;   //location of the selected file/image
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearFields()
        {
            adminAddProducts_id.Text = "";
            adminAddProducts_name.Text = "";
            adminAddProducts_type.SelectedItem = -1;
            adminAddProducts_stock.Text = "";
            adminAddProducts_price.Text = "";
            adminAddProducts_status.SelectedItem = -1;
            adminAddProducts_imageView.Image = null;
        }

        private void adminAddProducts_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];  //Retrieves the entire row that corresponds to the clicked cell.

                //Assigns the values from specific cells in the clicked row to corresponding input fields.
                adminAddProducts_id.Text = row.Cells[1].Value.ToString();
                adminAddProducts_name.Text = row.Cells[2].Value.ToString();
                adminAddProducts_type.Text = row.Cells[3].Value.ToString();
                adminAddProducts_stock.Text = row.Cells[4].Value.ToString();
                adminAddProducts_price.Text = row.Cells[5].Value.ToString();
                adminAddProducts_status.Text = row.Cells[6].Value.ToString();

                string imagePath = row.Cells[7].Value.ToString();

                try
                {
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        adminAddProducts_imageView.ImageLocation = imagePath;
                    }
                    else
                    {
                        adminAddProducts_imageView.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}
