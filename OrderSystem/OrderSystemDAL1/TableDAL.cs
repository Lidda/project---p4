using OrderSystemDAL;
using OrderSystemModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderSystemModel.Table;

namespace OrderSystemDAL {
    public class TableDAL : Base {
        List<Table> tables = new List<Table>();

        public List<Table> Db_Get_All_Tables() {
            string query = "SELECT tableID, availability, employeeID, capacity FROM [TABLES] ORDER BY [tableID]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAllTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadAllTables(DataTable dataTable) {
            foreach (DataRow dr in dataTable.Rows) {
                Table table = new Table() {
                    ID = (int)dr["tableID"],
                    EmployeeID = (int)dr["employeeID"],
                    Capacity = (int)dr["capacity"],
                    Status = (Availability)dr["availability"]
                };
                tables.Add(table);
            }
            return tables;
        }

        public List<Table> Db_Update_All_Tables(List<Table> tables) {
            string query = "SELECT availability, employeeID, tableID FROM [TABLES]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return UpdateAllTables(ExecuteSelectQuery(query, sqlParameters), tables);
        }

        private List<Table> UpdateAllTables(DataTable dataTable, List<Table> tables) {
            List<Table> employees = new List<Table>();

            for (int i = 0; i < dataTable.Rows.Count; i++) {
                DataRow dr = dataTable.Rows[i];
                tables[i].ID = (int)dr["tableID"];
                tables[i].Status = (Availability)dr["availability"];
                tables[i].EmployeeID = (int)dr["employeeID"];
            }
            return tables;
        }

        public void DbUpdateEmployeeID(int employeeID, int tableID) {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            string query = String.Format("UPDATE [TABLES] SET employeeID = {0} WHERE tableID = {1}", employeeID, tableID);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void AlterAvailability(Availability status, int tableID) {
            SqlParameter[] sqlParameters = new SqlParameter[0];
            string query = String.Format("UPDATE [TABLES] SET availability = {0} WHERE tableID = {1}", Convert.ToInt32(status), tableID);

            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
