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
            UI_Load();
        }

        private void UI_Load()
        {
            ShowPanel("PNL_EditEmployee");
        }

        private void ShowPanel(string panelName)
        {
            if (panelName == "PNL_EditEmployee")
            {
                PNL_EditEmployee.Show();

                EmployeeLogic employeeLogic = new EmployeeLogic();
                List<Employee> employeeListView = employeeLogic.GetAllEmployees();

                ListView_Employees.Items.Clear();

                foreach (OrderSystemModel.Employee employee in employeeListView)
                {
                    ListViewItem li = new ListViewItem(employee.name);
                    li.SubItems.Add(employee.username);
                    li.SubItems.Add(employee.password);
                    li.SubItems.Add(employee.type.ToString());
                    ListView_Employees.Items.Add(li);
                }
            }
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

        private void BTN_EditEmployee_Click(object sender, EventArgs e)
        {

        }

        private void BTN_DeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private void editEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_EditEmployee");
        }

        private void addEmpoyeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_AddEmployee");
        }      
    }
}
