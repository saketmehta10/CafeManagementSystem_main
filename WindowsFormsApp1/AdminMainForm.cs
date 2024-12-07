using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        //Dashbord
        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = true;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierCustomersForm1.Visible = false;
            cashierOrderForm1.Visible = false;

        }
        //Add Cashier 
        private void button2_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierOrderForm1.Visible = false;
            cashierCustomersForm1.Visible = false;
        }

        //Add Product
        private void button4_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierOrderForm1.Visible = false;
            cashierCustomersForm1.Visible = false;

        }
        //Add Customer 
        private void addMain_customerBtn_Click(object sender, EventArgs e)
        {
            cashierCustomersForm1.Visible = true;
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierOrderForm1.Visible = false;


        }


        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e) // Should be named as LogOut_button but unknown error occurs
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginPage login = new LoginPage();
                login.Show();
                this.Hide();
            }
        }


        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void adminAddUsers1_Load(object sender, EventArgs e)
        {

        }

        
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminDashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierOrderForm1.Visible = true;
            cashierCustomersForm1.Visible = false;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Your drawing code here
        }
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            // Your code for when the form loads goes here
        }

        private void cashierOrderForm1_Load(object sender, EventArgs e)
        {

        }

        private void cashierCustomersForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
