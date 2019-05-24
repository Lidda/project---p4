using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;
using System.Data;
using OrderSystemDAL;

namespace OrderSystemDAL1 {
    public class LoginDAL : Base {
        Employee employee;

        public bool Db_Check_User(Employee employee) {
            this.employee = employee;

            string query = string.Format("SELECT name, username, password, type FROM [EMPLOYEES] " +
                "WHERE username = '{0}' AND password = '{1}'", employee.username, employee.password);

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadEmployee(ExecuteSelectQuery(query, sqlParameters));
        }

        private bool ReadEmployee(DataTable dataTable) {
            foreach (DataRow dr in dataTable.Rows) {
                employee.name = (string)dr["name"];
                employee.type = (OrderSystemModel.Type)Enum.Parse(typeof(OrderSystemModel.Type), dr["type"].ToString());

                return true;
            };

            return false;
        }

    }
}
