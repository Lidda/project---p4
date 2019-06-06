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
    public partial class CheckoutTip : Form
    {
        private Order order;
        public CheckoutTip(Order order)
        {
            InitializeComponent();

            this.order = order;
            //set text
            lblTipHeader.Text = string.Format("Fooi tafel {0}", order.Table.ID);
            lblTipTip.Text = string.Format("€ {0:0.00}", order.tip);
            lblTipTotal.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Total") - order.tip);
            lblTipGrandTotal.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Total"));
        }

        private void btnAddTipToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                order.tip = double.Parse(txtTip.Text.Replace('.', ','));
                //update labels
                lblTipTip.Text = string.Format("€ {0:0.00}", order.tip);
                lblTipTotal.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Total") - order.tip);
                lblTipGrandTotal.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Total"));
            }
            catch
            {
                MessageBox.Show("Vul een geldig cijfer in!");
            }
            finally
            {
                txtTip.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //back button + cancels tip
            order.tip = 0;

            GoBackToOverview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //just a back button
            GoBackToOverview();
        }

        private void btnConfirmTip_Click(object sender, EventArgs e)
        {
            //go back to order overview
            GoBackToOverview();
        }
        private void GoBackToOverview()
        {
            //go back to order overview
            this.Hide();
            CheckoutOverviewOrder coUI = new CheckoutOverviewOrder(order);
            coUI.ShowDialog();
        }
    }
}
