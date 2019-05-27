using OrderSystemDAL1;
using OrderSystemModel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemLogic1 {
    public class TableLogic {
        TableDAL table_db = new TableDAL();

        public List<Table> GetAllEmployees(List<Table> tables) {
            try {
                return table_db.Db_Get_All_Tables(tables);
            } catch {
                throw new Exception("Something went wrong when loading in tables.");
            }
        }
    }
}
