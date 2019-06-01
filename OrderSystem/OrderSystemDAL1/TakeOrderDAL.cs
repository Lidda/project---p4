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
                Item item = new Item() {
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
            string query= "INSERT INTO [ORDERS] (orderID, comment, employeeID, tableID) VALUES ((SELECT COALESCE(MAX(orderID)+1, 0) FROM [ORDERS]), @comment, @employeeID, @tableID)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@comment", order.comment),
                new SqlParameter("@employeeID", order.Employee.ID),
                new SqlParameter("@tableID", order.Table.ID),
            };
            ExecuteEditQuery(query, sqlParameters);
            
        }

        //Adds items to orders
        public void AddItemsToOrder(List<OrderItem> orderItems, Order order)
        {
            foreach (OrderItem orderItem in orderItems)
            {
                //Adds items to ORDER_CONTAINS
                string queryAddToOrder = "INSERT INTO [ORDERS_CONTAINS] (orderID, itemID, amount, comment, status) VALUES (@orderID, @itemID, @amount, @comment, Not ready)";
                SqlParameter[] sqlParametersAdd = new SqlParameter[]
                {
                    new SqlParameter("@orderID", order.orderID),
                    new SqlParameter("@itemID", orderItem.item.itemID),
                    new SqlParameter("@amount", orderItem.amount),
                    new SqlParameter("@comment", orderItem.comment),
                };
                ExecuteEditQuery(queryAddToOrder, sqlParametersAdd);

                //Updates stock in ITEMS
                string querySubtractFromStock = "UPDATE ITEMS set stock = stock - @amount WHERE itemID = @itemID";
                SqlParameter[] sqlParametersUpdate = new SqlParameter[]
                {
                    new SqlParameter("@amount", orderItem.amount),
                    new SqlParameter("@itemID", orderItem.item.itemID),
                };
                ExecuteEditQuery(querySubtractFromStock, sqlParametersUpdate);
            }
        }

        //Remove item(s) from an order
        public void RemoveItemsFromOrder(List<OrderItem> orderItems, Order order)
        {
            foreach (OrderItem orderItem in orderItems)
            {
                //Updates the items in ORDER_CONTAINS
                string queryUpdateOrder = "UPDATE ORDER_CONTAINS set amount - @amount WHERE itemID = @itemID AND orderID = @orderID";
                SqlParameter[] sqlParametersUpdateOrder = new SqlParameter[]
                {
                    new SqlParameter("@amount", orderItem.amount),
                    new SqlParameter("@itemID", orderItem.item.itemID),
                    new SqlParameter("@orderID", order.orderID),
                };
                ExecuteEditQuery(queryUpdateOrder, sqlParametersUpdateOrder);

                //Updates stock in ITEMS
                string querySubtractFromStock = "UPDATE ITEMS set stock = stock + @amount WHERE itemID = @itemID";
                SqlParameter[] sqlParametersUpdate = new SqlParameter[]
                {
                    new SqlParameter("@amount", orderItem.amount),
                    new SqlParameter("@itemID", orderItem.item.itemID),
                };
                ExecuteEditQuery(querySubtractFromStock, sqlParametersUpdate);
            }
        }

        //Removes an order from both ORDERS and ORDER_CONTAINS
        public void RemoveOrder(Order order)
        {
            string query = "DELETE FROM ORDERS, ORDER_CONTAINS WHERE orderID = @orderID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@orderID", order.orderID),
            };
            ExecuteSelectQuery(query, sqlParameters);
        }
    }
}
