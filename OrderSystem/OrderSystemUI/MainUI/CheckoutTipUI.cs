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
    public partial class CheckoutTipUI : Form
    {
        private OrderHomeUI orderHomeUI;
        private Order order;

        public CheckoutTipUI(Order order, OrderHomeUI orderHomeUI)
        {
            InitializeComponent();
            this.orderHomeUI = orderHomeUI;
            this.order = order;
            
            //set text
            InitTipFormLabels();
        }

        private void InitTipFormLabels()
        {
            //show euro signs
            lblEuroSign1.Show();
            lbleuroSign2.Show();
            lblEuroSign3.Show();

            //set text of labels
            lblTipHeader.Text = string.Format("Fooi tafel {0}", order.Table.ID);
            lblTipTip.Text = string.Format("{0:0.00}", order.tip);
            lblTipTotal.Text = string.Format("{0:0.00}", order.GetTotalAmount("Total") - order.tip);
            lblTipGrandTotal.Text = string.Format("{0:0.00}", order.GetTotalAmount("Total"));
        }

        private void btnAddTipToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //replace comma with a dot to make the program 'foolproof'
                order.tip = double.Parse(txtTip.Text.Replace('.', ','));

                //check if the tip is greater or equal to zero
                if (order.tip < 0)
                {
                    throw new Exception();
                }
                InitTipFormLabels();
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
            CheckoutOverviewOrderUI coUI = new CheckoutOverviewOrderUI(order, orderHomeUI);
            coUI.ShowDialog();
        }

        private void btnDeleteTip_Click(object sender, EventArgs e)
        {
            //sets tip to 0
            order.tip = 0;
            InitTipFormLabels();
        }

        private void pnlTip_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
