using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;

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
    }
}
