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
                    ListView_Stock.Items.Add(li);
                }
            }
        }

        private void AddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
