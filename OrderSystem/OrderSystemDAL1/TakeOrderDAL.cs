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
        //Get all drinks from ITEMS
        public List<Item> DB_Get_All_Beverages()
        {
            string query = "SELECT * FROM ITEMS WHERE course = 'Beverage'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetItems(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get all dinner items from ITEMS
        public List<Item> DB_Get_All_DinnerItems()
        {
            string query = "SELECT * FROM ITEMS WHERE foodtype = 'Dinner'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetItems(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get all Lunch items from ITEMS
        public List<Item> DB_Get_All_LunchItems()
        {
            string query = "SELECT * FROM [ITEMS] WHERE foodtype = 'Lunch'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetItems(ExecuteSelectQuery(query, sqlParameters));
        }

        //Gets all items of requisted type
        private List<Item> GetItems(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item() {
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

        //Gets latest order from ORDERS
        public int DB_Get_Latest_OrderID()
        {
            string query = "SELECT MAX(orderID) FROM ORDERS";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetOrderID(ExecuteSelectQuery(query, sqlParameters));
        }

        private int GetOrderID(DataTable dataTable)
        {
            int orderID = 0;
            orderID = (int)dataTable.Rows[0][0];
            
            return orderID;
        }

        //Adds new order to ORDERS table
        public void AddNewOrder(int employeeID, int tableID)
        {
            string query= "INSERT INTO [ORDERS] (employeeID, tableID) VALUES (@employeeID, @tableID)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@employeeID", employeeID),
                new SqlParameter("@tableID", tableID),
            };
            ExecuteEditQuery(query, sqlParameters);
            
        }

        //Adds items to orders
        public void AddItemsToOrder(List<OrderItem> orderItems)
        {
            foreach (OrderItem orderItem in orderItems)
            {
                //Adds items to ORDER_CONTAINS
                string queryAddToOrder = "INSERT INTO [ORDER_CONTAINS] (orderID, itemID, amount, comment) VALUES (@orderID, @itemID, @amount, @comment)";
                SqlParameter[] sqlParametersAdd = new SqlParameter[]
                {
                    // FIX ME new SqlParameter("@orderID", order.orderID),
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
        public void RemoveItemsFromOrder(List<OrderItem> orderItems)
        {
            foreach (OrderItem orderItem in orderItems)
            {
                //Updates the items in ORDER_CONTAINS
                string queryUpdateOrder = "UPDATE ORDER_CONTAINS set amount - @amount WHERE itemID = @itemID AND orderID = @orderID";
                SqlParameter[] sqlParametersUpdateOrder = new SqlParameter[]
                {
                    new SqlParameter("@amount", orderItem.amount),
                    new SqlParameter("@itemID", orderItem.item.itemID),
                    // FIX ME new SqlParameter("@orderID", order.orderID),
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
