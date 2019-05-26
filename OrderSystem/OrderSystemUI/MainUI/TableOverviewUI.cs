﻿using OrderSystemLogic1;
using OrderSystemModel;
using OrderSystemModel1;
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

namespace OrderSystemUI {
    public partial class TableOverviewUI : Form {
        Employee employee;
        List<Table> tables = new List<Table>();
        TableLogic logic;

        public TableOverviewUI(Employee employee) {
            this.employee = employee;
            logic = new TableLogic();
            initTables();
            InitializeComponent();
        }

        //makes list of table objects
        private void initTables() {
            for (int i = 0; i < 10; i++) {
                Table table = new Table(i + 1);
                tables.Add(table);
            }
        }
  
        private void btnLogout_Click(object sender, EventArgs e) {
            this.Hide();
            LoginUI loginUI = new LoginUI();
            loginUI.ShowDialog();
            this.Close();
        }

        private void btnTable1_Click(object sender, EventArgs e) {
            makeOrderUI(tables[0]);
        }

        private void btnTable2_Click(object sender, EventArgs e) {
            makeOrderUI(tables[1]);
        }

        private void btnTable3_Click(object sender, EventArgs e) {
            makeOrderUI(tables[2]);
        }

        private void btnTable4_Click(object sender, EventArgs e) {
            makeOrderUI(tables[3]);
        }

        private void btnTable5_Click_1(object sender, EventArgs e) {
            makeOrderUI(tables[4]);
        }

        private void btnTable6_Click_1(object sender, EventArgs e) {
            makeOrderUI(tables[5]);
        }

        private void btnTable7_Click_1(object sender, EventArgs e) {
            makeOrderUI(tables[6]);
        }

        private void btnTable8_Click_1(object sender, EventArgs e) {
            makeOrderUI(tables[7]);
        }

        private void btnTable9_Click_1(object sender, EventArgs e) {
            makeOrderUI(tables[8]);
        }

        private void btnTable10_Click_1(object sender, EventArgs e) {
            makeOrderUI(tables[9]);
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

        private void makeOrderUI(Table table) {
            this.Hide();
            OrderUI orderUI = new OrderUI();
            orderUI.ShowDialog();
            this.Close();
        }

    }
}
