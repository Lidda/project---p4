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
    public partial class KitchenUI : Form
    {
        Employee employee;
        OrderLogic orderLogic = new OrderLogic();
        List<Order> orders = new List<Order>();
        public KitchenUI(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            //Hides buttons
            btn_markReady1.Hide();
            btn_markReady2.Hide();
            btn_markReady3.Hide();
            btn_markReady4.Hide();
            btn_markReady5.Hide();
            btn_markReady6.Hide();
            btn_markReady7.Hide();
            btn_markReady8.Hide();
            btn_markReady9.Hide();
            btn_markReady10.Hide();
            //Loads order methods
            Order1(orders);
            Order2(orders);
            Order3(orders);
            Order4(orders);
            Order5(orders);
            Order6(orders);
            Order7(orders);
            Order8(orders);
            Order9(orders);
            Order10(orders);

        }
        public void Order1(List<Order> orders)
        {
            //Gets order for table 1 from database
            orders = orderLogic.GetOrderskitchen(1);
            //clears listview before filling it again
            listView1.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    //fills listview with orderitems/items from database
                    ListViewItem li;
                    li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.item.course != "Drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        //If there is an order with status ordered, change color of listview to red and show the button to mark ready
                        listView1.BackColor = Color.Tomato;
                        listView1.Items.Add(li);
                        btn_markReady1.Show();
                    }
                  
                }
                break;
            }
        }
        public void Order2(List<Order> orders)
        {
            orders = orderLogic.GetOrderskitchen(2);
            listView2.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    ListViewItem li;
                    li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.item.course != "Drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        listView2.BackColor = Color.Tomato;
                        listView2.Items.Add(li);
                        btn_markReady2.Show();
                    }
                    
                }
                break;
            }
        }
        public void Order3(List<Order> orders)
        {
            orders = orderLogic.GetOrderskitchen(3);
            listView3.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    ListViewItem li;
                    li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.item.course != "Drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        listView3.BackColor = Color.Tomato;
                        listView3.Items.Add(li);
                        btn_markReady3.Show();
                    }
                   
                }
                break;
            }
        }
        public void Order4(List<Order> orders)
        {
            orders = orderLogic.GetOrderskitchen(4);
            listView4.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    ListViewItem li;
                    li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.item.course != "Drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        listView4.BackColor = Color.Tomato;
                        listView4.Items.Add(li);
                        btn_markReady4.Show();
                    }
                    
                }
                break;
            }
        }
        public void Order5(List<Order> orders)
        {
            orders = orderLogic.GetOrderskitchen(5);
            listView5.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    ListViewItem li;
                    li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.item.course != "Drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        listView5.BackColor = Color.Tomato;
                        listView5.Items.Add(li);
                        btn_markReady5.Show();
                    }
                    
                }
                break;
            }
        }
        public void Order6(List<Order> orders)
        {
            orders = orderLogic.GetOrderskitchen(6);
            listView6.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    ListViewItem li;
                    li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.item.course != "Drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        listView6.BackColor = Color.Tomato;
                        listView6.Items.Add(li);
                        btn_markReady6.Show();
                    }
                   
                }
                break;
            }
        }
        public void Order7(List<Order> orders)
        {
            orders = orderLogic.GetOrderskitchen(7);
            listView7.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    ListViewItem li;
                    li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.item.course != "Drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        listView7.BackColor = Color.Tomato;
                        listView7.Items.Add(li);
                        btn_markReady7.Show();
                    }
                    
                }
                break;
            }
        }
        public void Order8(List<Order> orders)
        {
            orders = orderLogic.GetOrderskitchen(8);
            listView8.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    ListViewItem li;
                    li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.item.course != "Drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        listView8.BackColor = Color.Tomato;
                        listView8.Items.Add(li);
                        btn_markReady8.Show();
                    }
                   
                }
                break;
            }
        }
        public void Order9(List<Order> orders)
        {
            orders = orderLogic.GetOrderskitchen(9);
            listView9.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    ListViewItem li;
                    li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.item.course != "Drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        listView9.Items.Add(li);
                        listView9.BackColor = Color.Tomato;
                        btn_markReady9.Show();
                    }
                }
                break;
            }
        }

        public void Order10(List<Order> orders)
        {
            orders = orderLogic.GetOrderskitchen(10);
            listView10.Items.Clear();

            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    ListViewItem li;
                    li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.item.course != "Drank" & li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                    {
                        listView10.Items.Add(li);
                        listView10.BackColor = Color.Tomato;
                        btn_markReady10.Show();
                    }
                }
                break;
            }
        }
        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            //Loads all orders again
            Order1(orders);
            Order2(orders);
            Order3(orders);
            Order4(orders);
            Order5(orders);
            Order6(orders);
            Order7(orders);
            Order8(orders);
            Order9(orders);
            Order10(orders);

        }
        private void timerTime_Tick(object sender, EventArgs e)
        {
            //Shows time and refreshes every second
            this.TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_markReady1_Click(object sender, EventArgs e)
        {
            //Mark order from table 1 as ready
           orderLogic.ChangeStatusKitchen(1, OrderItem.Status.ordered, OrderItem.Status.ready);
            listView1.BackColor = Color.MediumSeaGreen;
            //Hides button after clicking it
            btn_markReady1.Hide();
            Order1(orders);
        }

        private void btn_markReady2_Click(object sender, EventArgs e)
        {
           orderLogic.ChangeStatusKitchen(2, OrderItem.Status.ordered, OrderItem.Status.ready);
            listView2.BackColor = Color.MediumSeaGreen;
            btn_markReady2.Hide();
            Order2(orders);
        }

        private void btn_markReady3_Click(object sender, EventArgs e)
        {
           orderLogic.ChangeStatusKitchen(3, OrderItem.Status.ordered, OrderItem.Status.ready);
            listView3.BackColor = Color.MediumSeaGreen;
            btn_markReady3.Hide();
            Order3(orders);
        }

        private void btn_markReady4_Click(object sender, EventArgs e)
        {
           orderLogic.ChangeStatusKitchen(4, OrderItem.Status.ordered, OrderItem.Status.ready);
            listView4.BackColor = Color.MediumSeaGreen;
            btn_markReady4.Hide();
            Order4(orders);
        }

        private void btn_markReady5_Click(object sender, EventArgs e)
        {
           orderLogic.ChangeStatusKitchen(5, OrderItem.Status.ordered, OrderItem.Status.ready);
            listView5.BackColor = Color.MediumSeaGreen;
            btn_markReady5.Hide();
            Order5(orders);
        }

        private void btn_markReady6_Click(object sender, EventArgs e)
        {
           orderLogic.ChangeStatusKitchen(6, OrderItem.Status.ordered, OrderItem.Status.ready);
            listView6.BackColor = Color.MediumSeaGreen;
            btn_markReady6.Hide();
            Order6(orders);
        }

        private void btn_markReady7_Click(object sender, EventArgs e)
        {
           orderLogic.ChangeStatusKitchen(7, OrderItem.Status.ordered, OrderItem.Status.ready);
            listView7.BackColor = Color.MediumSeaGreen;
            btn_markReady7.Hide();
            Order7(orders);
        }

        private void btn_markReady8_Click(object sender, EventArgs e)
        {
           orderLogic.ChangeStatusKitchen(8, OrderItem.Status.ordered, OrderItem.Status.ready);
            listView8.BackColor = Color.MediumSeaGreen;
            btn_markReady8.Hide();
            Order8(orders);
        }

        private void btn_markReady9_Click(object sender, EventArgs e)
        {
           orderLogic.ChangeStatusKitchen(9, OrderItem.Status.ordered, OrderItem.Status.ready);
            listView9.BackColor = Color.MediumSeaGreen;
            btn_markReady9.Hide();
            Order9(orders);
        }

        private void btn_markReady10_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeStatusKitchen(10, OrderItem.Status.ordered, OrderItem.Status.ready);
            listView10.BackColor = Color.MediumSeaGreen;
            btn_markReady10.Hide();
            Order10(orders);
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
