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

namespace OrderSystemUI.MainUI {
    public partial class OrderMenuUI : Form {
        Employee employee;

        public OrderMenuUI(Employee employee) {
            this.employee = employee;
            InitializeComponent();       
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Hide();
            TableOverviewUI tableUI = new TableOverviewUI(employee);
        }

        private void btnTaken_Click(object sender, EventArgs e) {
            btnTaken.BackColor = Color.FromKnownColor(KnownColor.Crimson);
            btnFree.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            btnReserved.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
        }

        private void btnFree_Click(object sender, EventArgs e) {
            btnFree.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen);
            btnTaken.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            btnReserved.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
        }

        private void btnReserved_Click_1(object sender, EventArgs e) {
            btnReserved.BackColor = Color.FromKnownColor(KnownColor.SandyBrown);
            btnTaken.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
            btnFree.BackColor = Color.FromKnownColor(KnownColor.ControlDark);
        }
    }
}
