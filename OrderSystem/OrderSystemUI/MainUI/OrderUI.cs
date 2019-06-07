using System;
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
    public partial class OrderUI : Form
    {
        OrderItemLogic orderItemLogic = new OrderItemLogic();
        ItemLogic itemLogic = new ItemLogic();
        Order order = new Order();

        List<ListView> listViews = new List<ListView>();
        List<Item> items;

        OrderMenuUI orderMenuUI;
            
        public OrderUI(Order order, OrderMenuUI orderMenuUI)
        {
            InitializeComponent();

            this.orderMenuUI = orderMenuUI;

            listViews.Add(listView_Starters);
            listViews.Add(listView_MainCourses);
            listViews.Add(listView_Desserts);

            this.order = order;

            AssignItemsToListViews();

            orderMenuUI.Hide();
        }

        //Fills the listviews with all lunch items
        private void AssignItemsToListViews()
        {
            items = itemLogic.GetAllItems();

            foreach (ListView listView in listViews)
            {
                listView.Items.Clear();
            }

            foreach (Item item in items)
            {
                if (item.course == "Starter" && item.foodtype == "Lunch")
                {
                    AddItemToListView(listView_Starters, item);
                }
                else if (item.course == "Main course" && item.foodtype == "Lunch")
                {
                    AddItemToListView(listView_MainCourses, item);
                }
                else if ((item.course == "Dessert" && item.foodtype == "Lunch"))
                {
                    AddItemToListView(listView_Desserts, item);
                }
            }
        }

        //Adds item to the right listview
        private void AddItemToListView(ListView listView, Item item)
        {
            ListViewItem listViewItem = new ListViewItem(item.name);
            listViewItem.SubItems.Add("0");
            listViewItem.SubItems.Add("");
            listViewItem.SubItems.Add(item.stock.ToString());
            listView.Items.Add(listViewItem);
        }

        //Goes to previous screen
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderMenuUI.Show();
            this.Close();
        }

        //Ups the quantity of selected item
        private void AddItem(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                int count = Convert.ToInt32(listView.SelectedItems[0].SubItems[1].Text) + 1;
                listView.SelectedItems[0].SubItems[1].Text = count.ToString();
            }
        }

        //Lowers the quantity of selected item
        private void SubtractItem(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                if (Convert.ToInt32(listView.SelectedItems[0].SubItems[1].Text) >= 1)
                {
                    int count = Convert.ToInt32(listView.SelectedItems[0].SubItems[1].Text) - 1;
                    listView.SelectedItems[0].SubItems[1].Text = count.ToString();
                }
            }
            
        }

        private void AddItemToOrder(int amount, string comment, Item item)
        {
            OrderItem orderItem = new OrderItem();

            orderItem.item = item;
            orderItem.amount = amount;
            orderItem.comment = comment;
            orderItem.status = OrderItem.Status.ordered;

            order.orderItems.Add(orderItem);
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

            foreach (ListView listView in listViews)
            {
                for (int i = 0; i < listView.Items.Count; i++)
                {
                    if (Convert.ToInt32(listView.Items[i].SubItems[1].Text) >= 1)
                    {
                        int amount = Convert.ToInt32(listView.Items[i].SubItems[1].Text);
                        Item item = items.Find(j => j.name == listView_Starters.Items[i].SubItems[0].Text);

                        AddItemToOrder(amount, listView.Items[i].SubItems[2].Text, item);
                    }
                }
            }
            orderItemLogic.AddItemsToOrder(order);

            order.orderItems.Clear();
        }

        private void btn_AddDessert_Click(object sender, EventArgs e)
        {
            AddItem(listView_Desserts);
        }

        private void btn_SubtractDessert_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_Desserts);
        }

        private void btn_AddStarter_Click(object sender, EventArgs e)
        {
            AddItem(listView_Starters);
        }

        private void btn_SubtractStarter_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_Starters);
        }

        private void btn_AddMainCourse_Click(object sender, EventArgs e)
        {
            AddItem(listView_MainCourses);
        }

        private void btn_SubtractMainCourse_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_MainCourses);
        }
    }
}
