using OrderSystemLogic;
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
    public partial class LoginUI : Form {
        Employee employee = new Employee();
        LoginLogic logic = new LoginLogic();

        public LoginUI() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            int employeeID;

            //tries to turn the received input into an it; if it's successful it sets the employee ID; if it is not successful it sets the username.
            if (int.TryParse(usernameInput.Text, out employeeID)) {
                employee.ID = employeeID;
            } else {
                employee.username = usernameInput.Text;
            }
            employee.password = passwordInput.Text;

            if (logic.CheckForUser(employee)) {
                this.Hide();

                //opens th form corresponding with user
                if (employee.type == OrderSystemModel.Type.Bartender) {
                    BarUI barUI = new BarUI(employee);
                    barUI.ShowDialog();
                } else if (employee.type == OrderSystemModel.Type.Waiter) {
                    TableOverviewUI waiterUI = new TableOverviewUI(employee);
                    waiterUI.ShowDialog();
                } else if (employee.type == OrderSystemModel.Type.Cook) {
                    KitchenUI kitchenUI = new KitchenUI(employee);
                    kitchenUI.ShowDialog();
                } else if (employee.type == OrderSystemModel.Type.Manager) {
                    ManagerUI managerUI = new ManagerUI(employee);
                    managerUI.ShowDialog();
                }
                this.Close();
            } else {
                MessageBox.Show("Invalid username or password.");
                usernameInput.Clear();
                passwordInput.Clear();
            }
        }
    }
}
