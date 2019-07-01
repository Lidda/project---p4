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
    public partial class OrderHomeUI : Form {
        Table table;
        TableOverviewUI tableUI;

        TableLogic tableLogic = new TableLogic();
        OrderLogic orderLogic = new OrderLogic();
        OrderItemLogic orderItemLogic = new OrderItemLogic();

        List<Button> buttons;
        Order order = new Order();

        public OrderHomeUI(Employee employee, Table table, TableOverviewUI tableUI) {
            InitializeComponent();

            this.buttons = new List<Button>();
            buttons.Add(btnBack);
            buttons.Add(btnFree);
            buttons.Add(btnReserved);
            buttons.Add(btnTaken);
            buttons.Add(Btn_BeverageMenu);
            buttons.Add(btn_Checkout);
            buttons.Add(btn_DinnerMenu);
            buttons.Add(btn_LunchMenu);
            buttons.Add(btn_OrderOverview);
            buttons.Add(btn_RemoveOrder);

            this.order.Employee = employee;
            this.order.Table = table;
            this.tableUI = tableUI;
            this.table = table;
            this.Text = "Tafel " + table.ID + "- Order Menu";
            tableNumber.Text = "Tafel " + table.ID + ":";

            try
            {
                try
                {
                    this.order = orderLogic.GetTableOrder(table);
                }
                catch
                {
                    orderLogic.AddNewOrder(order);
                    this.order = orderLogic.GetLatestOrder();
                }
            }
            catch
            {
                MessageBox.Show("Probleem met het laden van de database. Probeer opnieuw.");
            }

            try
            {
                InitTableStatusColors();
                tableLogic.AssignEmployeeToTable(employee, table);
                tableUI.Hide();
            }
            catch
            {
                MessageBox.Show("Probleem met het laden van de database. Probeer opnieuw.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e) {

            try
            {
                this.Hide();
                tableUI.tables = tableLogic.GetAllTables();
                tableUI.SetTableColors();
                tableUI.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Probleem met het laden van de database. Probeer opnieuw.");
            }
        }

        private void btnTaken_Click(object sender, EventArgs e) {
            UpdateColors(Availability.Unavailable);

            //writes the status off to database
            tableLogic.UpdateTableStatus(Availability.Unavailable, table);
            
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
                btnFree.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen);
                btnTaken.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
                btnReserved.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            } else if (status == Availability.Reserved) {
                btnReserved.BackColor = Color.FromKnownColor(KnownColor.SandyBrown);
                btnTaken.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
                btnFree.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            } else {
                btnTaken.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
                btnFree.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
                btnReserved.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            }
        }

        private void btn_LunchMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderMenuUI orderMenuUI = new OrderMenuUI(order, this, "");
            orderMenuUI.ShowDialog();
        }

        private void btn_OrderOverview_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderOverviewUI orderOverview = new OrderOverviewUI(order, this);
            orderOverview.ShowDialog();
        }

        private void Btn_BeverageMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderMenuUI orderMenuUI = new OrderMenuUI(order, this, "Drinks");
            orderMenuUI.ShowDialog();
        }

        private void btn_DinnerMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderMenuUI orderMenuUI = new OrderMenuUI(order, this, "Dinner");
            orderMenuUI.ShowDialog();
        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                order = orderLogic.GetTableOrder(table);
                CheckoutOverviewOrderUI checkoutOverview = new CheckoutOverviewOrderUI(this.order, this);
                checkoutOverview.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Probleem met het laden van de database. Probeer opnieuw.");
            }
        }

        private void btn_RemoveOrder_Click(object sender, EventArgs e)
        {
            pnl_ConfirmRemoval.Show();

            foreach  (Button button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void btn_ConfirmRemoval_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (OrderItem orderItem in order.orderItems)
                {
                    orderItemLogic.RemoveOrderItems(orderItem);
                }

                orderLogic.RemoveOrder(this.order);

                foreach (Button button in buttons)
                {
                    button.Enabled = true;
                }

                this.Hide();
                tableUI.tables = tableLogic.GetAllTables();
                tableUI.SetTableColors();
                tableUI.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Probleem met het laden van de database. Probeer opnieuw.");
            }
        }

        private void btn_CancelRemoval_Click(object sender, EventArgs e)
        {
            pnl_ConfirmRemoval.Hide();

            foreach (Button button in buttons)
            {
                button.Enabled = true;
            }
        }
    }
}
