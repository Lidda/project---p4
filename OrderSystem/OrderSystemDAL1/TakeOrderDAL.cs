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
    public class TakeOrderDAL : Base
    {
        public List<Item> DB_Get_All_Items()
        {
            string query = "SELECT * FROM ITEMS";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Item> GetItems(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    itemID = (int)dr["itemID"],
                    name = (string)dr["name"],
                    price = (float)dr["price"],
                    stock = (int)dr["stock"],
                    course = (string)dr["course"],
                    description = (string)dr["description"],
                    tax = (int)dr["TAX"],
                    foodtype = (string)dr["foodtype"]
                };
                items.Add(item);
            }
            return items;
        }

        //Adds new order to ORDERS table
        public void AddNewOrder(Order order)
        {
            string query = "INSERT INTO [ORDERS] (orderID, comment, employeeID, tableID) VALUES ((SELECT COALESCE(MAX(orderID)+1, 0) FROM [ORDERS]), @comment, @employeeID, @tableID)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@comment", order.comment),
                new SqlParameter("@employeeID", order.employeeID),
                new SqlParameter("@tableID", order.tableID),
            };
            ExecuteSelectQuery(query, sqlParameters);
        }

        //Adds items to orders
        public void DB_AddItemsToOrder(List<Item> items, Order order)
        {
            foreach (Item item in items)
            {
                string query = "INSERT INTO [ORDERS_CONTAINS] (orderID, itemID, amount, comment, status) VALUES (@orderID, @itemID, @amount, @comment, Not ready)";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@orderID", order.orderID),
                    new SqlParameter("@itemID", item.itemID),
                    new SqlParameter("@amount", item.amount),
                    new SqlParameter("@comment", item.comment),
                };
                ExecuteSelectQuery(query, sqlParameters);
            }
        }
    }
}
