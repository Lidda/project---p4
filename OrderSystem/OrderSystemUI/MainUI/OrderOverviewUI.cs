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

        //Adds all items to listview
        private void AddItemsToListView()
        {
            foreach (OrderItem orderItem in order.orderItems)
            {
                double price = orderItem.amount * orderItem.item.price;

                ListViewItem li = new ListViewItem(orderItem.item.name);
                li.SubItems.Add(orderItem.amount.ToString());
                li.SubItems.Add(price.ToString());
                if (orderItem.status == OrderItem.Status.ordered)
                {
                    li.SubItems.Add("X");
                    li.SubItems[3].ForeColor = System.Drawing.Color.Red;
                }
                else if (orderItem.status == OrderItem.Status.ready)
                {
                    
                    li.SubItems.Add("O");
                    li.SubItems[3].ForeColor = System.Drawing.Color.Orange;
                }
                else
                {
                    li.SubItems.Add("✔");
                    li.SubItems[3].ForeColor = System.Drawing.Color.Green;
                }
                li.UseItemStyleForSubItems = false;

                li.SubItems.Add(orderItem.ID.ToString());
                li.SubItems.Add(orderItem.comment.ToString());

                listView_Overview.Items.Add(li);
            }
        }

        //Adds the relevant data to the edit panel & opens edit panel
        private void btn_EditItem_Click(object sender, EventArgs e)
        {
            if(listView_Overview.SelectedItems.Count >= 1)
            {
                lbl_DisplayItemName.Text = listView_Overview.SelectedItems[0].SubItems[0].Text;
                txt_Amount.Text = listView_Overview.SelectedItems[0].SubItems[1].Text;
                txt_Comment.Text = listView_Overview.SelectedItems[0].SubItems[5].Text;

                pnl_EditItem.Show();
            }
            else
            {
                MessageBox.Show("Selecteer eerst een product");
            }
        }
        
        private void btn_CancelEdit_Click(object sender, EventArgs e)
        {
            lbl_DisplayItemName.Text = "";
            txt_Amount.Clear();
            txt_Comment.Clear();

            pnl_EditItem.Hide();

            stockAmount = 0;
        }

        //Confirms edited item
        private void btn_ConfirmEdit_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txt_Amount.Text);

            listView_Overview.SelectedItems[0].SubItems[1].Text = txt_Amount.Text;
            listView_Overview.SelectedItems[0].SubItems[3].Text = txt_Comment.Text;

            lbl_DisplayItemName.Text = "";
            txt_Amount.Clear();
            txt_Comment.Clear();

            OrderItem orderItem = order.orderItems.Find(i => i.ID == Convert.ToInt32(listView_Overview.SelectedItems[0].SubItems[4].Text));

            if (amount >= 1)
            {
                orderItemLogic.UpdateOrderItems(orderItem, stockAmount);
            }
            else
            {
                orderItemLogic.RemoveOrderItems(orderItem);
                listView_Overview.SelectedItems[0].Remove();
            }

            stockAmount = 0;

            pnl_EditItem.Hide();
        }

        //Ups the amount of the item
        private void btn_AddAmount_Click(object sender, EventArgs e)
        {
            int amount = Convert.ToInt32(txt_Amount.Text);
            amount++;
            stockAmount--;

            txt_Amount.Text = amount.ToString();
        }

        //Subtracts the amount
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

        //Goes back to the homescreen
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderUI.Show();

            stockAmount = 0;
        }

        //Deletes the item from the order
        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = order.orderItems.Find(i => i.ID == Convert.ToInt32(listView_Overview.SelectedItems[0].SubItems[4].Text));

            orderItemLogic.RemoveOrderItems(orderItem);
            listView_Overview.SelectedItems[0].Remove();
        }
    }
}
