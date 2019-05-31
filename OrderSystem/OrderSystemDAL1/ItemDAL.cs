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
    public class ItemDAL : Base
    {
        public List<Item> Db_Get_All_Items()
        {
            string query = "SELECT itemID, name, stock, price, course, description, TAX, foodtype FROM [ITEMS]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Item> ReadItems(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    itemID = (int)dr["itemID"],
                    name = (string)dr["name"],
                    stock = (int)(dr["stock"]),
                    price = (double)(dr["price"]),
                    course = (string)dr["course"],
                    description = (string)dr["description"],
                    tax = (int)(dr["TAX"]),
                    foodtype = (string)dr["foodtype"]
                };
                items.Add(item);
            }
            return items;
        }
    }
}
