﻿using OrderSystemDAL1;
using OrderSystemModel1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OrderSystemModel1.Table;

namespace OrderSystemLogic1 {
    public class TableLogic {
        TableDAL table_db = new TableDAL();

        public List<Table> GetAllTables() {
            //try {
                return table_db.Db_Get_All_Tables();
           // } catch {
             //   throw new Exception("Something went wrong when loading in tables.");
           // }
        }

        public void UpdateTableStatus(Availability status, Table table) {
            try {
                table_db.UpdateAvailability(status, table.ID);
            } catch {
                throw new Exception("Something went wrong when updating the table status.");
            }
        }

    }
}
