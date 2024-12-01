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
    }
}
