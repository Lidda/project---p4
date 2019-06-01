using OrderSystemModel;
using OrderSystemLogic;
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
    public partial class KitchenUI : Form {
        Employee employee;

        public KitchenUI(Employee employee) {
            this.employee = employee;
            InitializeComponent();
            order1();
        }
         
        public void order1()
        {
            OrderSystemLogic.BarKitchenLogic kitchenLogic = new OrderSystemLogic.BarKitchenLogic();
            List<OrderItem> OrderList = kitchenLogic.GetOrders();

            // clear the listview before filling it again
            listView1.Clear();
            //Make Collumns
            listView1.Columns.Add("TableID");
            listView1.Columns[0].Width = 100;
            listView1.Columns.Add("Food Name");
            listView1.Columns[1].Width = 100;
            listView1.Columns.Add("Amount");
            listView1.Columns[2].Width = 100;
            listView1.Columns.Add("Foodtype");
            listView1.Columns[3].Width = 100;
            listView1.Columns.Add("Comment");
            listView1.Columns[4].Width = 100;
            listView1.Columns.Add("Status");
            listView1.Columns[5].Width = 100;
            foreach (OrderSystemModel.OrderItem o in OrderList)
            {

                ListViewItem li = new ListViewItem(o.tableID.ToString());
                li.SubItems.Add(o.foodname);
                li.SubItems.Add(o.amount.ToString());
                li.SubItems.Add(o.foodtype);
                li.SubItems.Add(o.comment);
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
