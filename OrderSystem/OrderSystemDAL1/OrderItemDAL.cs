using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;
using System.Data;

namespace OrderSystemDAL {
    public class OrderItemDAL : Base {
        ItemDAL itemDAL = new ItemDAL();

        public List<OrderItem> Db_Get_All_OrderItems(int orderID) {
            string query = "SELECT itemID, orderItemID, [status], amount, comment, timeOfOrder FROM [ORDER_CONTAINS] WHERE OrderID = @OrderID ORDER BY orderitemID ASC";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", orderID)
            };
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadOrderItems(DataTable dataTable) {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows) {
                OrderItem orderItem = new OrderItem();
                orderItem.item = itemDAL.Db_Get_Item(new Item { itemID = (int)dr["itemID"] });
                orderItem.ID = (int)dr["orderItemID"];
                orderItem.amount = (int)dr["amount"];
                orderItem.status = (OrderItem.Status)dr["status"];
                if (dr["comment"] == DBNull.Value) {
                    orderItem.comment = "";
                } else {
                    orderItem.comment = (string)dr["comment"];
                }
                orderItem.TimeOfOrder = (DateTime)dr["timeOfOrder"];
                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        //Adds items to orders
        public void AddItemsToOrder(Order order)
        {
            foreach (OrderItem orderItem in order.orderItems)
            {
                //Adds items to ORDER_CONTAINS
                
                    DateTime dateTime = DateTime.Now;
                    //Tries to insert new orderItem into database
                    string queryAddToOrder = "INSERT INTO [ORDER_CONTAINS] (orderID, itemID, amount, comment, timeOfOrder) VALUES (@orderID, @itemID, @amount, @comment, @time)";
                    SqlParameter[] sqlParametersAddOrderItem = new SqlParameter[]
                    {
                        new SqlParameter("@orderID", order.orderID),
                        new SqlParameter("@itemID", orderItem.item.itemID),
                        new SqlParameter("@amount", orderItem.amount),
                        new SqlParameter("@comment", orderItem.comment),
                        new SqlParameter("@time", dateTime)
                    };
                    ExecuteEditQuery(queryAddToOrder, sqlParametersAddOrderItem);

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
        public void UpdateOrderItems(OrderItem orderItem, int stockAmount)
        {
            //Updates the items in ORDER_CONTAINS
             string queryUpdateOrder = "UPDATE ORDER_CONTAINS set amount = @amount WHERE orderItemID = @orderItemID AND itemID = @itemID";
            SqlParameter[] sqlParametersUpdateOrder = new SqlParameter[]
            {
                    new SqlParameter("@amount", orderItem.amount),
                    new SqlParameter("@orderItemID", orderItem.ID),
                    new SqlParameter("@itemID", orderItem.item.itemID)
            };
            ExecuteEditQuery(queryUpdateOrder, sqlParametersUpdateOrder);

            //Updates stock in ITEMS
            string queryUpdateStock = "UPDATE ITEMS set stock = stock + @amount WHERE itemID = @itemID";
            SqlParameter[] sqlParametersUpdate = new SqlParameter[]
            {
                new SqlParameter("@amount", stockAmount),
                new SqlParameter("@itemID", orderItem.item.itemID),
            };
            ExecuteEditQuery(queryUpdateStock, sqlParametersUpdate);
        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            string query = "DELETE FROM ORDER_CONTAINS WHERE orderItemID = @orderItemID";
            SqlParameter[] sqlParameterRemoveItem = new SqlParameter[]
            {
                    new SqlParameter("@orderItemID", orderItem.ID)
            };
            ExecuteEditQuery(query, sqlParameterRemoveItem);

            string queryUpdateStock = "UPDATE ITEMS set stock = stock + @amount WHERE itemID = @itemID";
            SqlParameter[] sqlParametersUpdate = new SqlParameter[]
            {
                new SqlParameter("@amount", orderItem.amount),
                new SqlParameter("@itemID", orderItem.item.itemID),
            };
            ExecuteEditQuery(queryUpdateStock, sqlParametersUpdate);
        }
    }
}
