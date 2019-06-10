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

namespace OrderSystemUI.MainUI
{
    public partial class CheckoutConfirmationUI : Form
    {
        private Order order;

        public CheckoutConfirmationUI(Order order)
        {
            InitializeComponent();
            this.order = order;

            //adjust background image
            pbConfirmation.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //go back to overview
            //opens th form corresponding with user
            this.Hide();
            if (order.Employee.type == OrderSystemModel.employeeType.Barman)
            {
                BarUI barUI = new BarUI(order.Employee);
                barUI.ShowDialog();
            }
            else if (order.Employee.type == OrderSystemModel.employeeType.Serveerder)
            {
                TableOverviewUI waiterUI = new TableOverviewUI(order.Employee);
                waiterUI.ShowDialog();
            }
            else if (order.Employee.type == OrderSystemModel.employeeType.Kok)
            {
                KitchenUI kitchenUI = new KitchenUI(order.Employee);
                kitchenUI.ShowDialog();
            }
            else if (order.Employee.type == OrderSystemModel.employeeType.Manager)
            {
                ManagerUI managerUI = new ManagerUI(order.Employee);
                managerUI.ShowDialog();
            }
        }
    }
}
