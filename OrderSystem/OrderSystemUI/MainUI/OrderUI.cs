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
        //OrderItemLogic orderItemLogic = new OrderItemLogic();
        ItemLogic itemLogic = new ItemLogic();
        OrderItemLogic orderItemLogic = new OrderItemLogic();

        Order order = new Order();

        List<ListView> listViews = new List<ListView>();
        List<Item> items;

        OrderMenuUI orderMenuUI;
        OrderOverviewUI orderOverviewUI;
            
        public OrderUI(Order order, OrderMenuUI orderMenuUI)
        {
            InitializeComponent();

            this.orderMenuUI = orderMenuUI;

            listViews.Add(listView_StartersLunch);
            listViews.Add(listView_MainCoursesLunch);
            listViews.Add(listView_DessertsLunch);

            this.order = order;
            this.order.orderItems.Clear();

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
                    AddItemToListView(listView_StartersLunch, item);
                }
                else if (item.course == "Main course" && item.foodtype == "Lunch")
                {
                    AddItemToListView(listView_MainCoursesLunch, item);
                }
                else if ((item.course == "Dessert" && item.foodtype == "Lunch"))
                {
                    AddItemToListView(listView_DessertsLunch, item);
                }
            }
        }

        //Adds item to the right listview
        private void AddItemToListView(ListView listView, Item item)
        {
            ListViewItem li = new ListViewItem(item.name);
            li.SubItems.Add("0");
            li.SubItems.Add(item.price.ToString());
            li.SubItems.Add(item.stock.ToString());
            li.SubItems.Add("");
            listView.Items.Add(li);
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
                if (Convert.ToInt32(listView.SelectedItems[0].SubItems[3].Text) == 0)
                {
                    MessageBox.Show("Error", "Dit product is niet meer op voorraad");
                }
                else
                {
                    int count = Convert.ToInt32(listView.SelectedItems[0].SubItems[1].Text) + 1;
                    listView.SelectedItems[0].SubItems[1].Text = count.ToString();
                }
                
            }
        }

        //Lowers the quantity of selected item
        private void SubtractItem(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                int count = Convert.ToInt32(listView.SelectedItems[0].SubItems[1].Text);

                if (count >= 1)
                {
                    listView.SelectedItems[0].SubItems[1].Text = count.ToString();
                }
            }
        }

        private void AddItemToOrder(int amount, Item item, string comment)
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
                listView_StartersLunch.Items[i].SubItems[1].Text = "0";
                listView_MainCoursesLunch.Items[i].SubItems[1].Text = "0";
                listView_DessertsLunch.Items[i].SubItems[1].Text = "0";
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
                        Item item = items.Find(j => j.name == listView.Items[i].SubItems[0].Text);

                        AddItemToOrder(amount, item, listView.Items[i].SubItems[4].Text);
                    }
                }
            }
            orderItemLogic.AddItemsToOrder(order);

            order.orderItems.Clear();
            orderOverviewUI = new OrderOverviewUI(order, orderMenuUI);
            orderOverviewUI.ShowDialog();
        }

        private void btn_AddDessert_Click(object sender, EventArgs e)
        {
            AddItem(listView_DessertsLunch);
        }

        private void btn_SubtractDessert_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_DessertsLunch);
        }

        private void btn_AddStarter_Click(object sender, EventArgs e)
        {
            AddItem(listView_StartersLunch);
        }

        private void btn_SubtractStarter_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_StartersLunch);
        }

        private void btn_AddMainCourse_Click(object sender, EventArgs e)
        {
            AddItem(listView_MainCoursesLunch);
        }

        private void btn_SubtractMainCourse_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_MainCoursesLunch);
        }

        private void ClearListViewSelection(ListView selectedListView)
        {
            foreach (ListView listView in listViews)
            {
                if (listView != selectedListView)
                {
                    listView.SelectedItems.Clear();
                }
            }
        }

        private void ShowPanel(string panelName)
        {
            if(panelName == "Comment")
            {
                pnl_Comment.Show();
            }
        }

        private void btn_AddCommentStarter_Click(object sender, EventArgs e)
        {

            CheckSelection(listView_StartersLunch);
        }

        private void btn_AddCommentDessertLunch_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_DessertsLunch);
        }

        private void btn_AddCommentMainCourseLunch_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_MainCoursesLunch);
        }

        private void CheckSelection(ListView listView)
        {
            if (listView.SelectedItems.Count >= 1)
            {
                ClearListViewSelection(listView);
                ShowPanel("Comment");
            }
            else
            {
                MessageBox.Show("Error", "Selecteer eerst een product");
            }
        }

        private void btn_AddCommentToItem_Click(object sender, EventArgs e)
        {
            foreach (ListView listView in listViews)
            {
                if (listView.SelectedItems.Count >= 1)
                {
                    listView.SelectedItems[0].SubItems[4].Text = txt_AddCommentToItem.Text;

                    pnl_Comment.Hide();
                    txt_AddCommentToItem.Clear();
                }
            }
        }

        private void btn_CancelComment_Click(object sender, EventArgs e)
        {
            txt_AddCommentToItem.Clear();
            pnl_Comment.Hide();
        }
    }
}
