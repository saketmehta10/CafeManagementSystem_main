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
    public partial class CashierOrderForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Database"";Integrated Security=True;");

        public CashierOrderForm()
        {
            InitializeComponent();
        }

        private void CashierOrderForm_Load(object sender, EventArgs e)
        {

        }

        public void displayAvailableProd() 
        {
           AdminAddProductsData allProds= new AdminAddProductsData();
            List<AdminAddProductsData>listData= new List<AdminAddProductsData>();
            cashierOrderForm_menuTable.DataSource = listData;



        }
    }
}
