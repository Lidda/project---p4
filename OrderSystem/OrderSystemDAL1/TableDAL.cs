using OrderSystemDAL;
using OrderSystemModel1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemDAL1 {
    public class TableDAL : Base {
        List<Table> tables = new List<Table>();

        public List<Table> Db_Get_All_Tables(List<Table> tables) {
            this.tables = tables;

            string query = "SELECT tableID, status FROM [TABLES]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadAllTables(ExecuteSelectQuery(query, sqlParameters));
        }

        //FIX ME probably create a seperate method for updating the status etc. 
        private List<Table> ReadAllTables(DataTable dataTable) {
            List<Table> employees = new List<Table>();

            for (int i = 0; i < dataTable.Rows.Count; i++) {
                DataRow dr = dataTable.Rows[i];
                tables[i].ID = (int)dr["tableID"];
                tables[i].Status = (int)dr["status"];
            }

            return tables;

        }
    }
}
