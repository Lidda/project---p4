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
    public partial class CheckoutOverviewOrder : Form
    {
        private CheckoutLogic logic = new CheckoutLogic();
        private Order order;

        public CheckoutOverviewOrder(Table table, Employee employee)
        {
            InitializeComponent();
            //hide
            lblTip.Hide();
            lblTipAmount.Hide();
            order = logic.GetOrder(table, employee);
            if (order.items.Count == 0)
            {
                ShowPanel("Error");
            }
            else
            {
                ShowPanel("Overview");
            }
        }
        public CheckoutOverviewOrder(Order order)
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
            else if (panelName == "Pay")
            {
                this.Hide();
                CheckoutPay checkoutUI = new CheckoutPay(order);
                checkoutUI.ShowDialog();
            }
            else if (panelName == "Error")
            {
                pnlError.Show();
                pnlError.BringToFront();
            }
            else if (panelName == "Back")
            {
                //back
                //go back to overview
                //opens th form corresponding with user
                this.Hide();
                if (order.Employee.type == OrderSystemModel.Type.Bartender)
                {
                    BarUI barUI = new BarUI(order.Employee);
                    barUI.ShowDialog();
                }
                else if (order.Employee.type == OrderSystemModel.Type.Waiter)
                {
                    TableOverviewUI waiterUI = new TableOverviewUI(order.Employee);
                    waiterUI.ShowDialog();
                }
                else if (order.Employee.type == OrderSystemModel.Type.Cook)
                {
                    KitchenUI kitchenUI = new KitchenUI(order.Employee);
                    kitchenUI.ShowDialog();
                }
                else if (order.Employee.type == OrderSystemModel.Type.Manager)
                {
                    ManagerUI managerUI = new ManagerUI(order.Employee);
                    managerUI.ShowDialog();
                }
            }
            else if (panelName == "Comment")
            {
                this.Hide();
                CheckoutComments checkoutCommentsUI = new CheckoutComments(order);
                checkoutCommentsUI.ShowDialog();
            }
            else if (panelName == "Overview")
            {
                pnlError.Hide();

                //set title of header
                lblCheckoutOverviewHeader.Text = string.Format("Order overview table {0}", order.Table.ID);

                //set labels
                lblOrderPriceWithoutTax.Show();
                lblTaxAmount.Show();
                lblTotalAmount.Show();


                this.lblOrderPriceWithoutTax.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("withoutTax"));
                this.lblTaxAmount.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Tax"));
                this.lblTotalAmount.Text = string.Format("€ {0:0.00}", order.GetTotalAmount("Total"));

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
    }
}
