 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemDAL;
using OrderSystemModel;

namespace OrderSystemLogic
{
    public class EmployeeLogic
    {
        EmployeeDAL employee_db = new EmployeeDAL();

        public void AddEmployee(Employee employee)
        {
            try
            {
                employee_db.AddEmployee(employee);
            }
            catch
            {
                throw new Exception("failed to add employee to database");
            }
        }

        public List<Employee> GetAllEmployees()
        {           
            try
            {
                return employee_db.Db_Get_All_Employees();
            }
            catch
            {
                throw new Exception("failed to get employees from database");
            }            
        }

        public void EditEmployee(Employee employee)
        {
            try
            {
                employee_db.EditEmployee(employee);
            }
            catch
            {
                throw new Exception("failed to edit employee in databse");
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            try
            {
                employee_db.DeleteEmployee(employee);
            }
            catch
            {
                throw new Exception("failed to delete empoyee from database");
            }
        }
    }
}
