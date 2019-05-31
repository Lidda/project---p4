using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;
using System.Data;

namespace OrderSystemDAL
{
    public class EmployeeDAL : Base {
        public void AddEmployee(Employee employee) {
            string query = "INSERT INTO [EMPLOYEES] (employeeID, name, username, password, type) VALUES ((SELECT COALESCE(MAX(employeeID)+1, 0) FROM [EMPLOYEES]), @name, @username, @password, @type)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@name", employee.name),
                new SqlParameter("@username", employee.username),
                new SqlParameter("@password", employee.password),
                new SqlParameter("@type", employee.type)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        //get a list with all employees
        public List<Employee> Db_Get_All_Employees() {
            string query = "SELECT name, username, password, type FROM [EMPLOYEES]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployees(ExecuteSelectQuery(query, sqlParameters));
        }

        //get a single employee by ID
        public Employee Db_Get_Employee(int employeeID) {
            string query = string.Format("SELECT name, username, password, type FROM [EMPLOYEES] WHERE employeeID = {0}", employeeID);
            SqlParameter[] sqlParameters = new SqlParameter[0];

            List<Employee> list = ReadEmployees(ExecuteSelectQuery(query, sqlParameters));

            //checks if it got only ONE employee
            if (list.Count == 1) {
                return list[0];
            } else {
                return null;
            }
        }

        private List<Employee> ReadEmployees(DataTable dataTable) {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows) {
                Employee employee = new Employee() {
                    name = (string)dr["name"],
                    username = (string)(dr["username"].ToString()),
                    password = (string)(dr["password"].ToString()),
                    type = (OrderSystemModel.Type)dr["type"]
                };
                employees.Add(employee);
            }
            return employees;
        }
    }
}
