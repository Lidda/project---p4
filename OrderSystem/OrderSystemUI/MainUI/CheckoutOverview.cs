using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using OrderSystemLogic;
using OrderSystemModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystemUI
{
    public partial class CheckoutOverview : Form
    {
        private CheckoutLogic logic = new CheckoutLogic();
        private Order order;
        private double tip = 0; //tip amount - default no tip

        public CheckoutOverview(Table table, Employee employee)
        {
            InitializeComponent();
            order = logic.GetOrder(table, employee);

            ShowPanel("Overview");
        }
        private void RefereshOrder()
        {
            //refresh order overview after comment/tip has been added
            order = logic.GetOrder(order.Table, order.Employee);
        }
        private void ShowPanel(string panelName)
        {
            if (panelName == "Overview")
            {
                //refresh order
                RefereshOrder();

                //show panels
                pnlOverview.Show();

                //hide labels
                lblTip.Hide();
                lblTipAmount.Hide();

                //set title of header
                lblCheckoutOverviewHeader.Text = string.Format("Order overview table {0}", order.Table.ID);

                //set labels
                lblOrderPriceWithoutTax.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("withoutTax"));
                lblTaxAmount.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Tax"));
                lblTotalAmount.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Total"));

                //check if there's given a tip
                //if yes, show labels
                if (tip > 0)
                {
                    lblTip.Show();
                    lblTipAmount.Show();
                    lblTipAmount.Text = string.Format("€ {0:0.00}", tip);
                }
            }
        }
        
        private void lblTotalAmount_Click(object sender, EventArgs e)
        {

        }
        
        private void btnBack_Click(object sender, EventArgs e)
        {
            //go to 'previous' page
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //go to 'pay' screen
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            //go to 'add comment' screen
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            //go to 'add tip' screen
        }
    }
}
