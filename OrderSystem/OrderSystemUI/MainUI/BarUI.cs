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
        List<Order> orders = new List<Order>();
        Order orderlist = new Order();
        public BarUI(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            //Loads order method
            OrdersAll(orders);
        }

        public void OrdersAll(List<Order> orders)
        {
            //clears listview before filling it again
            listView1.Items.Clear();
            //Loops through orders and then loops through all orderitems in orders to get all orderitems from the database
            orders = orderLogic.GetOrdersBarOpen();
            foreach (Order o in orders)
            {
                orderlist = o;
                foreach (OrderItem order in o.orderItems)
                {
                    //fills listview with orderitems/items from database
                    ListViewItem li;
                    li = new ListViewItem(order.ID.ToString());
                    li.SubItems.Add(o.orderDate.ToString("dd/mm/yyyy"));
                    li.SubItems.Add(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    li.SubItems.Add(o.Table.ID.ToString());
                    li.SubItems.Add(order.comment);
                    li.SubItems.Add(order.status.ToString());

                    if (order.item.course == "drank" & li.SubItems.Count > 0 )
                    {
                        //If there is an order with status ordered, change color of listview to red and show the button to mark ready
                        listView1.BackColor = Color.Tomato;
                        listView1.Items.Add(li);
                    }
                    break;
                }

            }
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            //Loads all orders again
            OrdersAll(orders);


        }
        private void timerTime_Tick(object sender, EventArgs e)
        {
            //Shows time and refreshes every second
            this.TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            //brings you back to login screen
            this.Hide();
            LoginUI loginUI = new LoginUI();
            loginUI.ShowDialog();
            this.Close();

        }

        private void btn_markReady1_Click(object sender, EventArgs e)
        {
            //Mark order from table 1 as ready
            //Hides button after clicking it and loads order1 again
            ChangeOrderStatus(listView1);
            OrdersAll(orders);

        }

        private void ChangeOrderStatus(ListView listview1)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int orderItemID = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                orderLogic.ChangeStatusKitchen(orderItemID, OrderItem.Status.ready);
            }
        }

        private void btn_FilterNew_Click(object sender, EventArgs e)
        {
            //clears listview before filling it again
            listView1.Items.Clear();
            //Loops through orders and then loops through all orderitems in orders to get all orderitems from the database
            orders = orderLogic.GetOrdersBarOpen();
            foreach (Order o in orders)
            {
                orderlist = o;
                foreach (OrderItem order in o.orderItems)
                {
                    //fills listview with orderitems/items from database
                    ListViewItem li;
                    li = new ListViewItem(order.ID.ToString());
                    li.SubItems.Add(o.orderDate.ToString("dd/mm/yyyy"));
                    li.SubItems.Add(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    li.SubItems.Add(o.Table.ID.ToString());
                    li.SubItems.Add(order.comment);
                    li.SubItems.Add(order.status.ToString());

                    if (order.item.course == "drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        //If there is an order with status ordered, change color of listview to red and show the button to mark ready
                        listView1.BackColor = Color.Tomato;
                        listView1.Items.Add(li);
                    }
                    break;
                }

            }
        }
    }
}

