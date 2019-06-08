using OrderSystemLogic;
using OrderSystemModel;
using OrderSystemUI.MainUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OrderSystemModel.Table;
using System.Timers;

namespace OrderSystemUI {
    public partial class TableOverviewUI : Form {
        public List<Table> tables;
        List<Button> buttons = new List<Button>();
        List<Order> orders = new List<Order>();
        Employee employee;
        TableLogic tableLogic;
        OrderLogic orderLogic = new OrderLogic();
        private static System.Timers.Timer timer;

        public TableOverviewUI(Employee employee) {
            this.employee = employee;
            tableLogic = new TableLogic();
            InitializeComponent();

            buttons.Add(btnTable1);
            buttons.Add(btnTable2);
            buttons.Add(btnTable3);
            buttons.Add(btnTable4);
            buttons.Add(btnTable5);
            buttons.Add(btnTable6);
            buttons.Add(btnTable7);
            buttons.Add(btnTable8);
            buttons.Add(btnTable9);
            buttons.Add(btnTable10);

            //initialize tables by getting them from the database
            tables = tableLogic.GetAllTables();
            //SetTableColors();
            SetTableColors();

            TablesTimer();
        }

        public void SetTableColors() {
            for (int i = 0; i < tables.Count; i++) {
                if (tables[i].Status == Availability.Available) {
                    buttons[i].BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
                } else if (tables[i].Status == Availability.Reserved) {
                    buttons[i].BackColor = Color.FromKnownColor(KnownColor.SandyBrown);
                } else {
                    buttons[i].BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen);
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            this.Hide();
            LoginUI loginUI = new LoginUI();
            loginUI.ShowDialog();
            this.Close();
        }

        private void btnTable1_Click(object sender, EventArgs e) {
            InitOrderUI(tables[0]);
        }

        private void btnTable2_Click(object sender, EventArgs e) {
            InitOrderUI(tables[1]);
        }

        private void btnTable3_Click(object sender, EventArgs e) {
            InitOrderUI(tables[2]);
        }

        private void btnTable4_Click(object sender, EventArgs e) {
            InitOrderUI(tables[3]);
        }

        private void btnTable5_Click_1(object sender, EventArgs e) {
            InitOrderUI(tables[4]);
        }

        private void btnTable6_Click_1(object sender, EventArgs e) {
            InitOrderUI(tables[5]);
        }

        private void btnTable7_Click_1(object sender, EventArgs e) {
            InitOrderUI(tables[6]);
        }

        private void btnTable8_Click_1(object sender, EventArgs e) {
            InitOrderUI(tables[7]);
        }

        private void btnTable9_Click_1(object sender, EventArgs e) {
            InitOrderUI(tables[8]);
        }

        private void btnTable10_Click_1(object sender, EventArgs e) {
            InitOrderUI(tables[9]);
        }

        private void mark1_Click_1(object sender, EventArgs e) {
            mark1.Hide();
            orderLogic.ChangeOrderStatus(tables[0].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
        }

        private void mark2_Click_1(object sender, EventArgs e) {
            mark2.Hide();
            orderLogic.ChangeOrderStatus(tables[0].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
        }

        private void mark3_Click_1(object sender, EventArgs e) {
            orderMark3.Hide();
            orderLogic.ChangeOrderStatus(tables[2].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
        }

        private void mark4_Click_1(object sender, EventArgs e) {
            mark4.Hide();
            orderLogic.ChangeOrderStatus(tables[3].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
        }

        private void mark5_Click_1(object sender, EventArgs e) {
            mark5.Hide();
            orderLogic.ChangeOrderStatus(tables[4].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
        }

        private void mark6_Click_1(object sender, EventArgs e) {
            mark6.Hide();
            orderLogic.ChangeOrderStatus(tables[5].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
        }

        private void mark7_Click_1(object sender, EventArgs e) {
            mark7.Hide();
            orderLogic.ChangeOrderStatus(tables[6].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
        }

        private void mark8_Click_1(object sender, EventArgs e) {
            mark8.Hide();
            orderLogic.ChangeOrderStatus(tables[7].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
        }

        private void mark9_Click_1(object sender, EventArgs e) {
            mark9.Hide();
            orderLogic.ChangeOrderStatus(tables[8].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
        }

        private void mark10_Click_1(object sender, EventArgs e) {
            mark10.Hide();
            orderLogic.ChangeOrderStatus(tables[9].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
        }

        private void InitOrderUI(Table table) {
            this.Hide();
            table.Employee = employee;
            OrderHomeUI orderUI = new OrderHomeUI(employee, table, this);
            orderUI.ShowDialog();
        }

        private void TablesTimer() {
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e) {
            //sets the interval to check the database every 15 seconds
            timer.Interval = 15000;

            //reload database data
            tables = tableLogic.GetAllTables();
            OrderLogic orderLogic = new OrderLogic();
            orders = orderLogic.Get_All_Orders();

            //ESSENTIAL: excutes both methods on the main thread
            // methods update table colors + order status marks
            Invoke((MethodInvoker)delegate {
                SetTableColors();
                CheckOrdersStatusses(orders);
            });
        }


        //loops through orders: then loops through each orderItem IN orders and checks the status
        private void CheckOrdersStatusses(List<Order> orders) {
            foreach (Order o in orders) {
                foreach (OrderItem i in o.orderItems) {
                    if (i.status == OrderItem.Status.ready) {
                        ShowOrderReadyMarks(o.Table);
                        break;
                    } else if (i.status == OrderItem.Status.ordered) {
                        ShowOrderOngoingMarks(o.Table);                      
                    }
                }
            }
        }

        //makes the 'ongoing' (hourglass) mark visible next to the corresponding table
        private void ShowOrderOngoingMarks(Table table) {
            switch (table.ID) {
                case 1:
                    hourglass1.Visible = true;
                    break;
                case 2:
                    hourglass2.Visible = true;
                    break;
                case 3:
                    hourglass3.Visible = true;
                    break;
                case 4:
                    hourglass4.Visible = true;
                    break;
                case 5:
                    hourglass5.Visible = true;
                    break;
                case 6:
                    hourglass6.Visible = true;
                    break;
                case 7:
                    hourglass7.Visible = true;
                    break;
                case 8:
                    hourglass8.Visible = true;
                    break;
                case 9:
                    hourglass9.Visible = true;
                    break;
                case 10:
                    hourglass10.Visible = true;
                    break;
            }
        }

        //makes 'ready' (!) mark visible next to the corresponding table
        private void ShowOrderReadyMarks(Table table) {
            switch (table.ID) {
                case 1:
                    mark1.Visible = true;
                    hourglass1.Visible = false;
                    break;
                case 2:
                    mark2.Visible = true;
                    hourglass1.Visible = false;
                    break;
                case 3:
                    orderMark3.Visible = true;
                    hourglass1.Visible = false;
                    break;
                case 4:
                    mark4.Visible = true;
                    hourglass1.Visible = false;
                    break;
                case 5:
                    mark5.Visible = true;
                    hourglass1.Visible = false;
                    break;
                case 6:
                    mark6.Visible = true;
                    hourglass1.Visible = false;
                    break;
                case 7:
                    mark7.Visible = true;
                    hourglass1.Visible = false;
                    break;
                case 8:
                    mark8.Visible = true;
                    hourglass1.Visible = false;
                    break;
                case 9:
                    mark9.Visible = true;
                    hourglass1.Visible = false;
                    break;
                case 10:
                    mark10.Visible = true;
                    hourglass1.Visible = false;
                    break;
            }
        }

    }
}
