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

namespace OrderSystemUI
{
    public partial class OrderSystemUI : Form
    {
        public OrderSystemUI()
        {
            InitializeComponent();
        }

        private void BTN_AddEmployee_Click(object sender, EventArgs e)
        {
            EmployeeLogic employeeLogic = new EmployeeLogic();
            Employee employee = new Employee();
            employee.name = TXTB_AddEmployeeName.Text;
            employee.username = TXTB_AddUsername.Text;
            employee.password = TXTB_AddPassword.Text;
            employee.type = (OrderSystemModel.Type)Enum.Parse(typeof(OrderSystemModel.Type), DB_AddEmployeeType.SelectedItem.ToString());
            employeeLogic.AddEmployee(employee);
        }
    }
}
