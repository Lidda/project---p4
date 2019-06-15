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
            lblEuroSign.Hide();

            //set text
            lblTotalAmount.Text = string.Format("{0:0.00}", order.GetTotalAmount("Total"));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //check if change is positive
            if (change >= 0)
            {
                //set order to paid in the database
                orderLogic.Set_Order_To_Paid(order);

                CheckoutConfirmationUI checkoutconfUI = new CheckoutConfirmationUI(order);
                this.Hide();
                checkoutconfUI.ShowDialog();
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

                change = double.Parse(txtChangeAmount.Text);
                //show labels change
                lblChange.Show();
                lblChangeText.Show();
                change = change - order.GetTotalAmount("Total");
                //check if textbox is empty or textboc contains a dot
                if (string.IsNullOrWhiteSpace(txtChangeAmount.Text) || txtChangeAmount.Text.Contains('.'))
                    throw new Exception();

                //check if customer paid enough
                if (change < 0)
                {
                    lblNotEnough.Show();
                    lblNotEnough.Text = string.Format("De klant heeft € {0:0.00} te kort gegeven!", 0 - change);
                }
                
                //show amount change
                lblChange.Text = string.Format("{0:0.00}", change);
                lblEuroSign.Show();
                
            }
            catch
            {
                MessageBox.Show("Invoer moet een geldig cijfer zijn en hoger dan het totaal bedrag zijn!");
            }
            finally
            {
                txtChangeAmount.Text = "";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back to PayUI
            this.Hide();
            CheckoutPayUI checkoutUI = new CheckoutPayUI(order, orderHomeUI);
            checkoutUI.ShowDialog();
        }
    }
}
