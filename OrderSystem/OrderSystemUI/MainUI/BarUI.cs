using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemLogic;
using OrderSystemModel;
using System.Windows.Forms;

namespace OrderSystemUI.MainUI
{
    public partial class BarUI : Form
    {
        Employee employee;
        OrderLogic orderLogic = new OrderLogic();
        OrderItemLogic orderItemLogic = new OrderItemLogic();
        List<OrderItem> orders = new List<OrderItem>();
        public BarUI(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            //Loads orders and hides mark ready button
            btn_markReady1.Hide();
            btn_OrderOverview.Hide();
            LvHistory.Hide();
            OrdersAll();
        }

        public void OrdersAll()
        {
            //clears listviews before filling it again
            LvOverview.Items.Clear();
            LvHistory.Items.Clear();
            //gets all orders from database
            orders = orderItemLogic.GetOrdersBar();
            //Loops through orders to get all orderitems from the database
            foreach (OrderItem order in orders)
            {
                //fills listview with orderitems/items from database
                ListViewItem li;
                li = new ListViewItem(order.ID.ToString());
                li.SubItems.Add(order.order.orderDate.ToString("dd/MM/yyyy"));
                li.SubItems.Add(order.TimeOfOrder.ToString("HH:mm"));
                li.SubItems.Add(order.item.name);
                li.SubItems.Add(order.amount.ToString());
                li.SubItems.Add(order.order.Table.ID.ToString());
                li.SubItems.Add(order.comment);
                li.SubItems.Add(order.status.ToString());

                //If there is an order with status ordered add to listview, change color of that subitem in listview and show the button to mark ready
                if (order.status == OrderItem.Status.ordered)
                {
                    li.BackColor = Color.Tomato;
                    btn_markReady1.Show();
                    LvOverview.Items.Add(li);
                }
                if (order.status == OrderItem.Status.ready)
                {
                    li.BackColor = Color.MediumSeaGreen;
                    LvOverview.Items.Add(li);

                }

                if (order.status == OrderItem.Status.delivered)
                {
                    LvHistory.Items.Add(li);
                }

            }
        }
        
        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            //Loads all orders again
            OrdersAll();


        }
        private void timerTime_Tick(object sender, EventArgs e)
        {
            //Shows time and refreshes every second
            this.TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        
        private void btn_markReady1_Click(object sender, EventArgs e)
        {
            //Mark order ready
            ChangeOrderStatus();
        }

        private void ChangeOrderStatus()
        {
            //If a listview item is selected, execute code
            if (LvOverview.SelectedItems.Count > 0)
            {
                //Gets orderID from first column and sets orderItemID to that value
                int orderItemID = Convert.ToInt32(LvOverview.SelectedItems[0].SubItems[0].Text);
                //Change status on orderItemID to ready
                orderLogic.ChangeOrderStatus(orderItemID, OrderItem.Status.ready);
                //Change status column to ready manually
                LvOverview.SelectedItems[0].SubItems[7].Text = "ready";
                LvOverview.SelectedItems[0].BackColor = Color.MediumSeaGreen;
            }
        }

        private void btn_FilterNew_Click(object sender, EventArgs e)
        {
            FilterOrdersNew();
        }

        private void FilterOrdersNew()
        {
            //Loops through listview to check columns with value ready
            for (int i = LvOverview.Items.Count - 1; i >= 0; --i)
                if (LvOverview.Items[i].SubItems[7].Text == "ready")
                {
                    //removes rows with value ready
                    LvOverview.Items[i].Remove();
                }
            //If there are no listview items in listview hide mark ready button
            if (LvOverview.Items.Count == 0)
            {
                btn_markReady1.Hide();
            }
        }

        private void btn_OrderHistory_Click(object sender, EventArgs e)
        {
            //Hides and shows all relevant buttons and listviews
            LvOverview.Hide();
            btn_markReady1.Hide();
            btn_OrderHistory.Hide();
            btn_FilterNew.Hide();
            btn_OrderOverview.Show();
            LvHistory.Show();
        }

        private void btn_OrderOverview_Click(object sender, EventArgs e)
        {
            //Hides and shows all relevant buttons and listviews
            btn_OrderOverview.Hide();
            LvHistory.Hide();
            LvOverview.Show();
            btn_OrderHistory.Show();
            btn_FilterNew.Show();
            //Only show button if overview listview has items
            if (LvOverview.Items.Count > 0)
            {
                btn_markReady1.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //brings you back to login screen
            this.Hide();
            LoginUI loginUI = new LoginUI();
            loginUI.ShowDialog();
            this.Close();

        }
    }
}


