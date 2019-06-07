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
        TakeOrderLogic takeOrderLogic = new TakeOrderLogic();
        ItemLogic itemLogic = new ItemLogic();
        List<OrderItem> orderItems = new List<OrderItem>();
        List<ListView> listViews = new List<ListView>();
        List<Item> items;
        Employee employee;
        Table table;

        OrderMenuUI orderMenuUI;
        int orderID;
            
        public OrderUI(Employee employee, Table table, int orderID, OrderMenuUI orderMenuUI)
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
            items = itemLogic.GetAllItems();

            listView_Starters.Items.Clear();

            foreach (Item item in items)
            {
                if (item.course == "Starter" && item.foodtype == "Lunch")
                {
                    ListViewItem listViewItem  = new ListViewItem(item.name);
                    listViewItem.SubItems.Add("0");
                    listView_Starters.Items.Add(listViewItem);
                }
                else if (item.course == "Main course" && item.foodtype == "Lunch")
                {
                    ListViewItem listViewItem = new ListViewItem(item.name);
                    listViewItem.SubItems.Add("0");
                    listView_MainCourses.Items.Add(listViewItem);
                }
                else if ((item.course == "Dessert" && item.foodtype == "Lunch"))
                {
                    ListViewItem listViewItem = new ListViewItem(item.name);
                    listViewItem.SubItems.Add("0");
                    listView_Desserts.Items.Add(listViewItem);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderMenuUI.Show();
            this.Close();
        }
        
        //Subtracts dessert
        private void btn_SubtractDessert_Click()
        {
            if (Convert.ToInt32(listView_Desserts.SelectedItems[0].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_Desserts.SelectedItems[0].SubItems[1].Text) - 1;
                listView_Desserts.SelectedItems[0].SubItems[1].Text = count.ToString();
            }
        }

        private void AddItem(ListView listView)
        {
            int count = Convert.ToInt32(listView.SelectedItems[0].SubItems[1].Text) + 1;
            listView.SelectedItems[0].SubItems[1].Text = count.ToString();
        }

        private void SubtractItem(ListView listView)
        {
            if (Convert.ToInt32(listView_Desserts.SelectedItems[0].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_Desserts.SelectedItems[0].SubItems[1].Text) - 1;
                listView_Desserts.SelectedItems[0].SubItems[1].Text = count.ToString();
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

                    AddItemToOrder(amount, listView_MainCourses.Items[i].SubItems[1].Text, item);
                }

                if (Convert.ToInt32(listView_MainCourses.Items[i].SubItems[1].Text) >= 1)
                {
                    int amount = Convert.ToInt32(listView_MainCourses.Items[i].SubItems[1].Text);
                    Item item = items.Find(j => j.name == listView_MainCourses.Items[i].SubItems[0].Text);

                    AddItemToOrder(amount, listView_MainCourses.Items[i].SubItems[1].Text,  item);
                }

                if (Convert.ToInt32(listView_Desserts.Items[i].SubItems[1].Text) >= 1)
                {
                    int amount = Convert.ToInt32(listView_Desserts.Items[i].SubItems[1].Text);
                    Item item = items.Find(j => j.name == listView_Desserts.Items[i].SubItems[0].Text);

                    AddItemToOrder(amount, listView_MainCourses.Items[i].SubItems[1].Text, item);
                }
            }

            takeOrderLogic.AddItemsToOrder(orderItems);

            ResetQuantity();
        }

        private void AddItemToOrder(int amount, string comment, Item item)
        {
            OrderItem orderItem = new OrderItem();

            orderItem.item = item;
            orderItem.amount = amount;
            orderItem.comment = comment;
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
