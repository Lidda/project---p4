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
    public class CheckoutDAL : Base
    {
        //get complete order (all items of all orders of a table)
        public List<Order> DB_Get_All_Orders(int tableID)
        {
            List<Order> orders = Db_Get_All_Orders_Private(tableID);

            foreach (Order order in orders)
            {
                //get all ordered items of this table
                order.items = DB_Get_All_Items_Private(order.orderID);
            }

            return orders;
        }
        //get items of order
        private List<Item> DB_Get_All_Items_Private(int orderID)
        {
            string query = "SELECT I.name, I.price, O.amount,I.TAX, O.comment, I.foodtype FROM ITEMS AS I JOIN ORDER_CONTAINS AS O ON I.itemID = O.itemID WHERE orderID = " + orderID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }
        //get orders from table
        private List<Order> Db_Get_All_Orders_Private(int tableID)
        {
            string query = "SELECT orderID, comment, employeeID, tableID FROM ORDERS WHERE tableID = " + tableID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }
        //
        private List<Item> ReadItems(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    name = (string)dr["name"],
                    price = (float)dr["price"],
                    amount = (int)dr["amount"],
                    tax = (int)dr["TAX"],
                    comment = (string)dr["comment"],
                    foodtype = (string)dr["foodtype"]
                };
                items.Add(item);
            }
            return items;
        }
        //
        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    orderID = (int)dr["orderID"],
                    comment = (string)dr["comment"],
                    employeeID = (int)dr["employeeID"],
                    tableID = (int)dr["tableID"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}

