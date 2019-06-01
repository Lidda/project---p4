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
        List<Button> buttons = new List<Button>();
        Employee employee;
        List<Table> tables;
        TableLogic tableLogic;
        BarKitchenLogic orderItemLogic;
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
            SetTableColors();
            TablesTimer();
        }

        private void SetTableColors() {
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
            //FIX ME: Call method that changes the orderItem status to 'delivered' 
        }

        private void mark2_Click_1(object sender, EventArgs e) {
            mark2.Hide();
        }

        private void mark3_Click_1(object sender, EventArgs e) {
            mark3.Hide();
        }

        private void mark4_Click_1(object sender, EventArgs e) {
            mark4.Hide();
        }

        private void mark5_Click_1(object sender, EventArgs e) {
            mark5.Hide();
        }

        private void mark6_Click_1(object sender, EventArgs e) {
            mark6.Hide();
        }

        private void mark7_Click_1(object sender, EventArgs e) {
            mark7.Hide();
        }

        private void mark8_Click_1(object sender, EventArgs e) {
            mark8.Hide();
        }

        private void mark9_Click_1(object sender, EventArgs e) {
            mark9.Hide();
        }

        private void mark10_Click_1(object sender, EventArgs e) {
            mark10.Hide();
        }

        private void InitOrderUI(Table table) {
            this.Hide();
            table.Employee = employee;
            OrderMenuUI orderUI = new OrderMenuUI(employee, table, this);
            orderUI.ShowDialog();
        }

        private void TablesTimer() {
            timer = new System.Timers.Timer();
            timer.Interval = 5000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e) {
            //update table statusses etc.
            tables = tableLogic.GetAllTables();
            //FIX ME: orderItems = orderItemLogic.getOrders();
            SetTableColors();
        }

        /*FIX ME not called yet
        private void showOrderMarks(List<OrderItem> orderItems) {
            foreach (OrderItem o in orderItems) {
                switch (o.order.Table.ID) {
                    case 1:
                        mark1.Visible = true;
                        break;
                    case 2:
                        mark2.Visible = true;
                        break;
                    case 3:
                        mark3.Visible = true;
                        break;
                    case 4:
                        mark4.Visible = true;
                        break;
                    case 5:
                        mark5.Visible = true;
                        break;
                    case 6:
                        mark6.Visible = true;
                        break;
                    case 7:
                        mark7.Visible = true;
                        break;
                    case 8:
                        mark8.Visible = true;
                        break;
                    case 9:
                        mark9.Visible = true;
                        break;
                    case 10:
                        mark10.Visible = true;
                        break;
                }
            }

        }
        */

    }
}
