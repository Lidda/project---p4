using OrderSystemLogic1;
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

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            employee.name = usernameInput.Text;
            employee.password = passwordInput.Text;

            logic.CheckForUser(employee);
        }
    }
}
