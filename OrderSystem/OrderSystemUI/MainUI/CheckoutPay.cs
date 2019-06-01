﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystemLogic;
using OrderSystemModel;

namespace OrderSystemUI.MainUI
{
    public partial class CheckoutPay : Form
    {
        private Order order;
        private CheckoutLogic logic = new CheckoutLogic();
        public CheckoutPay(Order order)
        {
            InitializeComponent();

            this.order = order;
            //show payment methods
            pnlChoosePayOption.Show();
            pnlChoosePayOption.BringToFront();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            Pay();
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            Pay();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pay();
        }
        private void Pay()
        {
            logic.SetToPaid(order);
            CheckoutConfirmation checkoutconfUI = new CheckoutConfirmation(order);
            this.Hide();
            checkoutconfUI.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutOverviewOrder coUI = new CheckoutOverviewOrder(order);
            coUI.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void pnlConfirmation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlChoosePayOption_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
