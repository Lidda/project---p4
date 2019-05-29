using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;
using System.Data;
using OrderSystemDAL;

namespace OrderSystemDAL {
    public class LoginDAL : Base {

        public Employee Db_Find_User(Employee employee) {

            string query = string.Format("SELECT employeeID, name, username, password, type FROM [EMPLOYEES] " +
                "WHERE username = '{0}' AND password = '{1}'", employee.username, employee.password);

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters), employee);
        }
       
        private Employee ReadEmployee(DataTable dataTable, Employee employee) {

            // if the query returned an employee it means the username and password matched, and it gets the one employee.
            if (dataTable.Rows.Count > 0) {
                DataRow dr = dataTable.Rows[0];
                employee.ID = (int)dr["employeeID"];
                employee.name = (string)dr["name"];
                employee.type = (OrderSystemModel.Type)dr["type"];
                return employee;
            }

            // if the query did not match it returns the employee as null. 
            return null;
        }

    }
}
