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
            string query = "SELECT itemID, [status], amount, comment, timeOfOrder FROM [ORDER_CONTAINS] WHERE OrderID = @OrderID";
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

        public void ChangeOrderItemStatus() {

        }

        //Adds items to orders
        public void AddItemsToOrder(Order order)
        {
            foreach (OrderItem orderItem in order.orderItems)
            {
                //Adds items to ORDER_CONTAINS
                try
                {
                    //Tries to insert new orderItem into database
                    string queryAddToOrder = "INSERT INTO [ORDER_CONTAINS] (orderID, itemID, amount, comment) VALUES (@orderID, @itemID, @amount, @comment)";
                    SqlParameter[] sqlParametersAdd = new SqlParameter[]
                    {
                        new SqlParameter("@itemID", orderItem.item.itemID),
                        new SqlParameter("@amount", orderItem.amount),
                        new SqlParameter("@comment", orderItem.comment),
                    };
                    ExecuteEditQuery(queryAddToOrder, sqlParametersAdd);
                }
                catch
                {
                    //Updates the orderItem amount and comment if inserting fails
                    string queryUpdateOrder = "UPDATE [ORDER_CONTAINS] SET amount = amount + @amount, comment = @comment WHERE itemID = @itemID AND orderID = @orderID)";
                    SqlParameter[] sqlParametersUpdateOrderItem = new SqlParameter[]
                    {
                        new SqlParameter("@itemID", orderItem.item.itemID),
                        new SqlParameter("@amount", orderItem.amount),
                        new SqlParameter("@comment", orderItem.comment),
                    };
                    ExecuteEditQuery(queryUpdateOrder, sqlParametersUpdateOrderItem);
                }

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
    }
}
