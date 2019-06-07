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
        private OrderLogic orderLogic = new OrderLogic();
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
            orderLogic.Set_Order_To_Paid(order);
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

        
    }
}
