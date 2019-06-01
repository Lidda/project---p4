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
using OrderSystemUI.MainUI;


namespace OrderSystemUI
{
    public partial class EditEmployeesUI : Form
    {
        EmployeeLogic employeeLogic = new EmployeeLogic();
        Employee loggedInEmployee;


        public EditEmployeesUI(Employee loggedInEmployee)
        {
            this.loggedInEmployee = loggedInEmployee;
            InitializeComponent();
            UI_Load();          
        }

        private void UI_Load()
        {
            ShowPanel("PNL_ManageEmployees");
        }

        private void ShowPanel(string panelName)
        {
            if (panelName == "PNL_ManageEmployees")
            {
                PNL_AddEmployee.Hide();
                PNL_EditEmployee.Hide();
                PNL_ManageEmployee.Show();

                
                List<Employee> employeeListView = employeeLogic.GetAllEmployees();

                ListView_Employees.Items.Clear();

                foreach (OrderSystemModel.Employee employee in employeeListView)
                {
                    ListViewItem li = new ListViewItem(employee.ID.ToString());
                    li.SubItems.Add(employee.name);
                    li.SubItems.Add(employee.username);
                    li.SubItems.Add(employee.password);
                    li.SubItems.Add(employee.type.ToString());
                    ListView_Employees.Items.Add(li);
                }
            }
            else if (panelName == "PNL_EditEmployee")
            {
                PNL_ManageEmployee.Hide();
                PNL_EditEmployee.Show();
            }
            else if(panelName == "PNL_AddEmployee")
            {
                PNL_ManageEmployee.Hide();
                PNL_AddEmployee.Show();
            }
        }

        private void BTN_AddEmployee_Click(object sender, EventArgs e)
        {          
            Employee employee = new Employee();
            employee.name = TXTB_AddEmployeeName.Text;
            employee.username = TXTB_AddEmployeeUsername.Text;
            employee.password = TXTB_AddEmployeePassword.Text;
            employee.type = (OrderSystemModel.Type)Enum.Parse(typeof(OrderSystemModel.Type), DB_AddEmployeeType.SelectedItem.ToString());
            employeeLogic.AddEmployee(employee);
            MessageBox.Show("Employee was succesfully added!");
            ShowPanel("PNL_ManageEmployees");
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_EditEmployee");
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_AddEmployee");
        }

        private void ListView_Employees_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            LBL_EditEmployeeID.Text = e.Item.SubItems[0].Text;
            TXTB_EditEmployeeName.Text = e.Item.SubItems[1].Text;
            TXTB_EditEmployeeUsername.Text = e.Item.SubItems[2].Text;
            TXTB_EditEmployeePassword.Text = e.Item.SubItems[3].Text;
            DB_EditEmployeeType.Text = e.Item.SubItems[4].Text;
        }

        private void BTN_EditEmployee_Click(object sender, EventArgs e)
        {
            
            Employee employee = new Employee();
            employee.ID = int.Parse(LBL_EditEmployeeID.Text);
            employee.name = TXTB_EditEmployeeName.Text;
            employee.username = TXTB_EditEmployeeUsername.Text;
            employee.password = TXTB_EditEmployeePassword.Text;
            employee.type = (OrderSystemModel.Type)Enum.Parse(typeof(OrderSystemModel.Type), DB_EditEmployeeType.Text);
            employeeLogic.EditEmployee(employee);
            MessageBox.Show("Employee was succesfully edited");
            ShowPanel("PNL_ManageEmployees");
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.ID = int.Parse(LBL_EditEmployeeID.Text);              
            if(MessageBox.Show("Are you sure you want to delete this employee?", "Deleting...", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                employeeLogic.DeleteEmployee(employee);
                MessageBox.Show("Employee succesfully deleted");
                ShowPanel("PNL_ManageEmployees");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerUI managerUI = new ManagerUI(loggedInEmployee);
            managerUI.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_ManageEmployees");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_ManageEmployees");
        }
    }
}
