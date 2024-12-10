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
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)//close  button
        {
            DialogResult check = MessageBox.Show("Are you sure You  want to exit ?","Confirmation message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (check==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want  to exit","Confirmation message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            { 
               LoginPage login =new LoginPage();
                login.Show();
                this.Hide();
            }
        }

        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminAddProducts1_Load_1(object sender, EventArgs e)
        {

        }

        private void Custome_btn_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierOrderForm1.Visible = false;
            cashierCustomersForm1.Visible = true;

           cashierCustomersForm ccForm = cashierCustomersForm1 as cashierCustomersForm;

            if (ccForm != null)
            {
                ccForm.refreshData();
            }
        }
    

           

        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddProducts1.Visible = true;
            cashierOrderForm1.Visible = false;
            cashierCustomersForm1.Visible = false;

            AdminAddProducts aaProd = adminAddProducts1 as AdminAddProducts;

            if (aaProd != null)
            {
                aaProd.refreshData();
            }
        }
    
        private void Order_btn_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddProducts1.Visible = false;
            cashierOrderForm1.Visible = true;
            cashierCustomersForm1.Visible = false;

            CashierOrderForm coForm = cashierOrderForm1 as CashierOrderForm;

            if (coForm != null)
            {
                coForm.refreshData();
            }
        
        }


        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = true;
            adminAddProducts1.Visible = false;
            cashierOrderForm1.Visible = false;
            cashierCustomersForm1.Visible = false;
            AdminDashboardForm adForm= adminDashboardForm1 as  AdminDashboardForm;
            if (adForm != null)
            {
                adForm.refreshData();
            }

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
