using OrderSystemLogic;
using OrderSystemModel;
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

namespace OrderSystemUI.MainUI {
    public partial class OrderMenuUI : Form {
        Employee employee;
        Table table;
        TableOverviewUI tableUI;
        TableLogic tableLogic = new TableLogic();
        TakeOrderLogic takeOrderLogic = new TakeOrderLogic();
        Order order = new Order();

        public OrderMenuUI(Employee employee, Table table, TableOverviewUI tableUI) {
            InitializeComponent();

            this.tableUI = tableUI;
            this.employee = employee;
            this.table = table;
        
            InitTableStatusColors();
            tableLogic.AssignEmployeeToTable(employee, table);
            tableUI.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Hide();
            tableUI.tables = tableLogic.GetAllTables();
            tableUI.SetTableColors();
            tableUI.Show();
            this.Close();
        }

        private void btnTaken_Click(object sender, EventArgs e) {
            UpdateColors(Availability.Unavailable);

            //writes the status off to database
            tableLogic.UpdateTableStatus(Availability.Unavailable, table);

            //Adds new order to database
            takeOrderLogic.AddNewOrder(employee.ID, table.ID);
        }

        private void btnFree_Click(object sender, EventArgs e) {
            UpdateColors(Availability.Available);

            //writes the status off to database
            tableLogic.UpdateTableStatus(Availability.Available, table);
        }

        private void btnReserved_Click_1(object sender, EventArgs e) {
            UpdateColors(Availability.Reserved);

            //writes the status off to database
            tableLogic.UpdateTableStatus(Availability.Reserved, table);
        }

        private void InitTableStatusColors() {
            if (table.Status == Availability.Available) {
                UpdateColors(Availability.Available);
            } else if (table.Status == Availability.Reserved) {
                UpdateColors(Availability.Reserved);
            } else {
                UpdateColors(Availability.Unavailable);
            }
        }

        private void UpdateColors(Availability status) {
            if (status == Availability.Available) {
                btnFree.BackColor = Color.FromKnownColor(KnownColor.MenuHighlight);
                btnTaken.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
                btnReserved.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            } else if (status == Availability.Reserved) {
                btnReserved.BackColor = Color.FromKnownColor(KnownColor.SandyBrown);
                btnTaken.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
                btnFree.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            } else {
                btnTaken.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen);
                btnFree.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
                btnReserved.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            }
        }

        private void MakeNewOrder(int orderID)
        {
            this.order.orderID = orderID++;
            this.order.Employee = this.employee;
            this.order.Table = this.table;
            this.order.orderDate = DateTime.Now;
        }

        private void btn_LunchMenu_Click(object sender, EventArgs e)
        {
            int orderID = takeOrderLogic.GetLatestOrderID();

            this.Hide();
            OrderLunchUI lunchUI = new OrderLunchUI(employee, table, orderID, this);
            lunchUI.ShowDialog();
        }

        private void btn_OrderOverview_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutOverviewOrder orderOverview = new CheckoutOverviewOrder(table, employee);
            orderOverview.ShowDialog();
        }
    }
}
