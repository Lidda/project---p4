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
    public partial class CheckoutComments : Form
    {
        private Order order;
        private CheckoutLogic logic = new CheckoutLogic();
        public CheckoutComments(Order order)
        {
            InitializeComponent();
            this.order = order;

            //show panel
            pnlAddComment.Show();
            pnlAddComment.BringToFront();
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

        private void btnAddCommentToOrder_Click(object sender, EventArgs e)
        {
            //add comment/alter comment
            order.comment = txtComment.Text;
            logic.EditComment(order);
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this comment?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //delete comment
                order.comment = "";
                logic.EditComment(order);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back
            this.Hide();
            CheckoutOverview coUI = new CheckoutOverview(order.Table, order.Employee);
            coUI.ShowDialog();
        }
    }
}
