using OrderSystemModel;
using OrderSystemLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystemUI.MainUI
{
    public partial class KitchenUI : Form
    {
        Employee employee;

        OrderSystemLogic.OrderLogic orderLogic = new OrderSystemLogic.OrderLogic();


        public KitchenUI(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            order1();
            order2();
            order3();
            order4();
            order5();
            order6();
            order7();
            order8();
            order9();
            order10();
        }

        public void order1()
        {
            int tableID = 1;


            List<Order> OrderList = orderLogic.GetFoodOrders(tableID);


            // clear the listview before filling it again
            listView1.Clear();
            //Make Collumns
            listView1.Columns.Add("Foodname");
            listView1.Columns[0].Width = 120;
            listView1.Columns.Add("Type");
            listView1.Columns[1].Width = 70;
            listView1.Columns.Add("Amount");
            listView1.Columns[2].Width = 66;
            listView1.Columns.Add("Status");
            listView1.Columns[3].Width = 70;



            foreach (OrderSystemModel.Order o in OrderList)
            {
                string datestring = o.orderItem.TimeOfOrder.ToString("HH:mm");
                Time1.Text = datestring;

                ListViewItem li = new ListViewItem(o.orderItem.item.name);
                li.SubItems.Add(o.orderItem.item.foodtype);
                li.SubItems.Add(o.orderItem.amount.ToString());
                li.SubItems.Add(o.orderItem.status.ToString());
                if (li.SubItems.Count > 0)
                {
                    listView1.BackColor = Color.Tomato;
                    listView1.Items.Add(li);
                }
                else
                {
                    listView1.BackColor = Color.MediumSeaGreen;
                }

            }



        }
        public void order2()
        {
            int tableID = 2;


            List<Order> OrderList = orderLogic.GetFoodOrders(tableID);


            // clear the listview before filling it again
            listView2.Clear();
            //Make Collumns

            listView2.Columns.Add("Foodname");
            listView2.Columns[0].Width = 120;
            listView2.Columns.Add("Type");
            listView2.Columns[1].Width = 70;
            listView2.Columns.Add("Amount");
            listView2.Columns[2].Width = 66;
            listView2.Columns.Add("Status");
            listView2.Columns[3].Width = 70;

            foreach (OrderSystemModel.Order o in OrderList)
            {
                string datestring = o.orderItem.TimeOfOrder.ToString("HH:mm");
                Time2.Text = datestring;

                ListViewItem li = new ListViewItem(o.orderItem.item.name);
                li.SubItems.Add(o.orderItem.item.foodtype);
                li.SubItems.Add(o.orderItem.amount.ToString());
                li.SubItems.Add(o.orderItem.status.ToString());

                if (li.SubItems.Count > 0)
                {
                    listView2.BackColor = Color.Tomato;
                    listView2.Items.Add(li);
                }
                else
                {
                    listView2.BackColor = Color.MediumSeaGreen;
                }

            }
        }
        public void order3()
        {
            int tableID = 3;


            List<Order> OrderList = orderLogic.GetFoodOrders(tableID);


            // clear the listview before filling it again
            listView3.Clear();
            //Make Collumns
            listView3.Columns.Add("Foodname");
            listView3.Columns[0].Width = 120;
            listView3.Columns.Add("Type");
            listView3.Columns[1].Width = 70;
            listView3.Columns.Add("Amount");
            listView3.Columns[2].Width = 66;
            listView3.Columns.Add("Status");
            listView3.Columns[3].Width = 70;

            foreach (OrderSystemModel.Order o in OrderList)
            {

                string datestring = o.orderItem.TimeOfOrder.ToString("HH:mm");
                Time3.Text = datestring;

                ListViewItem li = new ListViewItem(o.orderItem.item.name);
                li.SubItems.Add(o.orderItem.item.foodtype);
                li.SubItems.Add(o.orderItem.amount.ToString());
                li.SubItems.Add(o.orderItem.status.ToString());
                if (li.SubItems.Count > 0)
                {
                    listView3.BackColor = Color.Tomato;
                    listView3.Items.Add(li);
                }
                else
                {
                    listView3.BackColor = Color.MediumSeaGreen;
                }

            }

        }
        public void order4()
        {
            int tableID = 4;


            List<Order> OrderList = orderLogic.GetFoodOrders(tableID);


            // clear the listview before filling it again
            listView4.Clear();
            //Make Collumns
            listView4.Columns.Add("Foodname");
            listView4.Columns[0].Width = 120;
            listView4.Columns.Add("Type");
            listView4.Columns[1].Width = 70;
            listView4.Columns.Add("Amount");
            listView4.Columns[2].Width = 66;
            listView4.Columns.Add("Status");
            listView4.Columns[3].Width = 70;

            foreach (OrderSystemModel.Order o in OrderList)
            {
                string datestring = o.orderItem.TimeOfOrder.ToString("HH:mm");
                Time4.Text = datestring;

                ListViewItem li = new ListViewItem(o.orderItem.item.name);
                li.SubItems.Add(o.orderItem.item.foodtype);
                li.SubItems.Add(o.orderItem.amount.ToString());
                li.SubItems.Add(o.orderItem.status.ToString());

                if (li.SubItems.Count > 0)
                {
                    listView4.BackColor = Color.Tomato;
                    listView4.Items.Add(li);
                }
                else
                {
                    listView4.BackColor = Color.MediumSeaGreen;
                }

            }


        }
        public void order5()
        {
            int tableID = 5;


            List<Order> OrderList = orderLogic.GetFoodOrders(tableID);


            // clear the listview before filling it again
            listView5.Clear();
            //Make Collumns
            listView5.Columns.Add("Foodname");
            listView5.Columns[0].Width = 120;
            listView5.Columns.Add("Type");
            listView5.Columns[1].Width = 70;
            listView5.Columns.Add("Amount");
            listView5.Columns[2].Width = 66;
            listView5.Columns.Add("Status");
            listView5.Columns[3].Width = 70;

            foreach (OrderSystemModel.Order o in OrderList)
            {
                string datestring = o.orderItem.TimeOfOrder.ToString("HH:mm");
                Time5.Text = datestring;

                ListViewItem li = new ListViewItem(o.orderItem.item.name);
                li.SubItems.Add(o.orderItem.item.foodtype);
                li.SubItems.Add(o.orderItem.amount.ToString());
                li.SubItems.Add(o.orderItem.status.ToString());

                if (li.SubItems.Count > 0)
                {
                    listView5.BackColor = Color.Tomato;
                    listView5.Items.Add(li);
                }
                else
                {
                    listView5.BackColor = Color.MediumSeaGreen;
                }

            }


        }
        public void order6()
        {
            int tableID = 6;


            List<Order> OrderList = orderLogic.GetFoodOrders(tableID);


            // clear the listview before filling it again
            listView6.Clear();
            //Make Collumns
            listView6.Columns.Add("Foodname");
            listView6.Columns[0].Width = 120;
            listView6.Columns.Add("Type");
            listView6.Columns[1].Width = 70;
            listView6.Columns.Add("Amount");
            listView6.Columns[2].Width = 66;
            listView6.Columns.Add("Status");
            listView6.Columns[3].Width = 70;

            foreach (OrderSystemModel.Order o in OrderList)
            {
                string datestring = o.orderItem.TimeOfOrder.ToString("HH:mm");
                Time6.Text = datestring;

                ListViewItem li = new ListViewItem(o.orderItem.item.name);
                li.SubItems.Add(o.orderItem.item.foodtype);
                li.SubItems.Add(o.orderItem.amount.ToString());
                li.SubItems.Add(o.orderItem.status.ToString());

                if (li.SubItems.Count > 0)
                {
                    listView6.BackColor = Color.Tomato;
                    listView6.Items.Add(li);
                }
                else
                {
                    listView6.BackColor = Color.MediumSeaGreen;
                }

            }


        }
        public void order7()
        {
            int tableID = 7;


            List<Order> OrderList = orderLogic.GetFoodOrders(tableID);


            // clear the listview before filling it again
            listView7.Clear();
            //Make Collumns
            listView7.Columns.Add("Foodname");
            listView7.Columns[0].Width = 120;
            listView7.Columns.Add("Type");
            listView7.Columns[1].Width = 70;
            listView7.Columns.Add("Amount");
            listView7.Columns[2].Width = 66;
            listView7.Columns.Add("Status");
            listView7.Columns[3].Width = 70;

            foreach (OrderSystemModel.Order o in OrderList)
            {
                string datestring = o.orderItem.TimeOfOrder.ToString("HH:mm");
                Time7.Text = datestring;

                ListViewItem li = new ListViewItem(o.orderItem.item.name);
                li.SubItems.Add(o.orderItem.item.foodtype);
                li.SubItems.Add(o.orderItem.amount.ToString());
                li.SubItems.Add(o.orderItem.status.ToString());

                if (li.SubItems.Count > 0)
                {
                    listView7.BackColor = Color.Tomato;
                    listView7.Items.Add(li);
                }
                else
                {
                    listView7.BackColor = Color.MediumSeaGreen;
                }

            }


        }
        public void order8()
        {
            int tableID = 8;


            List<Order> OrderList = orderLogic.GetFoodOrders(tableID);

            // clear the listview before filling it again
            listView8.Clear();
            //Make Collumns
            listView8.Columns.Add("Foodname");
            listView8.Columns[0].Width = 120;
            listView8.Columns.Add("Type");
            listView8.Columns[1].Width = 70;
            listView8.Columns.Add("Amount");
            listView8.Columns[2].Width = 66;
            listView8.Columns.Add("Status");
            listView8.Columns[3].Width = 70;


            foreach (OrderSystemModel.Order o in OrderList)
            {
                string datestring = o.orderItem.TimeOfOrder.ToString("HH:mm");
                Time8.Text = datestring;

                ListViewItem li = new ListViewItem(o.orderItem.item.name);
                li.SubItems.Add(o.orderItem.item.foodtype);
                li.SubItems.Add(o.orderItem.amount.ToString());
                li.SubItems.Add(o.orderItem.status.ToString());

                if (li.SubItems.Count > 0)
                {
                    listView8.BackColor = Color.Tomato;
                    listView8.Items.Add(li);
                }
                else
                {
                    listView8.BackColor = Color.MediumSeaGreen;
                }


            }

        }
        public void order9()
        {
            int tableID = 9;


            List<Order> OrderList = orderLogic.GetFoodOrders(tableID);


            // clear the listview before filling it again
            listView9.Clear();
            //Make Collumns
            listView9.Columns.Add("Foodname");
            listView9.Columns[0].Width = 120;
            listView9.Columns.Add("Type");
            listView9.Columns[1].Width = 70;
            listView9.Columns.Add("Amount");
            listView9.Columns[2].Width = 66;
            listView9.Columns.Add("Status");
            listView9.Columns[3].Width = 70;

            foreach (OrderSystemModel.Order o in OrderList)
            {

                string datestring = o.orderItem.TimeOfOrder.ToString("HH:mm");
                Time9.Text = datestring;

                ListViewItem li = new ListViewItem(o.orderItem.item.name);
                li.SubItems.Add(o.orderItem.item.foodtype);
                li.SubItems.Add(o.orderItem.amount.ToString());
                li.SubItems.Add(o.orderItem.status.ToString());

                if (li.SubItems.Count > 0)
                {
                    listView9.BackColor = Color.Tomato;
                    listView9.Items.Add(li);
                }
                else
                {
                    listView9.BackColor = Color.MediumSeaGreen;
                }

            }

        }
        public void order10()
        {
            int tableID = 10;


            List<Order> OrderList = orderLogic.GetFoodOrders(tableID);


            // clear the listview before filling it again
            listView10.Clear();
            //Make Collumns
            listView10.Columns.Add("Foodname");
            listView10.Columns[0].Width = 120;
            listView10.Columns.Add("Type");
            listView10.Columns[1].Width = 70;
            listView10.Columns.Add("Amount");
            listView10.Columns[2].Width = 66;
            listView10.Columns.Add("Status");
            listView10.Columns[3].Width = 70;

            foreach (OrderSystemModel.Order o in OrderList)
            {
                string datestring = o.orderItem.TimeOfOrder.ToString("HH:mm");
                Time10.Text = datestring;

                ListViewItem li = new ListViewItem(o.orderItem.item.name);
                li.SubItems.Add(o.orderItem.item.foodtype);
                li.SubItems.Add(o.orderItem.amount.ToString());
                li.SubItems.Add(o.orderItem.status.ToString());

                if (li.SubItems.Count > 0)
                {
                    listView10.BackColor = Color.Tomato;
                    listView10.Items.Add(li);
                }
                else
                {
                    listView10.BackColor = Color.MediumSeaGreen;
                }

            }


        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI loginUI = new LoginUI();
            loginUI.ShowDialog();
            this.Close();
        }

        private void KitchenUI_Load(object sender, EventArgs e)
        {

        }

        private void btn_markReady1_Click(object sender, EventArgs e)
        {
            int statusChange = 1;
            int tableID = 1;


            orderLogic.OrderStatus(tableID, statusChange);
            order1();
            listView1.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady2_Click(object sender, EventArgs e)
        {
            int statusChange = 1;
            int tableID = 2;


            orderLogic.OrderStatus(tableID, statusChange);
            order2();
            listView2.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady3_Click(object sender, EventArgs e)
        {
            int statusChange = 1;
            int tableID = 3;


            orderLogic.OrderStatus(tableID, statusChange);
            order3();
            listView3.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady4_Click(object sender, EventArgs e)
        {
            int statusChange = 1;
            int tableID = 4;


            orderLogic.OrderStatus(tableID, statusChange);
            order4();
            listView4.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady5_Click(object sender, EventArgs e)
        {
            int statusChange = 1;
            int tableID = 5;


            orderLogic.OrderStatus(tableID, statusChange);
            order5();
            listView5.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady6_Click(object sender, EventArgs e)
        {
            int statusChange = 1;
            int tableID = 6;


            orderLogic.OrderStatus(tableID, statusChange);
            order6();
            listView6.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady7_Click(object sender, EventArgs e)
        {
            int statusChange = 1;
            int tableID = 7;


            orderLogic.OrderStatus(tableID, statusChange);
            order7();
            listView7.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady8_Click(object sender, EventArgs e)
        {
            int statusChange = 1;
            int tableID = 8;


            orderLogic.OrderStatus(tableID, statusChange);
            order8();
            listView8.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady9_Click(object sender, EventArgs e)
        {
            int statusChange = 1;
            int tableID = 9;


            orderLogic.OrderStatus(tableID, statusChange);
            order9();
            listView9.BackColor = Color.MediumSeaGreen;
        }

        private void btn_markReady10_Click(object sender, EventArgs e)
        {
            int statusChange = 1;
            int tableID = 10;


            orderLogic.OrderStatus(tableID, statusChange);
            order10();
            listView10.BackColor = Color.MediumSeaGreen;
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            order1();
            order2();
            order3();
            order4();
            order5();
            order6();
            order7();
            order8();
            order9();
            order10();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            this.TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
