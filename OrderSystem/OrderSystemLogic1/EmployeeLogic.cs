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
                throw new Exception("Yikes, dat is niet best");
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
                throw new Exception("Yikes, dat is ook niet best");
            }            
        }
    }
}
