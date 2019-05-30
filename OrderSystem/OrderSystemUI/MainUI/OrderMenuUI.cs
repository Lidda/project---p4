﻿using OrderSystemLogic;
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

        public OrderMenuUI(Employee employee, Table table, TableOverviewUI tableUI) {
            InitializeComponent();

            this.tableUI = tableUI;
            this.employee = employee;
            this.table = table;

            InitTableStatusColors();
            tableUI.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Hide();
            tableUI.Show();
            this.Close();
        }

        private void btnTaken_Click(object sender, EventArgs e) {
            UpdateColors(Availability.Unavailable);

            //writes the status off to database
            tableLogic.AlterTableStatus(Availability.Unavailable, table);
        }

        private void btnFree_Click(object sender, EventArgs e) {
            UpdateColors(Availability.Available);

            //writes the status off to database
            tableLogic.AlterTableStatus(Availability.Available, table);
        }

        private void btnReserved_Click_1(object sender, EventArgs e) {
            UpdateColors(Availability.Reserved);

            //writes the status off to database
            tableLogic.AlterTableStatus(Availability.Reserved, table);
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

    }
}
