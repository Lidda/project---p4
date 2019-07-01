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
        Employee selectedEmployee = new Employee();


        public EditEmployeesUI(Employee loggedInEmployee)
        {
            this.loggedInEmployee = loggedInEmployee;
            InitializeComponent();
            ShowPanel("PNL_ManageEmployees");
        }

        //Shows the requested panel
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
                TXTB_EditEmployeeName.Text = selectedEmployee.name;
                TXTB_EditEmployeeUsername.Text = selectedEmployee.username;
                TXTB_EditEmployeePassword.Text = selectedEmployee.password;
                DB_EditEmployeeType.Text = selectedEmployee.type.ToString();
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
            try
            {
                Employee employee = new Employee();
                employee.name = TXTB_AddEmployeeName.Text;
                employee.username = TXTB_AddEmployeeUsername.Text;
                employee.password = TXTB_AddEmployeePassword.Text;
                employee.type = (OrderSystemModel.employeeType)Enum.Parse(typeof(OrderSystemModel.employeeType), DB_AddEmployeeType.SelectedItem.ToString());
                employeeLogic.AddEmployee(employee);
                MessageBox.Show("Medewerder succesvol toegevoegd");
                ShowPanel("PNL_ManageEmployees");
            }
            catch
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
        }

        //go to manage empoyee panel
        private void EditEmployee_Click(object sender, EventArgs e)
        {
            if (selectedEmployee.ID != 0)
            {
                ShowPanel("PNL_EditEmployee");
            }
            else
            {
                MessageBox.Show("Selecteer eerst een medewerker");
            }
        }

        //go to add employee panel
        private void AddEmployee_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_AddEmployee");
        }

        //places selected employee into the selectedEmployee object
        private void ListView_Employees_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
                selectedEmployee.ID = int.Parse(e.Item.SubItems[0].Text);
                selectedEmployee.name = e.Item.SubItems[1].Text;
                selectedEmployee.username = e.Item.SubItems[2].Text;
                selectedEmployee.password = e.Item.SubItems[3].Text;
                selectedEmployee.type = (OrderSystemModel.employeeType)Enum.Parse(typeof(OrderSystemModel.employeeType), e.Item.SubItems[4].Text);          
        }


        private void BTN_EditEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                selectedEmployee.name = TXTB_EditEmployeeName.Text;
                selectedEmployee.username = TXTB_EditEmployeeUsername.Text;
                selectedEmployee.password = TXTB_EditEmployeePassword.Text;
                selectedEmployee.type = (OrderSystemModel.employeeType)Enum.Parse(typeof(OrderSystemModel.employeeType), DB_EditEmployeeType.Text);
                employeeLogic.EditEmployee(selectedEmployee);
                selectedEmployee = new Employee();
                MessageBox.Show("Medewerker is succesvol aangepast");
                ShowPanel("PNL_ManageEmployees");
            }
            catch
            {
                MessageBox.Show("Niet alle velden zijn ingevuld");
            }
        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            if (selectedEmployee.ID > 0)
            {
                if (MessageBox.Show("Weet u zeker dat u deze medewerker wilt verwijderen?", "Deleten...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    employeeLogic.DeleteEmployee(selectedEmployee);
                    selectedEmployee = new Employee();
                    MessageBox.Show("Medewerker is succesvol gedeletet");
                    ShowPanel("PNL_ManageEmployees");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een medewerker");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerUI managerUI = new ManagerUI(loggedInEmployee);
            managerUI.ShowDialog();
        }

        //back button on Add panel
        private void button1_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_ManageEmployees");
        }

        //back button on Edit panel
        private void button3_Click(object sender, EventArgs e)
        {
            ShowPanel("PNL_ManageEmployees");
        }
    }
}
