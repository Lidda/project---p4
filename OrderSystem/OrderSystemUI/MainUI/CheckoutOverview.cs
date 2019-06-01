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
using OrderSystemUI.MainUI;

namespace OrderSystemUI
{
    public partial class CheckoutOverview : Form
    {
        private CheckoutLogic logic = new CheckoutLogic();
        private Order order;

        public CheckoutOverview(Table table, Employee employee)
        {
            InitializeComponent();
            try
            {
                order = logic.GetOrder(table, employee);
                ShowPanel("Overview");
            }
            catch
            {
                ShowPanel("error");
            }
            
        }
        public CheckoutOverview(Order order)
        {
            InitializeComponent();
            this.order = order;
            ShowPanel("Overview");
        }
        private void ShowPanel(string panelName)
        {
            if (panelName == "Tip")
            {
                this.Hide();
                CheckoutTip checkoutTipUI = new CheckoutTip(order);
                checkoutTipUI.ShowDialog();
            }
            else if (panelName == "error")
            {
                pnlNoOrdersFound.Show();
                pnlNoOrdersFound.BringToFront();
            }
            else if (panelName == "Comment")
            {
                this.Hide();
                CheckoutComments checkoutCommentsUI = new CheckoutComments(order);
                checkoutCommentsUI.ShowDialog();
            }
            else if (panelName == "Overview")
            {

                //show panels
                pnlOverview.Show();
                pnlOverview.BringToFront();
                //hide
                lblTip.Hide();
                lblTipAmount.Hide();
                pnlNoOrdersFound.Hide();

                //set title of header
                lblCheckoutOverviewHeader.Text = string.Format("Order overview table {0}", order.Table.ID);

                //set labels
                lblOrderPriceWithoutTax.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("withoutTax"));
                lblTaxAmount.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Tax"));
                lblTotalAmount.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Total"));

                //check if there's given a tip
                //if yes, show labels
                if (order.tip > 0)
                {
                    lblTip.Show();
                    lblTipAmount.Show();
                    lblTipAmount.Text = string.Format("€ {0:0.00}", order.tip);
                }
            }
        }
        
        private void lblTotalAmount_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnAddCommentToOrder_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnAddTipToOrder_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void lblTipGrandTotal_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnConfirmTip_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void btnAddTip_Click_1(object sender, EventArgs e)
        {
            ShowPanel("Tip");
        }

        private void btnAddComment_Click_1(object sender, EventArgs e)
        {
            ShowPanel("Comment");
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            //to-do pay screen
        }
    }
}
