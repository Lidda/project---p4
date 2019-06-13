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
    public partial class EditStockUI : Form
    {
        ItemLogic itemLogic = new ItemLogic();
        Employee loggedInEmployee;
        Item selectedItem = new Item();

        public EditStockUI(Employee loggedInEmployee)
        {
            InitializeComponent();
            ShowPanel("PNL_ManageStock");
            this.loggedInEmployee = loggedInEmployee;
        }

        //Shows the requested panel
        private void ShowPanel(string panelName)
        {
            if (panelName == "PNL_ManageStock")
            {
                PNL_AddItem.Hide();
                PNL_EditItem.Hide();
                PNL_ManageStock.Show();


                List<Item> Items = itemLogic.GetAllItems();

                ListView_Stock.Items.Clear();

                foreach (Item item in Items)
                {
                    ListViewItem li = new ListViewItem(item.itemID.ToString());
                    li.SubItems.Add(item.name);
                    li.SubItems.Add(item.stock.ToString());
                    li.SubItems.Add(item.price.ToString());
                    li.SubItems.Add(item.tax.ToString());
                    li.SubItems.Add(item.course);
                    li.SubItems.Add(item.foodtype);
                    li.SubItems.Add(item.description);
                    ListView_Stock.Items.Add(li);
                }
            }
            else if (panelName == "PNL_AddItem")
            {
                PNL_ManageStock.Hide();
                PNL_AddItem.Show();
            }
            else if(panelName == "PNL_EditItem")
            {               
                try
                {
                    TXTB_EditName.Text = selectedItem.name;
                    TXTB_EditStock.Text = selectedItem.stock.ToString();
                    TXTB_EditPrice.Text = selectedItem.price.ToString();
                    DB_EditCourse.Text = selectedItem.course;
                    DB_EditTAX.Text = selectedItem.tax.ToString();
                    DB_EditType.Text = selectedItem.foodtype;
                    TXTB_EditDescription.Text = selectedItem.description;
                    PNL_ManageStock.Hide();
                    PNL_EditItem.Show();
                }
                catch
                {
                    MessageBox.Show("Selecteer eerst een product");
                }
            }
        }
        //Go to add item panel
        private void AddItem_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_AddItem");
        }

        //go to edit item panel
        private void EditItem_Click(object sender, EventArgs e)
        {
            if (selectedItem.itemID != 0)                
            {
                ShowPanel("PNL_EditItem");
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product");
            }
        }

        private void BTN_AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                Item item = new Item()
                {
                    name = TXTB_AddName.Text,
                    stock = int.Parse(TXTB_AddStock.Text),
                    price = double.Parse(TXTB_AddPrice.Text),
                    course = DB_AddCourse.Text,
                    description = TXTB_AddDescription.Text,
                    tax = int.Parse(DB_AddTAX.Text.Substring(0, 1)),
                    foodtype = DB_AddType.Text
                };
                itemLogic.Additem(item);
                MessageBox.Show("Item was succesfully Added");
                ShowPanel("PNL_ManageStock");
            }
            catch
            {
                MessageBox.Show("Niet alle velden zijn gevuld");
            }
        }

        private void BTN_EditItem_Click(object sender, EventArgs e)
        {
            try
            {
                    selectedItem.name = TXTB_EditName.Text;
                    selectedItem.stock = int.Parse(TXTB_EditStock.Text);
                    selectedItem.price = double.Parse(TXTB_EditPrice.Text);
                    selectedItem.course = DB_EditCourse.Text;
                    selectedItem.description = TXTB_EditDescription.Text;
                    selectedItem.tax = int.Parse(DB_EditTAX.Text.Substring(0, 1));
                    selectedItem.foodtype = DB_EditType.Text;

                    itemLogic.EditItem(selectedItem);
                    selectedItem = new Item();
                    MessageBox.Show("Item was succesfully Edited");
                    ShowPanel("PNL_ManageStock");
            }
            catch
            {
                MessageBox.Show("Niet alle velden zijn gevuld");
            }
        }
    

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (selectedItem.itemID != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this item?", "Deleting...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    itemLogic.DeleteItem(selectedItem);
                    selectedItem = new Item();
                    MessageBox.Show("Item was succesfully deleted");
                    ShowPanel("PNL_ManageStock");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product");
            }
        }

        //Displays information from the selected field into the selected item object
        private void ListView_Stock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItem.itemID  = int.Parse(e.Item.SubItems[0].Text);
            selectedItem.name = e.Item.SubItems[1].Text;
            selectedItem.stock = int.Parse(e.Item.SubItems[2].Text);
            selectedItem.price = double.Parse(e.Item.SubItems[3].Text);
            selectedItem.tax = int.Parse(e.Item.SubItems[4].Text);
            selectedItem.course =  e.Item.SubItems[5].Text;
            selectedItem.foodtype = e.Item.SubItems[6].Text;
            selectedItem.description = e.Item.SubItems[7].Text;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerUI managerUI = new ManagerUI(loggedInEmployee);
            managerUI.ShowDialog();
        }

        //back button Add panel
        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_ManageStock");
        }

        //back button Edit panel
        private void button3_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_ManageStock");
        }
    }
}
