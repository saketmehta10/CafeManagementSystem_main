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
    public partial class AdminAddUsers : UserControl
    {
        public AdminAddUsers()
        {
            InitializeComponent();
            displayAddUsersData(); //calling method
        }

        public void displayAddUsersData()    //Purpose: To display user data in a DataGridView.
        {
            AdminAddUsersData usersData = new AdminAddUsersData();    //Creates an instance of the AdminAddUsersData class.

            List<AdminAddUsersData> listData = usersData.usersListData();   // calling usersListData() method from AdminAddUsersData.cs to fetch the actual data:


            dataGridView1 = new DataGridView();   //: DataGridView is a UI component in Windows Forms used to display data in a tabular format.
            dataGridView1.DataSource = listData;  //  Binds the data in listData to the DataGridView. Any data in the list would now be displayed in the grid.
            
            //This data will show in the AdminMainForm.cs in display grid
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
