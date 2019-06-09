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
            orders = orderLogic.GetOrderskitchen(1);
            listView1.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem order in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.item.foodtype);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.status == OrderItem.Status.ordered)
                    {
                        listView1.BackColor = Color.Tomato;
                        listView1.Items.Add(li);
                    }
                    else
                    {
                        listView1.BackColor = Color.MediumSeaGreen;
                    }
                }
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
                    ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.item.foodtype);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.status == OrderItem.Status.ordered)
                    {
                        listView2.BackColor = Color.Tomato;
                        listView2.Items.Add(li);
                    }
                    else
                    {
                        listView2.BackColor = Color.MediumSeaGreen;
                    }
                }
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
                    ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.item.foodtype);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.status == OrderItem.Status.ordered)
                    {
                        listView3.BackColor = Color.Tomato;
                        listView3.Items.Add(li);
                    }
                    else
                    {
                        listView3.BackColor = Color.MediumSeaGreen;
                    }
                }
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
                    ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.item.foodtype);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.status == OrderItem.Status.ordered)
                    {
                        listView4.BackColor = Color.Tomato;
                        listView4.Items.Add(li);
                    }
                    else
                    {
                        listView4.BackColor = Color.MediumSeaGreen;
                    }
                }
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
                    ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.item.foodtype);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.status == OrderItem.Status.ordered)
                    {
                        listView5.BackColor = Color.Tomato;
                        listView5.Items.Add(li);
                    }
                    else
                    {
                        listView5.BackColor = Color.MediumSeaGreen;
                    }
                }
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
                    ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.item.foodtype);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.status == OrderItem.Status.ordered)
                    {
                        listView6.BackColor = Color.Tomato;
                        listView6.Items.Add(li);
                    }
                    else
                    {
                        listView6.BackColor = Color.MediumSeaGreen;
                    }
                }
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
                    ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.item.foodtype);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.status == OrderItem.Status.ordered)
                    {
                        listView7.BackColor = Color.Tomato;
                        listView7.Items.Add(li);
                    }
                    else
                    {
                        listView7.BackColor = Color.MediumSeaGreen;
                    }
                }
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
                    ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.item.foodtype);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.status == OrderItem.Status.ordered)
                    {
                        listView8.BackColor = Color.Tomato;
                        listView8.Items.Add(li);
                    }
                    else
                    {
                        listView8.BackColor = Color.MediumSeaGreen;
                    }
                }
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
                    ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.item.foodtype);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.status == OrderItem.Status.ordered)
                    {
                        listView9.BackColor = Color.Tomato;
                        listView9.Items.Add(li);
                    }
                    else
                    {
                        listView9.BackColor = Color.MediumSeaGreen;
                    }
                }
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
                    ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(order.item.name);
                    li.SubItems.Add(order.item.foodtype);
                    li.SubItems.Add(order.amount.ToString());
                    if (order.status == OrderItem.Status.ordered)
                    {
                        listView10.BackColor = Color.Tomato;
                        listView10.Items.Add(li);
                    }
                    else
                    {
                        listView10.BackColor = Color.MediumSeaGreen;
                    }
                }
            }
        }
        private void Refresh_btn_Click(object sender, EventArgs e)
        {
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
            this.TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_markReady1_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeOrderStatus(1, OrderItem.Status.ordered, OrderItem.Status.ready);
            Order1(orders);
            listView1.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady2_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeOrderStatus(2, OrderItem.Status.ordered, OrderItem.Status.ready);
            Order2(orders);
            listView2.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady3_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeOrderStatus(3, OrderItem.Status.ordered, OrderItem.Status.ready);
            Order3(orders);
            listView3.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady4_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeOrderStatus(4, OrderItem.Status.ordered, OrderItem.Status.ready);
            Order4(orders);
            listView4.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady5_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeOrderStatus(5, OrderItem.Status.ordered, OrderItem.Status.ready);
            Order5(orders);
            listView5.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady6_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeOrderStatus(6, OrderItem.Status.ordered, OrderItem.Status.ready);
            Order6(orders);
            listView6.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady7_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeOrderStatus(7, OrderItem.Status.ordered, OrderItem.Status.ready);
            Order7(orders);
            listView7.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady8_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeOrderStatus(8, OrderItem.Status.ordered, OrderItem.Status.ready);
            Order8(orders);
            listView8.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady9_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeOrderStatus(9, OrderItem.Status.ordered, OrderItem.Status.ready);
            Order9(orders);
            listView9.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady10_Click(object sender, EventArgs e)
        {
            orderLogic.ChangeOrderStatus(10, OrderItem.Status.ordered, OrderItem.Status.ready);
            Order10(orders);
            listView10.BackColor = Color.MediumSeaGreen;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI loginUI = new LoginUI();
            loginUI.ShowDialog();
            this.Close();

        }
    }
}
