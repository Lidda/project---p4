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
using OrderSystemUI;

namespace OrderSystemUI.MainUI
{
    public partial class CheckoutOverviewOrderUI : Form
    {
        private OrderHomeUI orderHomeUI;
        private Order order;

        public CheckoutOverviewOrderUI(Order order, OrderHomeUI orderHomeUI)
        {
            InitializeComponent();

            this.order = order;
            this.orderHomeUI = orderHomeUI;

            //hide tip labels
            lblTip.Hide();
            lblTipAmount.Hide();
            lblTipEuroSign.Hide();

            //check if there's a order
            //if no; show "error" panel
            if (order.orderItems.Count == 0)
            {
                ShowPanel("Error");
            }
            else
            {
                ShowPanel("Overview");
            }
        }

        private void ShowPanel(string panelName)
        {
            if (panelName == "Tip")
            {
                //open tip UI
                this.Hide();
                CheckoutTipUI checkoutTipUI = new CheckoutTipUI(order, orderHomeUI);
                checkoutTipUI.ShowDialog();
            }
            else if (panelName == "Pay")
            {
                //open pay UI
                this.Hide();
                CheckoutPayUI checkoutUI = new CheckoutPayUI(order, orderHomeUI);
                checkoutUI.ShowDialog();
            }
            else if (panelName == "Error")
            {
                //show 'no orders found' panel
                pnlError.Show();
                pnlError.BringToFront();

                //disable other buttons
                btnAddComment.Enabled = false;
                btnAddTip.Enabled = false;
                btnPay.Enabled = false;
            }
            else if (panelName == "Back")
            {
                //back
                //go back to overview
                this.Hide();
                orderHomeUI.Show();
            }
            else if (panelName == "Comment")
            {
                //show comment UI
                this.Hide();
                CheckoutCommentsUI checkoutCommentsUI = new CheckoutCommentsUI(order, orderHomeUI);
                checkoutCommentsUI.ShowDialog();
            }
            else if (panelName == "Overview")
            {
                //hide other panel
                pnlError.Hide();

                //enable buttons
                btnAddComment.Enabled = true;
                btnAddTip.Enabled = true;
                btnPay.Enabled = true;

                //set title of header
                lblCheckoutOverviewHeader.Text = string.Format("Overzicht bestelling tafel {0}", order.Table.ID);

                //set labels to visible
                lblOrderPriceWithoutTax.Show();
                lblTaxAmount.Show();
                lblTotalAmount.Show();

                //set label prices
                this.lblOrderPriceWithoutTax.Text = string.Format("{0:0.00}", order.GetTotalAmount("withoutTax"));
                this.lblTaxAmount.Text = string.Format("{0:0.00}", order.GetTotalAmount("Tax"));
                this.lblTotalAmount.Text = string.Format("{0:0.00}", order.GetTotalAmount("Total"));

                //check if there's given a tip
                //if yes, show labels
                if (order.tip > 0)
                {
                    lblTip.Show();
                    lblTipAmount.Show();
                    lblTipEuroSign.Show();
                    lblTipAmount.Text = string.Format("{0:0.00}", order.tip);
                }
                //empty listview before filling it
                listViewOrderItems.Items.Clear();

                //filling listview
                foreach(OrderItem item in order.orderItems)
                {
                    ListViewItem li;

                    //check if there's a comment 
                    if (string.IsNullOrWhiteSpace(item.comment))
                    {
                        li = new ListViewItem(item.item.name);
                    }
                    else
                    {
                        li = new ListViewItem(string.Format("{0} ~ {1}", item.item.name, item.comment));
                    }

                    li.SubItems.Add(item.amount.ToString());
                    li.SubItems.Add(item.GetAmount("Total").ToString("0.00"));

                    listViewOrderItems.Items.Add(li);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowPanel("Back");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            ShowPanel("Pay");
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            ShowPanel("Comment");
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            ShowPanel("Tip");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //go back
            ShowPanel("Back");
        }

        private void listViewOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //view comment of item
            //check if there's a item selected in listview
            if (listViewOrderItems.SelectedItems.Count >= 1)
            {
               string comment = listViewOrderItems.SelectedItems[0].Text;
                MessageBox.Show(comment);
            }
            
        }
    }
}
