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
        List<OrderItem> orderItem;
        List<Item> items;

        OrderMenuUI orderMenuUI;
        Employee employee;
        Table table;
            
        public OrderLunchUI(Employee employee, Table table, OrderMenuUI orderMenuUI)
        {
            InitializeComponent();

            this.employee = employee;
            this.table = table;
            this.orderMenuUI = orderMenuUI;

            AddItemsToListViews();

            orderMenuUI.Hide();
        }

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

        

        private void btn_AddDessert1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listView_Starters.Items[0].SubItems[1].Text) + 1;
            listView_Starters.Items[0].SubItems[1].Text = count.ToString();
        }

        private void btn_AddStarter2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listView_Starters.Items[1].SubItems[1].Text) + 1;
            listView_Starters.Items[1].SubItems[1].Text = count.ToString();
        }

        private void btn_AddStarter3_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listView_Starters.Items[2].SubItems[1].Text) + 1;
            listView_Starters.Items[2].SubItems[1].Text = count.ToString();
        }

        private void btn_SubtractStarter1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listView_Starters.Items[0].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_Starters.Items[1].SubItems[0].Text) - 1;
                listView_Starters.Items[0].SubItems[1].Text = count.ToString();
            }
        }

        private void btn_SubtractStarter2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listView_Starters.Items[1].SubItems[1].Text) >= 1)
                {
                int count = Convert.ToInt32(listView_Starters.Items[1].SubItems[1].Text) - 1;
                listView_Starters.Items[1].SubItems[1].Text = count.ToString();
            }
        }

        private void btn_SubtractStarter3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listView_Starters.Items[2].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_Starters.Items[2].SubItems[1].Text) - 1;
                listView_Starters.Items[2].SubItems[1].Text = count.ToString();
            }
        }

        private void btn_AddMainCourse1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listView_MainCourses.Items[0].SubItems[1].Text) + 1;
            listView_MainCourses.Items[0].SubItems[1].Text = count.ToString();
        }

        private void btn_AddMainCourse2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listView_MainCourses.Items[1].SubItems[1].Text) + 1;
            listView_MainCourses.Items[1].SubItems[1].Text = count.ToString();
        }

        private void btn_AddMainCourse3_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listView_MainCourses.Items[2].SubItems[1].Text) + 1;
            listView_MainCourses.Items[2].SubItems[1].Text = count.ToString();
        }

        private void btn_SubtractMainCourse1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listView_MainCourses.Items[0].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_MainCourses.Items[0].SubItems[1].Text) - 1;
                listView_MainCourses.Items[0].SubItems[1].Text = count.ToString();
            }
        }

        private void btn_SubtractMainCourse2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listView_MainCourses.Items[1].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_MainCourses.Items[1].SubItems[1].Text) - 1;
                listView_MainCourses.Items[1].SubItems[1].Text = count.ToString();
            }
        }

        private void btn_SubtractMainCourse3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listView_MainCourses.Items[2].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_MainCourses.Items[2].SubItems[1].Text) - 1;
                listView_MainCourses.Items[2].SubItems[1].Text = count.ToString();
            }
        }

        private void btn_AddDessert1_Click_1(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listView_Desserts.Items[0].SubItems[1].Text) + 1;
            listView_Desserts.Items[0].SubItems[1].Text = count.ToString();
        }

        private void btn_AddDessert2_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listView_Desserts.Items[1].SubItems[1].Text) + 1;
            listView_Desserts.Items[1].SubItems[1].Text = count.ToString();
        }

        private void btn_AddDessert3_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listView_Desserts.Items[2].SubItems[1].Text) + 1;
            listView_Desserts.Items[2].SubItems[1].Text = count.ToString();
        }

        private void btn_SubtractDessert1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listView_Desserts.Items[0].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_Desserts.Items[0].SubItems[1].Text) - 1;
                listView_Desserts.Items[0].SubItems[1].Text = count.ToString();
            }
        }

        private void btn_SubtractDessert2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listView_Desserts.Items[1].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_Desserts.Items[1].SubItems[1].Text) - 1;
                listView_Desserts.Items[1].SubItems[1].Text = count.ToString();
            }
        }

        private void btn_SubtractDessert3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listView_Desserts.Items[2].SubItems[1].Text) >= 1)
            {
                int count = Convert.ToInt32(listView_Desserts.Items[2].SubItems[1].Text) - 1;
                listView_Desserts.Items[2].SubItems[1].Text = count.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderMenuUI.Show();
            this.Close();
        }
    }
}
