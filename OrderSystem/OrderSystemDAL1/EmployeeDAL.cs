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
    public class EmployeeDAL : Base
    {
        public void AddEmployee(Employee employee)
        {
            string query = "INSERT INTO [EMPLOYEES] (employeeID, name, username, password, type) VALUES ((SELECT COALESCE(MAX(employeeID)+1, 0) FROM [EMPLOYEES]), @name, @username, @password, @type)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@name", employee.name),
                new SqlParameter("@username", employee.username),
                new SqlParameter("@password", employee.password),
                new SqlParameter("@type", employee.type.ToString())
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Employee> Db_Get_All_Employees()
        {
            string query = "SELECT name, username, password, type FROM [EMPLOYEES]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployees(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Employee> ReadEmployees(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    name = (string)dr["name"],
                    username = (string)(dr["username"].ToString()),
                    password = (string)(dr["password"].ToString()),
                    type = (OrderSystemModel.Type)Enum.Parse(typeof(OrderSystemModel.Type), dr["type"].ToString())
                };
                employees.Add(employee);
            }
            return employees;
        }
    }
}
