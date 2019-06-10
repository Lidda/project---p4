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
    public partial class OrderMenuUI : Form
    {
        //OrderItemLogic orderItemLogic = new OrderItemLogic();
        ItemLogic itemLogic = new ItemLogic();
        OrderItemLogic orderItemLogic = new OrderItemLogic();

        Order order = new Order();

        List<ListView> listViews = new List<ListView>();
        List<Item> items;

        OrderHomeUI orderMenuUI;
        OrderOverviewUI orderOverviewUI;
            
        public OrderMenuUI(Order order, OrderHomeUI orderMenuUI, string panelName)
        {
            InitializeComponent();

            this.orderMenuUI = orderMenuUI;

            listViews.Add(listView_StartersLunch);
            listViews.Add(listView_MainCoursesLunch);
            listViews.Add(listView_DessertsLunch);
            listViews.Add(listView_StartersDinner);
            listViews.Add(listView_MainCoursesDinner);
            listViews.Add(listView_SideDishesDinner);
            listViews.Add(listView_DessertsDinner);
            listViews.Add(listView_HotDrinks);
            listViews.Add(listView_Soda);
            listViews.Add(listView_Wine);
            listViews.Add(listView_Beer);
            listViews.Add(listView_DistilledDrinks);

            ShowPanel(panelName);

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
                if (item.foodtype == "Lunch")
                {
                    AssignItemToListViewLunch(item);
                }
                else if (item.foodtype == "Diner")
                {
                    AssignItemToListViewDinner(item);
                }
                else if (item.course == "Drank")
                {
                    AssignItemToListViewBeverages(item);
                }
            }
        }
        private void AssignItemToListViewLunch(Item item)
        {
            if (item.course == "Voorgerecht")
            {
                AddItemToListView(listView_StartersLunch, item);
            }
            else if (item.course == "Hoofdgerecht")
            {
                AddItemToListView(listView_MainCoursesLunch, item);
            }
            else if (item.course == "Nagerecht")
            {
                AddItemToListView(listView_DessertsLunch, item);
            }
        }

        //
        private void AssignItemToListViewDinner(Item item)
        {
            if (item.course == "Voorgerecht")
            {
                AddItemToListView(listView_StartersDinner, item);
            }
            else if (item.course == "Hoofdgerecht")
            {
                AddItemToListView(listView_MainCoursesDinner, item);
            }
            else if (item.course == "Nagerecht")
            {
                AddItemToListView(listView_DessertsDinner, item);
            }
            else if (item.course == "Tussengerecht")
            {
                AddItemToListView(listView_SideDishesDinner, item);
            }
        }

        //Adds item to drinks
        private void AssignItemToListViewBeverages(Item item)
        {
            if (item.foodtype == "Frisdrank")
            {
                AddItemToListView(listView_Soda, item);
            }
            else if (item.foodtype == "Thee" || item.foodtype == "Koffie")
            {
                AddItemToListView(listView_HotDrinks, item);
            }
            else if (item.foodtype == "Bier")
            {
                AddItemToListView(listView_Beer, item);
            }
            else if (item.foodtype == "Gedestilleerde drank")
            {
                AddItemToListView(listView_DistilledDrinks, item);
            }
            else if (item.foodtype == "Wijn")
            {
                AddItemToListView(listView_Wine, item);
            }
        }



        //Adds item to the right listview
        private void AddItemToListView(ListView listView, Item item)
        {
            ListViewItem li = new ListViewItem(item.name);
            li.SubItems.Add("0");
            li.SubItems.Add(item.itemID.ToString());
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
                int amount = Convert.ToInt32(listView.SelectedItems[0].SubItems[1].Text);
                int stock = Convert.ToInt32(listView.SelectedItems[0].SubItems[3].Text);

                if (stock <= 0)
                {
                    MessageBox.Show("Dit product is niet meer op voorraad");
                }
                else
                {
                    amount++;
                    stock--;

                    listView.SelectedItems[0].SubItems[1].Text = amount.ToString();
                    listView.SelectedItems[0].SubItems[3].Text = stock.ToString();
                }
            }
        }

        //Lowers the quantity of selected item
        private void SubtractItem(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                int amount = Convert.ToInt32(listView.SelectedItems[0].SubItems[1].Text);
                int stock = Convert.ToInt32(listView.SelectedItems[0].SubItems[3].Text);

                if (amount >= 1)
                {
                    amount--;
                    stock++;

                    listView.SelectedItems[0].SubItems[1].Text = amount.ToString();
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
                    int amount = Convert.ToInt32(listView.Items[i].SubItems[1].Text);
                    int ID = Convert.ToInt32(listView.Items[i].SubItems[2].Text);


                    if (amount >= 1)
                    {
                        Item item = items.Find(j => j.itemID == ID);

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
            else if (panelName == "")
            {
                btn_DrinksPanel.BackColor = Color.FromKnownColor(KnownColor.Highlight);
                btn_LunchPanel.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen);
                btn_DinnerPanel.BackColor = Color.FromKnownColor(KnownColor.Highlight);

                pnl_Dinner.Hide();
                pnl_Drinks.Hide();
            }
            else if (panelName == "Dinner")
            {
                btn_DrinksPanel.BackColor = Color.FromKnownColor(KnownColor.Highlight);
                btn_LunchPanel.BackColor = Color.FromKnownColor(KnownColor.Highlight);
                btn_DinnerPanel.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen);

                pnl_Drinks.Hide();

                pnl_Dinner.Show();
            }
            else if (panelName == "Drinks")
            {
                btn_DrinksPanel.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen);
                btn_LunchPanel.BackColor = Color.FromKnownColor(KnownColor.Highlight);
                btn_DinnerPanel.BackColor = Color.FromKnownColor(KnownColor.Highlight);

                pnl_Dinner.Hide();

                pnl_Drinks.Show();
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
                pnl_Comment.BringToFront();
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

        private void btn_AddStarterDinner_Click(object sender, EventArgs e)
        {
            AddItem(listView_StartersDinner);
        }

        private void btn_CommentStarter_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_StartersDinner);
        }

        private void btn_SubtractStarterDinner_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_StartersDinner);
        }

        private void btn_AddMainCourseDinner_Click(object sender, EventArgs e)
        {
            AddItem(listView_MainCoursesDinner);
        }

        private void btn_CommentMainCourseDinner_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_MainCoursesDinner);
        }

        private void btn_SubtractMainCourseDinner_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_MainCoursesDinner);
        }

        private void btn_AddSideDishDinner_Click(object sender, EventArgs e)
        {
            AddItem(listView_SideDishesDinner);
        }

        private void btn_CommentSideDishDinner_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_SideDishesDinner);
        }

        private void btn_SubtractSideDishDinner_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_SideDishesDinner);
        }

        private void btn_AddDessertDinner_Click(object sender, EventArgs e)
        {
            AddItem(listView_DessertsDinner);
        }

        private void btn_CommentDessertDinner_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_DessertsDinner);
        }

        private void btn_SubtrackDessertDinner_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_DessertsDinner);
        }

        private void btn_AddHotDrink_Click(object sender, EventArgs e)
        {
            AddItem(listView_HotDrinks);
        }

        private void btn_CommentHotDrink_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_HotDrinks);
        }

        private void btn_SubtractHotDrink_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_HotDrinks);
        }

        private void btn_AddSoda_Click(object sender, EventArgs e)
        {
            AddItem(listView_Soda);
        }

        private void btn_CommentSoda_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_Soda);
        }

        private void btn_SubtractSoda_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_Soda);
        }

        private void btn_AddWine_Click(object sender, EventArgs e)
        {
            AddItem(listView_Wine);
        }

        private void btn_CommentWine_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_Wine);
        }

        private void btn_SubtractWine_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_Wine);
        }

        private void btn_AddBeer_Click(object sender, EventArgs e)
        {
            AddItem(listView_Beer);
        }

        private void btn_CommentBeer_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_Beer);
        }

        private void btn_SubtractBeer_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_Beer);
        }

        private void btn_AddDistilledDrink_Click(object sender, EventArgs e)
        {
            AddItem(listView_DistilledDrinks);
        }

        private void btn_CommentDistilledDrinks_Click(object sender, EventArgs e)
        {
            CheckSelection(listView_DistilledDrinks);
        }

        private void btn_SubtractDistilledDrink_Click(object sender, EventArgs e)
        {
            SubtractItem(listView_DistilledDrinks);
        }

        private void btn_Drankjes_Click(object sender, EventArgs e)
        {
            ShowPanel("Drinks");
        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            ShowPanel("");
        }

        private void btn_Dinner_Click(object sender, EventArgs e)
        {
            ShowPanel("Dinner");
        }
    }
}
