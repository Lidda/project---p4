using OrderSystemModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystemUI.MainUI {
    public partial class ManagerUI : Form
    {
        Employee employee;

        public ManagerUI(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginUI loginUI = new LoginUI();
            loginUI.ShowDialog();
            this.Close();
        }

        private void BTN_ManageEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditEmployeesUI editEmployeesUI = new EditEmployeesUI();
            editEmployeesUI.ShowDialog();
        }

        private void BTN_ManageProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStockUI editStockUI = new EditStockUI();
            editStockUI.ShowDialog();
        }

        private void BTN_Stats_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinancesUI financesUI = new FinancesUI();
            financesUI.ShowDialog();
        }
    }
}
