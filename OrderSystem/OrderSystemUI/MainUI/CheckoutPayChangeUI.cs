using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystemModel;
using OrderSystemLogic;

namespace OrderSystemUI.MainUI
{
    public partial class CheckoutPayChangeUI : Form
    {
        private Order order;
        private OrderHomeUI orderHomeUI;
        private OrderLogic orderLogic = new OrderLogic();
        private double change = 0;

        public CheckoutPayChangeUI(Order order, OrderHomeUI orderHomeUI)
        {
            InitializeComponent();
            this.order = order;
            this.orderHomeUI = orderHomeUI;
            //hide labels
            lblChange.Hide();
            lblChangeText.Hide();
            lblNotEnough.Hide();

            //set text
            lblTotalAmount.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Total"));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (change >= 0)
            {
                CheckoutConfirmationUI checkoutconfUI = new CheckoutConfirmationUI(order);
                this.Hide();
                checkoutconfUI.ShowDialog();

                orderLogic.Set_Order_To_Paid(order);
            }
            else
            {
                MessageBox.Show("Er is te weinig betaald!");
            }
        }

        private void btnCalculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                //hide lable shortage
                lblNotEnough.Hide();

                change = double.Parse(txtChangeAmount.Text.Replace('.', ','));
                //show labels change
                lblChange.Show();
                lblChangeText.Show();
                change = change - order.GetTotalAmount("Total");

                if (change < 0)
                {
                    lblNotEnough.Show();
                    lblNotEnough.Text = string.Format("De klant heeft € {0:0.00} te kort gegeven!", 0 - change);
                }
                
                lblChange.Text = string.Format("€ {0:0.00}", change);
                
            }
            catch
            {
                MessageBox.Show("Invoer moet een cijfer zijn en hoger dan het totaal bedrag zijn!");
            }
            finally
            {
                txtChangeAmount.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckoutPayUI checkoutUI = new CheckoutPayUI(order, orderHomeUI);
            checkoutUI.ShowDialog();
        }
    }
}
