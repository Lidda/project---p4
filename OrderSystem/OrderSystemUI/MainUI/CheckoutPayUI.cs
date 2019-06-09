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
    public partial class CheckoutPayUI : Form
    {
        private Order order;
        private OrderLogic orderLogic = new OrderLogic();
        private OrderHomeUI orderHomeUI;

        public CheckoutPayUI(Order order, OrderHomeUI orderHomeUI)
        {
            InitializeComponent();
            this.orderHomeUI = orderHomeUI;
            this.order = order;
            //show payment methods
            pnlChoosePayOption.Show();
            pnlChoosePayOption.BringToFront();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            CheckoutPayChangeUI checkoutPayChangeUI = new CheckoutPayChangeUI(order, orderHomeUI);
            this.Hide();
            checkoutPayChangeUI.ShowDialog();
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
            CheckoutConfirmationUI checkoutconfUI = new CheckoutConfirmationUI(order);
            this.Hide();
            checkoutconfUI.ShowDialog();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutOverviewOrderUI coUI = new CheckoutOverviewOrderUI(order, orderHomeUI);
            coUI.ShowDialog();
        }
    }
}
