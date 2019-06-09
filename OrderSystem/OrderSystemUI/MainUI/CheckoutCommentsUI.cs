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
using OrderSystemUI;

namespace OrderSystemUI.MainUI
{
    public partial class CheckoutCommentsUI : Form
    {
        private Order order;
        private OrderLogic orderLogic = new OrderLogic();
        private OrderHomeUI orderHomeUI;

        public CheckoutCommentsUI(Order order, OrderHomeUI orderHomeUI)
        {
            InitializeComponent();
            this.order = order;
            this.orderHomeUI = orderHomeUI;
            InitComments();
        }
        private void InitComments()
        {
            //show panel
            pnlAddComment.Show();
            pnlAddComment.BringToFront();
            //set title header
            lblCommentHeader.Text = string.Format("Tafel {0} bestelling {1}: commentaar", order.Table.ID, order.orderID);
            //empty textbox
            txtComment.Text = "";
            //set current comment
            if (order.comment == "")
            {
                lblCurrentComment.Text = "er is nog geen opmerking!";
                btnAddCommentToOrder.Text = "Voeg commentaar toe";
            }
            else
            {
                lblCurrentComment.Text = order.comment;
                btnAddCommentToOrder.Text = "Verander commentaar";
            }
        }
        private void btnAddCommentToOrder_Click(object sender, EventArgs e)
        {
            //add comment/alter comment
            order.comment = txtComment.Text;
            orderLogic.Edit_Order_Comment(order);
            InitComments();
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("weet je zeker dat je deze opmerking wilt verwijderen?",
                                     "Bevestig verwijderen!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //delete comment
                order.comment = "";
                orderLogic.Edit_Order_Comment(order);
            }
            InitComments();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back
            this.Hide();
            CheckoutOverviewOrderUI coUI = new CheckoutOverviewOrderUI(order, orderHomeUI);
            coUI.ShowDialog();
        }
    }
}
