﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystemLogic;
using OrderSystemModel;

namespace OrderSystemUI.MainUI
{
    public partial class OrderLunchUI : Form
    {
        TakeOrderLogic takeOrderLogic = new TakeOrderLogic();
        List<OrderItem> orderItems = new List<OrderItem>();
        List<Item> items;
        Employee employee;
        Table table;

        OrderMenuUI orderMenuUI;
        int orderID;
            
        public OrderLunchUI(Employee employee, Table table, int orderID, OrderMenuUI orderMenuUI)
        {
            InitializeComponent();

            this.orderID = orderID;
            this.orderMenuUI = orderMenuUI;
            this.table = table;
            this.employee = employee;

            AddItemsToListViews();

            orderMenuUI.Hide();
        }

        //Fills the listviews with all lunch items
        private void AddItemsToListViews()
        {
            items = takeOrderLogic.GetLunchItems();

            listView_Starters.Items.Clear();

            foreach (Item item in items)
            {
                if (item.course == "Starter")
                {
                    ListViewItem listViewItem  = new ListViewItem(item.name);
                    listViewItem.SubItems.Add("0");
                    listView_Starters.Items.Add(listViewItem);
                }
                else if (item.course == "Main course")
                {
                    ListViewItem listViewItem = new ListViewItem(item.name);
                    listViewItem.SubItems.Add("0");
                    listView_MainCourses.Items.Add(listViewItem);
                }
                else
                {
                    ListViewItem listViewItem = new ListViewItem(item.name);
                    listViewItem.SubItems.Add("0");
                    listView_Desserts.Items.Add(listViewItem);
                }
            }
        }
        private void btn_AddStarter1_Click(object sender, EventArgs e)
        {
            AddStarter(0);
        }

        private void btn_AddStarter2_Click(object sender, EventArgs e)
        {
            AddStarter(1);
        }

        private void btn_AddStarter3_Click(object sender, EventArgs e)
        {
            AddStarter(2);
        }

        private void btn_SubtractStarter1_Click(object sender, EventArgs e)
        {
            SubtractStarter(0);
        }

        private void btn_SubtractStarter2_Click(object sender, EventArgs e)
        {
            SubtractStarter(1);
        }

        private void btn_SubtractStarter3_Click(object sender, EventArgs e)
        {
            SubtractStarter(2);
        }

        private void btn_AddMainCourse1_Click(object sender, EventArgs e)
        {
            AddMainCourse(0);
        }

        private void btn_AddMainCourse2_Click(object sender, EventArgs e)
        {
            AddMainCourse(1);
        }

        private void btn_AddMainCourse3_Click(object sender, EventArgs e)
        {
            AddMainCourse(2);
        }

        private void btn_SubtractMainCourse1_Click(object sender, EventArgs e)
        {
            SubtractMainCourse(0);
        }

        private void btn_SubtractMainCourse2_Click(object sender, EventArgs e)
        {
            SubtractMainCourse(1);
        }

        private void btn_SubtractMainCourse3_Click(object sender, EventArgs e)
        {
            SubtractMainCourse(2);
        }

        private void btn_AddDessert1_Click(object sender, EventArgs e)
        {
            AddDessert(0);
        }

        private void btn_AddDessert2_Click(object sender, EventArgs e)
        {
            AddDessert(1);
        }

        private void btn_AddDessert3_Click(object sender, EventArgs e)
        {
            AddDessert(2);
        }

        private void btn_SubtractDessert1_Click(object sender, EventArgs e)
        {
            SubtractDessert(0);
        }

        private void btn_SubtractDessert2_Click(object sender, EventArgs e)
        {
            SubtractDessert(1);
        }

        private void btn_SubtractDessert3_Click(object sender, EventArgs e)
        {
            SubtractDessert(2);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderMenuUI.Show();
            this.Close();
        }

        //Adds starters
        private void AddStarter(int index)
        {
            int count = Convert.ToInt32(listView_Starters.Items[index].SubItems[1].Text) + 1;
            listView_Starters.Items[index].SubItems[1].Text = count.ToString();
        }

        //Subtracts starters
        private void SubtractStarter(int index)
        {
            if (Convert.ToInt32(listView_Starters.Items[index].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_Starters.Items[index].SubItems[1].Text) - 1;
                listView_Starters.Items[index].SubItems[1].Text = count.ToString();
            }
        }

        //Adds main course
        private void AddMainCourse(int index)
        {
            int count = Convert.ToInt32(listView_MainCourses.Items[index].SubItems[1].Text) + 1;
            listView_MainCourses.Items[index].SubItems[1].Text = count.ToString();
        }

        //Subtracts main course
        private void SubtractMainCourse(int index)
        {
            if (Convert.ToInt32(listView_MainCourses.Items[index].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_MainCourses.Items[index].SubItems[1].Text) - 1;
                listView_MainCourses.Items[index].SubItems[1].Text = count.ToString();
            }
        }

        //Adds dessert
        private void AddDessert(int index)
        {
            int count = Convert.ToInt32(listView_Desserts.Items[index].SubItems[1].Text) + 1;
            listView_Desserts.Items[index].SubItems[1].Text = count.ToString();
        }

        //Subtracts dessert
        private void SubtractDessert(int index)
        {
            if (Convert.ToInt32(listView_Desserts.Items[index].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_Desserts.Items[index].SubItems[1].Text) - 1;
                listView_Desserts.Items[index].SubItems[1].Text = count.ToString();
            }
        }

        private void btn_AddItems_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (Convert.ToInt32(listView_Starters.Items[i].SubItems[1].Text) >= 1)
                {
                    int amount = Convert.ToInt32(listView_Starters.Items[i].SubItems[1].Text);
                    Item item = items.Find(j => j.name == listView_Starters.Items[i].SubItems[0].Text);

                    AddItemToOrder(amount, item);
                }

                if (Convert.ToInt32(listView_MainCourses.Items[i].SubItems[1].Text) >= 1)
                {
                    int amount = Convert.ToInt32(listView_MainCourses.Items[i].SubItems[1].Text);
                    Item item = items.Find(j => j.name == listView_MainCourses.Items[i].SubItems[0].Text);

                    AddItemToOrder(amount, item);
                }

                if (Convert.ToInt32(listView_Desserts.Items[i].SubItems[1].Text) >= 1)
                {
                    int amount = Convert.ToInt32(listView_Desserts.Items[i].SubItems[1].Text);
                    Item item = items.Find(j => j.name == listView_Desserts.Items[i].SubItems[0].Text);

                    AddItemToOrder(amount, item);
                }
            }

            takeOrderLogic.AddItemsToOrder(orderItems);

            ResetQuantity();
        }

        private void AddItemToOrder(int amount, Item item)
        {
            OrderItem orderItem = new OrderItem();

            orderItem.item = item;
            orderItem.amount = amount;
            orderItem.comment = "";
            orderItem.status = OrderItem.Status.ordered;

            orderItems.Add(orderItem);
        }

        private void ResetQuantity()
        {
            for (int i = 0; i < 3; i++)
            {
                listView_Starters.Items[i].SubItems[1].Text = "0";
                listView_MainCourses.Items[i].SubItems[1].Text = "0";
                listView_Desserts.Items[i].SubItems[1].Text = "0";
            }
        }

        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutOverviewOrder orderOverview = new CheckoutOverviewOrder(new Order());
            orderOverview.ShowDialog();
        }
    }
}
