using OrderSystemDAL;
using OrderSystemModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderSystemModel.TableModel;

namespace OrderSystemDAL {
    public class TableDAL : Base {    
        EmployeeDAL employeeDAL = new EmployeeDAL();

        public List<TableModel> Db_Get_All_Tables() {
            string query = "SELECT tableID, availability, employeeID, capacity FROM [TABLES] ORDER BY [tableID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAllTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<TableModel> ReadAllTables(DataTable dataTable) {
            List<TableModel> tables = new List<TableModel>();
            foreach (DataRow dr in dataTable.Rows) {
                TableModel table = new TableModel() {
                    ID = (int)dr["tableID"],                  
                    Capacity = (int)dr["capacity"],
                    Status = (Availability)dr["availability"],
                    //Gets a single employee object from the method through the read employeeID
                    Employee = employeeDAL.Db_Get_Employee((int)dr["employeeID"])
                };
                tables.Add(table);
            }
            return tables;
        }

        public void DbAssignEmployee(EmployeeModel employee, TableModel table) {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            string query = String.Format("UPDATE [TABLES] SET employeeID = {0} WHERE tableID = {1}", employee.ID, table.ID);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateAvailability(Availability status, int tableID) {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            string query = String.Format("UPDATE [TABLES] SET availability = {0} WHERE tableID = {1}", Convert.ToInt32(status), tableID);

            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
