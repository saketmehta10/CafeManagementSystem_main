using CafeShopManagementSystem;
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
    public partial class cashierCustomersForm : UserControl
    {
        public cashierCustomersForm()
        {
            InitializeComponent();

            displayCustomersData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomersData();
        }


        public void displayCustomersData()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allCustomersData();

            datagridView1.DataSource = listData;
        }


        private void datagridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
