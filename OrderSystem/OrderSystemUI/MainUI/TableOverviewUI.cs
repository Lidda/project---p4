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
            orderLogic.ChangeOrderStatus(tables[1].ID, OrderItem.Status.ready, OrderItem.Status.delivered);
            TimeMark2.Visible = false;
        }

        private void mark3_Click_1(object sender, EventArgs e) {
            mark3.Hide();
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

        private void OnTimedEventStatus(Object source, System.Timers.ElapsedEventArgs e) {
            //sets the interval to check the database every 15 seconds
            orderStatusTimer.Interval = 5000;

            //reload database data
            tables = tableLogic.GetAllTables();
            OrderLogic orderLogic = new OrderLogic();
            orders = orderLogic.Get_Orders_By_Date(DateTime.Today);

            //ESSENTIAL: excutes both methods on the main thread
            Invoke((MethodInvoker)delegate {
                SetTableColors();
                CheckOrdersStatusses(orders);
            });
        }

        //loops through orders: then loops through each orderItem IN orders and checks the status and call corresponding methods
        private void CheckOrdersStatusses(List<Order> orders) {
            ResetIcons();
            DateTime now = DateTime.Now;
            TimeSpan time;

            foreach (Order o in orders) {

                bool drinksReady = false;
                bool foodReady = false;

                // loops through all the orderItems & checks if food and/or drinks are READY --> saves it to the bools
                foreach (OrderItem i in o.orderItems) {
                    if (i.status == OrderItem.Status.ready) {
                        if (i.item.course == "Drank") {
                            drinksReady = true;
                        } else {
                            foodReady = true;
                        }
                    }
                }

                //updates UI depending on if food or drink are ready
                if (foodReady && drinksReady) {
                    ShowOrderReadyMarks(o.Table, "- Bar\n- Keuken");
                } else if (drinksReady) {
                    ShowOrderReadyMarks(o.Table, "- Bar");
                } else if (foodReady) {
                    ShowOrderReadyMarks(o.Table, "- Keuken");
                } else {
                    //if nothing is ready yet it loops through the orderItems to check if there are any OPEN orders --> updates UI accordingly
                    foreach (OrderItem i in o.orderItems) {
                        if (i.status == OrderItem.Status.ordered) {
                            time = now - i.TimeOfOrder;
                            ShowTimeMarks(o.Table, time);
                        }
                    }
                }
            }
        }

        //show the hourglass icons + 'timer' marks and updates the label with the timespan given to it
        private void ShowTimeMarks(Table table, TimeSpan date) {
            string dateMins = ((int)date.TotalMinutes).ToString(); ;

            switch (table.ID) {
                case 1:
                    hourglass1.Visible = true;
                    TimeMark1.Visible = true;
                    TimeMark1.Text = dateMins + " min";
                    break;
                case 2:
                    hourglass2.Visible = true;
                    TimeMark2.Visible = true;
                    TimeMark2.Text = dateMins + " min";
                    break;
                case 3:
                    hourglass3.Visible = true;
                    TimeMark3.Visible = true;
                    TimeMark3.Text = dateMins + " min";
                    break;
                case 4:
                    hourglass4.Visible = true;
                    TimeMark4.Visible = true;
                    TimeMark4.Text = dateMins + " min";
                    break;
                case 5:
                    hourglass5.Visible = true;
                    TimeMark5.Visible = true;
                    TimeMark5.Text = dateMins + " min";
                    break;
                case 6:
                    hourglass6.Visible = true;
                    TimeMark6.Visible = true;
                    TimeMark6.Text = dateMins + " min";
                    break;
                case 7:
                    hourglass7.Visible = true;
                    TimeMark7.Visible = true;
                    TimeMark7.Text = dateMins + " min";
                    break;
                case 8:
                    hourglass8.Visible = true;
                    TimeMark8.Visible = true;
                    TimeMark8.Text = dateMins + " min";
                    break;
                case 9:
                    hourglass9.Visible = true;
                    TimeMark9.Visible = true;
                    TimeMark9.Text = dateMins + " min";
                    break;
                case 10:
                    hourglass10.Visible = true;
                    TimeMark10.Visible = true;
                    TimeMark10.Text = dateMins + "min";
                    break;
            }
        }


        //makes 'ready' (!) mark visible next to the corresponding table
        private void ShowOrderReadyMarks(Table table, string area) {
            switch (table.ID) {
                case 1:
                    TimeMark1.Text = area;
                    TimeMark1.Visible = true;
                    mark1.Visible = true;
                    hourglass1.Visible = false;
                    break;
                case 2:
                    TimeMark2.Text = area;
                    TimeMark2.Visible = true;
                    mark2.Visible = true;
                    hourglass2.Visible = false;
                    break;
                case 3:
                    TimeMark3.Text = area;
                    TimeMark3.Visible = true;
                    mark3.Visible = true;
                    hourglass3.Visible = false;
                    break;
                case 4:
                    TimeMark4.Text = area;
                    TimeMark4.Visible = true;
                    mark4.Visible = true;
                    hourglass4.Visible = false;
                    break;
                case 5:
                    TimeMark5.Text = area;
                    TimeMark5.Visible = true;
                    mark5.Visible = true;
                    hourglass5.Visible = false;
                    break;
                case 6:
                    TimeMark6.Text = area;
                    TimeMark6.Visible = true;
                    mark6.Visible = true;
                    hourglass6.Visible = false;
                    break;
                case 7:
                    TimeMark7.Text = area;
                    TimeMark7.Visible = true;
                    mark7.Visible = true;
                    hourglass7.Visible = false;
                    break;
                case 8:
                    TimeMark8.Text = area;
                    TimeMark8.Visible = true;
                    mark8.Visible = true;
                    hourglass8.Visible = false;
                    break;
                case 9:
                    TimeMark9.Text = area;
                    TimeMark9.Visible = true;
                    mark9.Visible = true;
                    hourglass9.Visible = false;
                    break;
                case 10:
                    TimeMark10.Text = area;
                    TimeMark10.Visible = true;
                    mark10.Visible = true;
                    hourglass10.Visible = false;
                    break;
            }
        }

        public void ResetIcons() {
            hourglass1.Visible = false;
            hourglass2.Visible = false;
            hourglass3.Visible = false;
            hourglass4.Visible = false;
            hourglass5.Visible = false;
            hourglass6.Visible = false;
            hourglass7.Visible = false;
            hourglass8.Visible = false;
            hourglass9.Visible = false;
            hourglass10.Visible = false;

            TimeMark1.Visible = false;
            TimeMark2.Visible = false;
            TimeMark3.Visible = false;
            TimeMark4.Visible = false;
            TimeMark5.Visible = false;
            TimeMark6.Visible = false;
            TimeMark7.Visible = false;
            TimeMark8.Visible = false;
            TimeMark9.Visible = false;
            TimeMark10.Visible = false;

            mark1.Visible = false;
            mark2.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;
            mark5.Visible = false;
            mark6.Visible = false;
            mark7.Visible = false;
            mark8.Visible = false;
            mark9.Visible = false;
            mark10.Visible = false;
        }

    }
}
