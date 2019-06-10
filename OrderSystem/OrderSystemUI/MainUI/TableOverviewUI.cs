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
        private static System.Timers.Timer orderStatusTimer;
        private static System.Timers.Timer timeTimer;

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

            OrderStatusTimer();
            TimeOfOrderTimer();
        }

        public void SetTableColors() {
            for (int i = 0; i < tables.Count; i++) {
                if (tables[i].Status == Availability.Available) {
                    buttons[i].BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen);
                } else if (tables[i].Status == Availability.Reserved) {
                    buttons[i].BackColor = Color.FromKnownColor(KnownColor.SandyBrown);
                } else {
                    buttons[i].BackColor = Color.FromKnownColor(KnownColor.AppWorkspace);
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
            TimeMark1.Visible = false;
        }

        private void mark2_Click_1(object sender, EventArgs e) {
            mark2.Hide();
            orderLogic.ChangeOrderStatus(tables[0].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
            TimeMark2.Visible = false;
        }

        private void mark3_Click_1(object sender, EventArgs e) {
            orderMark3.Hide();
            orderLogic.ChangeOrderStatus(tables[2].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
            TimeMark3.Visible = false;
        }

        private void mark4_Click_1(object sender, EventArgs e) {
            mark4.Hide();
            orderLogic.ChangeOrderStatus(tables[3].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
            TimeMark4.Visible = false;
        }

        private void mark5_Click_1(object sender, EventArgs e) {
            mark5.Hide();
            orderLogic.ChangeOrderStatus(tables[4].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
            TimeMark5.Visible = false;
        }

        private void mark6_Click_1(object sender, EventArgs e) {
            mark6.Hide();
            orderLogic.ChangeOrderStatus(tables[5].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
            TimeMark6.Visible = false;
        }

        private void mark7_Click_1(object sender, EventArgs e) {
            mark7.Hide();
            orderLogic.ChangeOrderStatus(tables[6].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
            TimeMark7.Visible = false;
        }

        private void mark8_Click_1(object sender, EventArgs e) {
            mark8.Hide();
            orderLogic.ChangeOrderStatus(tables[7].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
            TimeMark8.Visible = false;
        }

        private void mark9_Click_1(object sender, EventArgs e) {
            mark9.Hide();
            orderLogic.ChangeOrderStatus(tables[8].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
            TimeMark9.Visible = false;
        }

        private void mark10_Click_1(object sender, EventArgs e) {
            mark10.Hide();
            orderLogic.ChangeOrderStatus(tables[9].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
            TimeMark10.Visible = false;
        }

        private void InitOrderUI(Table table) {
            this.Hide();
            table.Employee = employee;
            OrderHomeUI orderUI = new OrderHomeUI(employee, table, this);
            orderUI.ShowDialog();
        }

        private void OrderStatusTimer() {
            orderStatusTimer = new System.Timers.Timer();
            orderStatusTimer.Interval = 1;
            orderStatusTimer.Elapsed += OnTimedEventStatus;
            orderStatusTimer.AutoReset = true;
            orderStatusTimer.Enabled = true;
        }

        private void TimeOfOrderTimer() {
            timeTimer = new System.Timers.Timer();
            timeTimer.Interval = 1;
            timeTimer.Elapsed += OnTimedEventTime;
            timeTimer.AutoReset = true;
            timeTimer.Enabled = true;
        }

        private void OnTimedEventStatus(Object source, System.Timers.ElapsedEventArgs e) {
            //sets the interval to check the database every 15 seconds
            orderStatusTimer.Interval = 15000;

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

        private void OnTimedEventTime(Object source, System.Timers.ElapsedEventArgs e) {
            timeTimer.Interval = 5000;

            //ESSENTIAL: excutes both methods on the main thread
            Invoke((MethodInvoker)delegate {
                DateTime now = DateTime.Now;
                TimeSpan time;
                foreach (Order o in orders) {
                    foreach (OrderItem i in o.orderItems) {
                        if (i.status == OrderItem.Status.ordered || i.status == OrderItem.Status.ready) {
                            time = now - i.TimeOfOrder;
                            ShowTimeMarks(o.Table, time);
                            break;
                        }
                    }
                }
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

        //show the 'timer' marks and updates the label it with the timespan given to it
        private void ShowTimeMarks(Table table, TimeSpan date) {
            switch (table.ID) {
                case 1:
                    TimeMark1.Visible = true;
                    TimeMark1.Text = date.ToString((@"mm")) + " min" ;
                    break;
                case 2:
                    TimeMark2.Visible = true;
                    TimeMark2.Text = date.ToString((@"mm")) + " min";
                    break;
                case 3:
                    TimeMark3.Visible = true;
                    TimeMark3.Text = date.ToString((@"mm")) + " min";
                    break;
                case 4:
                    TimeMark4.Visible = true;
                    TimeMark4.Text = date.ToString((@"mm")) + " min";
                    break;
                case 5:
                    TimeMark5.Visible = true;
                    TimeMark5.Text = date.ToString((@"mm")) + " min";
                    break;
                case 6:
                    TimeMark6.Visible = true;
                    TimeMark6.Text = date.ToString((@"mm")) + " min";
                    break;
                case 7:
                    TimeMark7.Visible = true;
                    TimeMark7.Text = date.ToString((@"mm")) + " min";
                    break;
                case 8:
                    TimeMark8.Visible = true;
                    TimeMark8.Text = date.ToString((@"mm")) + " min";
                    break;
                case 9:
                    TimeMark9.Visible = true;
                    TimeMark9.Text = date.ToString((@"mm")) + " min";
                    break;
                case 10:
                    TimeMark10.Visible = true;
                    TimeMark10.Text = date.ToString((@"mm")) + "min";
                    break;
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
                    hourglass2.Visible = false;
                    break;
                case 3:
                    orderMark3.Visible = true;
                    hourglass3.Visible = false;
                    break;
                case 4:
                    mark4.Visible = true;
                    hourglass4.Visible = false;
                    break;
                case 5:
                    mark5.Visible = true;
                    hourglass5.Visible = false;
                    break;
                case 6:
                    mark6.Visible = true;
                    hourglass6.Visible = false;
                    break;
                case 7:
                    mark7.Visible = true;
                    hourglass7.Visible = false;
                    break;
                case 8:
                    mark8.Visible = true;
                    hourglass8.Visible = false;
                    break;
                case 9:
                    mark9.Visible = true;
                    hourglass9.Visible = false;
                    break;
                case 10:
                    mark10.Visible = true;
                    hourglass10.Visible = false;
                    break;
            }
        }

    }
}
