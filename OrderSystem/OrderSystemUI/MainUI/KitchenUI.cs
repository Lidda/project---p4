﻿using System;
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
        OrderItemLogic orderItemLogic = new OrderItemLogic();
        List<OrderItem> orders = new List<OrderItem>();
        Order orderlist = new Order();
        public KitchenUI(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            //Loads order method
            OrdersAll(orders);
            btn_markReady1.Hide();
        }


        public void OrdersAll(List<OrderItem> orders)
        {
            //clears listview before filling it again
            listView1.Items.Clear();
            //gets all orders from database
            orders = orderItemLogic.GetOrdersKitchen();
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

                if (li.SubItems.Count > 0)
                {
                    //If there is an order with status ordered, change color  and show the button to mark ready
                    listView1.BackColor = Color.Tomato;
                    listView1.Items.Add(li);
                    btn_markReady1.Show();
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
            //Mark order ready
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
            //gets orders from database
            orders = orderItemLogic.GetOrdersKitchen();
            //loops through orders to get all orderitems from database
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

                if (li.SubItems.Count > 0 & order.status == OrderItem.Status.ordered)
                {
                    //If there is an order with status ordered, change color of listview to red and show the button to mark ready
                    listView1.BackColor = Color.Tomato;
                    listView1.Items.Add(li);
                    btn_markReady1.Show();
                }

            }


        }

    }
}


