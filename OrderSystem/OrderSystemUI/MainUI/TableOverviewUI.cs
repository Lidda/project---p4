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
        TableLogic logic;
        private static System.Timers.Timer timer;

        public TableOverviewUI(Employee employee) {
            this.employee = employee;
            logic = new TableLogic();
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
            tables = logic.GetAllTables();
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
            table.EmployeeID = employee.ID;
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
            tables = logic.UpdateTables(tables);
            SetTableColors();
        }

    }
}
