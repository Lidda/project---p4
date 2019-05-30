using OrderSystemDAL;
using OrderSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderSystemModel.Table;

namespace OrderSystemLogic1 {
    public class TableLogic {
        TableDAL table_db = new TableDAL();

        public List<Table> GetAllTables() {
            try {
            return table_db.Db_Get_All_Tables();
            } catch {
                throw new Exception("Something went wrong when loading in tables.");
            }
        }

        public List<Table> UpdateTables(List<Table> tables) {
           try {
                return table_db.Db_Update_All_Tables(tables);
            } catch {
            throw new Exception("Something went wrong when updating the tables");
            }
        }

        public void AlterTableStatus(Availability status, Table table) {
            try {
                table_db.AlterAvailability(status, table.ID);
            } catch {
                throw new Exception("Something went wrong when altering the table status.");
            }
        }

    }
}
