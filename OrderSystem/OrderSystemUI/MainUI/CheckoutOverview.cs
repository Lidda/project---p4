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
            if (panelName == "Tip")
            {
                //show panel
                pnlTip.Show();
                //hide
                pnlOverview.Hide();
                pnlAddComment.Hide();
                //set text
                lblTipHeader.Text = string.Format("Add tip table {0}", order.Table.ID);
                lblTipTip.Text = string.Format("€ {0:0.00}", order.tip);
                lblTipTotal.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Total") - order.tip);
                lblTipGrandTotal.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Total"));
            }
            else if (panelName == "Comment")
            {
                //show panel
                pnlAddComment.Show();
                //hide other panels
                pnlOverview.Hide();
                //set title header
                lblCommentHeader.Text = string.Format("Table {0} Order {1}: comment", order.Table.ID, order.orderID);
                //empty textbox
                txtComment.Text = "";
                //set current comment
                if (order.comment == "")
                {
                    lblCurrentComment.Text = "there's no current comment yet!";
                    btnAddCommentToOrder.Text = "Add comment";
                }
                else
                {
                    lblCurrentComment.Text = order.comment;
                    btnAddCommentToOrder.Text = "Alter comment";
                }
            }
            else if (panelName == "Overview")
            {
                //refresh order
                RefereshOrder();

                //show panels
                pnlOverview.Show();

                //hide
                pnlAddComment.Hide();
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
            ShowPanel("Comment");
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            //go to 'add tip' screen
            ShowPanel("Tip");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back buttom of add comment panel
            ShowPanel("Overview");
        }

        private void btnAddCommentToOrder_Click(object sender, EventArgs e)
        {
            order.comment = txtComment.Text;
            logic.AddComment(order);

            MessageBox.Show("Comment added!");
            ShowPanel("Comment");
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            //delete current comment
            var confirmResult = MessageBox.Show("Are you sure to delete this comment?",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                order.comment = "";
                logic.AddComment(order);
            }
            ShowPanel("Comment");
        }

        private void btnAddTipToOrder_Click(object sender, EventArgs e)
        {
            //save tip in order.tip
            order.tip = double.Parse(txtTip.Text);
            ShowPanel("Tip");
        }

        private void lblTipGrandTotal_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cancel adding tip
            order.tip = 0;
            ShowPanel("Tip");
        }

        private void btnConfirmTip_Click(object sender, EventArgs e)
        {
            //confirm and go back to overview > tip has been saved in order.tip
            ShowPanel("Overview");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //back button on tip panel
            ShowPanel("Overview");
        }
    }
}
