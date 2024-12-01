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

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = true;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void adminAddUsers1_Load(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult  result = MessageBox.Show("Are you sure  you want  to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result==DialogResult.Yes )
                {
                Application.Exit();
            }
;        }

        private void button5_Click(object sender, EventArgs e)//Should be names as LogOut_button but unknown error occur
        {
            DialogResult check = MessageBox.Show("Are you Sure to log out ?","Confirmation Message ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginPage login=new LoginPage();
                login.Show();
                this.Hide();

            }
        }

        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = true;
            adminAddProducts1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adminDashboardForm1.Visible = false;
            adminAddUsers1.Visible = false;
            adminAddProducts1.Visible = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminDashboardForm1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void addMain_customerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
