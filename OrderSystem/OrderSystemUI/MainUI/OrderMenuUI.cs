using OrderSystemLogic1;
using OrderSystemModel;
using OrderSystemModel1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OrderSystemModel1.Table;

namespace OrderSystemUI.MainUI {
    public partial class OrderMenuUI : Form {
        Employee employee;
        Table table;
        TableOverviewUI tableUI;
        TableLogic tableLogic = new TableLogic();

        public OrderMenuUI(Employee employee, Table table, TableOverviewUI tableUI) {
            InitializeComponent();

            this.tableUI = tableUI;           
            this.employee = employee;
            this.table = table;
            tableUI.Hide();                 
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Hide();
            tableUI.Show();
            //FIX ME: call update method for the tables first
            this.Close();
        }

        private void btnTaken_Click(object sender, EventArgs e) {
            btnTaken.BackColor = Color.FromKnownColor(KnownColor.Crimson);
            btnFree.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            btnReserved.BackColor = Color.FromKnownColor(KnownColor.ControlDark);

            tableLogic.UpdateTableStatus(Availability.Unavailable, table);
        }

        private void btnFree_Click(object sender, EventArgs e) {
            btnFree.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen);
            btnTaken.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            btnReserved.BackColor = Color.FromKnownColor(KnownColor.ControlDark);

            tableLogic.UpdateTableStatus(Availability.Available, table);
        }

        private void btnReserved_Click_1(object sender, EventArgs e) {
            btnReserved.BackColor = Color.FromKnownColor(KnownColor.SandyBrown);
            btnTaken.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            btnFree.BackColor = Color.FromKnownColor(KnownColor.ControlDark);

            tableLogic.UpdateTableStatus(Availability.Reserved, table);
        }
    }
}
