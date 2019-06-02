using OrderSystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystemUI.MainUI {
    public partial class BarUI : Form {
        Employee employee;
        public BarUI(Employee employee) {
            this.employee = employee;
            InitializeComponent();
            order1();
        }
        public void order1()
        {
            int tableID = 4;
            
            OrderSystemLogic.BarKitchenLogic barLogic = new OrderSystemLogic.BarKitchenLogic();
            List<OrderItem> OrderList = barLogic.GetDrinks(tableID);

            // clear the listview before filling it again
            listView1.Clear();
            //Make Collumns
            listView1.Columns.Add("Table ID");
            listView1.Columns[0].Width = 70;
            listView1.Columns.Add("Foodname");
            listView1.Columns[0].Width = 70;
            listView1.Columns.Add("Type");
            listView1.Columns[0].Width = 70;
            listView1.Columns.Add("Amount");
            listView1.Columns[3].Width = 70;
            listView1.Columns.Add("Status");
            listView1.Columns[4].Width = 70;

            foreach (OrderSystemModel.OrderItem o in OrderList)
            {

                ListViewItem li = new ListViewItem(o.tableID.ToString());
                li.SubItems.Add(o.name);
                li.SubItems.Add(o.foodtype);
                li.SubItems.Add(o.amount.ToString());
                li.SubItems.Add(o.status.ToString());

                listView1.Items.Add(li);
            }


        }

        private void btnLogout_Click(object sender, EventArgs e) {
            this.Hide();
            LoginUI loginUI = new LoginUI();
            loginUI.ShowDialog();
            this.Close();
        }
    }
}
