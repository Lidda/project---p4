using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemLogic;
using OrderSystemModel;
using System.Windows.Forms;

namespace OrderSystemUI.MainUI
{
    public partial class KitchenUI : Form
    {
        Employee employee;
        private OrderLogic orderLogic = new OrderLogic();
        private Order order;
        public KitchenUI(Employee employee)
        {
            this.employee = employee;
            List<Order> order = orderLogic.GetOrderskitchen();
            InitializeComponent();
            Order1();
        }
        public void Order1()
        {
            listView1.Items.Clear();

            foreach (OrderItem order in order.orderItems)
            {
                ListViewItem li = new ListViewItem(order.TimeOfOrder.ToString("HH:mm"));
                li.SubItems.Add(order.item.name);
                li.SubItems.Add(order.item.foodtype);
                li.SubItems.Add(order.amount.ToString());
                li.SubItems.Add(order.status.ToString());
                listView1.Items.Add(li);
            }
        }

    }
}
