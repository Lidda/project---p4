 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemDAL;
using OrderSystemModel;

namespace OrderSystemLogic
{
    //FIX ME: maybe make a singleton? << je hebt deze vaker nodig, bij login en bij manage employees: dualton?
    public class EmployeeLogic {
        EmployeeDAL employee_db = new EmployeeDAL();

        public void AddEmployee(Employee employee) {
            try {
                employee_db.AddEmployee(employee);
            } catch {
                throw new Exception("Something went wrong.");
            }
        }

        public List<Employee> GetAllEmployees() {
            try {
                return employee_db.Db_Get_All_Employees();
            } catch {
                throw new Exception("Something went wrong.");
            }
        }

        public void EditEmployee(Employee employee) {
            try {
                employee_db.EditEmployee(employee);
            } catch {
                throw new Exception("Something went wrong.");
            }
        }

        public void DeleteEmployee(Employee employee) {
            try
            {
                employee_db.DeleteEmployee(employee);
        } catch {
                throw new Exception("Something went wrong.");
    }
}

        public bool CheckForUser(Employee employee) {
            try {
                employee = employee_db.Db_Find_User(employee);

                if (employee == null) {
                    return false;
                }
                return true;

            } catch {
                throw new Exception("Something went wrong.");
            }
        }
    }
}
