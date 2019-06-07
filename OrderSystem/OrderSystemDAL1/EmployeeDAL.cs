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
                new SqlParameter("@type", (int)employee.type)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void EditEmployee(Employee employee)
        {
            string query = "UPDATE [EMPLOYEES] SET name = @name, username = @username, password = @password, type = @type WHERE employeeID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", employee.ID),
                new SqlParameter("@name", employee.name),
                new SqlParameter("@username", employee.username),
                new SqlParameter("@password", employee.password),
                new SqlParameter("@type", (int)employee.type)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteEmployee(Employee employee)
        {
            string query = "DELETE FROM [EMPLOYEES] WHERE employeeID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", employee.ID)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        //get a list with all employees
        public List<Employee> Db_Get_All_Employees() {
            string query = "SELECT employeeID, name, username, password, type FROM [EMPLOYEES]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployees(ExecuteSelectQuery(query, sqlParameters));
        }

        //get a single employee by ID
        public Employee Db_Get_Employee(int employeeID) {
            string query = string.Format("SELECT employeeID, name, username, password, type FROM [EMPLOYEES] WHERE employeeID = {0}", employeeID);
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
                    ID = (int)dr["employeeID"],
                    name = (string)dr["name"],
                    username = (string)(dr["username"].ToString()),
                    password = (string)(dr["password"].ToString()),
                    type = (OrderSystemModel.employeeType)dr["type"]
                };
                employees.Add(employee);
            }
            return employees;
        }
    }
}
