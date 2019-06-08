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
    public partial class OrderOverviewUI : Form
    {
        OrderItemLogic orderItemLogic = new OrderItemLogic();
        OrderLogic orderLogic = new OrderLogic();

        int stockAmount;
        Order order;
        Item selectedItem = new Item();

        OrderHomeUI orderUI;

        public OrderOverviewUI(Order order, OrderHomeUI orderMenuUI)
        {
            InitializeComponent();

            this.order = orderLogic.get_Order(order);
            this.orderUI = orderMenuUI;

            AddItemsToListView();
        }

        private void AddItemsToListView()
        {
            foreach (OrderItem orderItem in order.orderItems)
            {
                 double price = orderItem.amount * orderItem.item.price;

                 ListViewItem li = new ListViewItem(orderItem.item.name);
                 li.SubItems.Add(orderItem.amount.ToString());
                 li.SubItems.Add(price.ToString());
                 li.SubItems.Add(orderItem.comment.ToString());

                 listView_Overview.Items.Add(li);
            }
        }

        private void btn_EditItem_Click(object sender, EventArgs e)
        {
            if(listView_Overview.SelectedItems.Count >= 1)
            {
                lbl_DisplayItemName.Text = listView_Overview.SelectedItems[0].SubItems[0].Text;
                txt_Amount.Text = listView_Overview.SelectedItems[0].SubItems[1].Text;
                txt_Comment.Text = listView_Overview.SelectedItems[0].SubItems[3].Text;
                pnl_EditItem.Show();
            }
            else
            {
                MessageBox.Show("Error", "Selecteer eerst een product");
            }
        }

        private void btn_CancelEdit_Click(object sender, EventArgs e)
        {
            lbl_DisplayItemName.Text = "";
            txt_Amount.Clear();
            txt_Comment.Clear();

            pnl_EditItem.Hide();
        }

        private void btn_ConfirmEdit_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txt_Amount.Text);

            listView_Overview.SelectedItems[0].SubItems[1].Text = txt_Amount.Text;
            listView_Overview.SelectedItems[0].SubItems[3].Text = txt_Comment.Text;

            lbl_DisplayItemName.Text = "";
            txt_Amount.Clear();
            txt_Comment.Clear();

            OrderItem orderItem = order.orderItems.Find(i => i.item.name == listView_Overview.SelectedItems[0].SubItems[0].Text);

            if (amount >= 1)
            {
                orderItemLogic.UpdateOrderItems(orderItem, stockAmount);
            }
            else
            {
                orderItemLogic.RemoveOrderItems(orderItem);
            }

            pnl_EditItem.Hide();
        }

        private void btn_AddAmount_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txt_Amount.Text);
            amount++;
            txt_Amount.Text = amount.ToString();
        }

        private void btn_SubtractAmount_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txt_Amount.Text);

            if (amount >= 1)
            {
                amount--;
                stockAmount++;

                txt_Amount.Text = amount.ToString();
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderUI.Show();
        }
    }
}
