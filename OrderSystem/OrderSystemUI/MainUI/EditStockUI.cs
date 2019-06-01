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

        public EditStockUI()
        {
            InitializeComponent();
            ShowPanel("PNL_ManageStock");
        }

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
                PNL_ManageStock.Hide();
                PNL_EditItem.Show();
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_AddItem");
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_EditItem");
        }

        private void BTN_AddItem_Click(object sender, EventArgs e)
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

        private void BTN_EditItem_Click(object sender, EventArgs e)
        {
            Item item = new Item()
            {
                itemID = int.Parse(LBL_itemID.Text),
                name = TXTB_EditName.Text,
                stock = int.Parse(TXTB_EditStock.Text),
                price = double.Parse(TXTB_EditPrice.Text),
                course = DB_EditCourse.Text,
                description = TXTB_EditDescription.Text,
                tax = int.Parse(DB_EditTAX.Text.Substring(0, 1)),
                foodtype = DB_EditType.Text
            };
            itemLogic.EditItem(item);
            MessageBox.Show("Item was succesfully Edited");
            ShowPanel("PNL_ManageStock");
        }
    

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            Item item = new Item()
            {
                itemID = int.Parse(LBL_itemID.Text)
            };
            itemLogic.DeleteItem(item);
            MessageBox.Show("Item was succesfully deleted");
            ShowPanel("PNL_ManageStock");
        }

        private void ListView_Stock_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            LBL_itemID.Text = e.Item.SubItems[0].Text;
            TXTB_EditName.Text = e.Item.SubItems[1].Text;
            TXTB_EditStock.Text = e.Item.SubItems[2].Text;
            TXTB_EditPrice.Text = e.Item.SubItems[3].Text;
            DB_EditTAX.Text = e.Item.SubItems[4].Text;
            DB_EditCourse.Text =  e.Item.SubItems[5].Text;
            DB_EditType.Text = e.Item.SubItems[6].Text;
            TXTB_EditDescription.Text = e.Item.SubItems[7].Text;
        }
    }
}
