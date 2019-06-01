using System;
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
        public CheckoutPay()
        {
            InitializeComponent();
            //show payment methods
            pnlChoosePayOption.Show();
            pnlChoosePayOption.BringToFront();
            //hide conf dialog
            pnlConfirmation.Hide();
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
            //show conf dialog
            pnlConfirmation.Show();
            pnlConfirmation.BringToFront();
            //hide methods
            pnlChoosePayOption.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutOverview coUI = new CheckoutOverview(order);
            coUI.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go back to overview
        }
    }
}
