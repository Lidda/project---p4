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
        public void Order1(List<Order> order)
        {
            int tableID = 1;
            orders = orderLogic.GetOrderskitchen(tableID);
            listView1.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem orders in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(orders.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(orders.item.name);
                    li.SubItems.Add(orders.item.foodtype);
                    li.SubItems.Add(orders.amount.ToString());
                    if (orders.status == OrderItem.Status.ordered)
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
        public void Order2(List<Order> order)
        {
            int tableID = 2;
            orders = orderLogic.GetOrderskitchen(tableID);
            listView2.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem orders in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(orders.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(orders.item.name);
                    li.SubItems.Add(orders.item.foodtype);
                    li.SubItems.Add(orders.amount.ToString());
                    if (orders.status == OrderItem.Status.ordered)
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
        public void Order3(List<Order> order)
        {
            int tableID = 3;
            orders = orderLogic.GetOrderskitchen(tableID);
            listView3.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem orders in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(orders.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(orders.item.name);
                    li.SubItems.Add(orders.item.foodtype);
                    li.SubItems.Add(orders.amount.ToString());
                    if (orders.status == OrderItem.Status.ordered)
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
        public void Order4(List<Order> order)
        {
            int tableID = 4;
            orders = orderLogic.GetOrderskitchen(tableID);
            listView4.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem orders in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(orders.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(orders.item.name);
                    li.SubItems.Add(orders.item.foodtype);
                    li.SubItems.Add(orders.amount.ToString());
                    if (orders.status == OrderItem.Status.ordered)
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
        public void Order5(List<Order> order)
        {
            int tableID = 5;
            orders = orderLogic.GetOrderskitchen(tableID);
            listView5.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem orders in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(orders.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(orders.item.name);
                    li.SubItems.Add(orders.item.foodtype);
                    li.SubItems.Add(orders.amount.ToString());
                    if (orders.status == OrderItem.Status.ordered)
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
        public void Order6(List<Order> order)
        {
            int tableID = 6;
            orders = orderLogic.GetOrderskitchen(tableID);
            listView6.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem orders in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(orders.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(orders.item.name);
                    li.SubItems.Add(orders.item.foodtype);
                    li.SubItems.Add(orders.amount.ToString());
                    if (orders.status == OrderItem.Status.ordered)
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
        public void Order7(List<Order> order)
        {
            int tableID = 7;
            orders = orderLogic.GetOrderskitchen(tableID);
            listView7.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem orders in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(orders.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(orders.item.name);
                    li.SubItems.Add(orders.item.foodtype);
                    li.SubItems.Add(orders.amount.ToString());
                    if (orders.status == OrderItem.Status.ordered)
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
        public void Order8(List<Order> order)
        {
            int tableID = 8;
            orders = orderLogic.GetOrderskitchen(tableID);
            listView8.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem orders in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(orders.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(orders.item.name);
                    li.SubItems.Add(orders.item.foodtype);
                    li.SubItems.Add(orders.amount.ToString());
                    if (orders.status == OrderItem.Status.ordered)
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
        public void Order9(List<Order> order)
        {
            int tableID = 9;
            orders = orderLogic.GetOrderskitchen(tableID);
            listView9.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem orders in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(orders.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(orders.item.name);
                    li.SubItems.Add(orders.item.foodtype);
                    li.SubItems.Add(orders.amount.ToString());
                    if (orders.status == OrderItem.Status.ordered)
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

        public void Order10(List<Order> order)
        {
            int tableID = 10;
            orders = orderLogic.GetOrderskitchen(tableID);
            listView10.Items.Clear();
            foreach (Order o in orders)
            {
                foreach (OrderItem orders in o.orderItems)
                {
                    ListViewItem li = new ListViewItem(orders.TimeOfOrder.ToString("HH:mm"));
                    li.SubItems.Add(orders.item.name);
                    li.SubItems.Add(orders.item.foodtype);
                    li.SubItems.Add(orders.amount.ToString());
                    if (orders.status == OrderItem.Status.ordered)
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
           
        }
    }
}
