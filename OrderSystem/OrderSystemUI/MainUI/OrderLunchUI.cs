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
    public partial class OrderLunchUI : Form
    {
        TakeOrderLogic takeOrderLogic = new TakeOrderLogic();
        OrderItem orderItem;

        OrderMenuUI orderMenuUI;
        Employee employee;
        Table table;
            
        public OrderLunchUI(Employee employee, Table table, OrderMenuUI orderMenuUI)
        {
            InitializeComponent();

            this.employee = employee;
            this.table = table;
            this.orderMenuUI = orderMenuUI;

            AddItemsToLabels();

            orderMenuUI.Hide();
        }

        private void AddItemsToLabels()
        {
            List<Item> items = takeOrderLogic.GetLunchItems();

            lView_Starters.Items.Clear();

            foreach (Item item in items)
            {
                if (item.course == "Starter")
                {
                    ListViewItem listViewItem  = new ListViewItem(item.name);
                    listViewItem.SubItems.Add("0");
                    lView_Starters.Items.Add(listViewItem);
                }
                else if (item.course == "Main course")
                {
                    ListViewItem listViewItem = new ListViewItem(item.name);
                    listViewItem.SubItems.Add("0");
                    lView_MainCourses.Items.Add(listViewItem);
                }
                else
                {
                    ListViewItem listViewItem = new ListViewItem(item.name);
                    listViewItem.SubItems.Add("0");
                    lView_Desserts.Items.Add(listViewItem);
                }
            }
        }
       
    }
}
