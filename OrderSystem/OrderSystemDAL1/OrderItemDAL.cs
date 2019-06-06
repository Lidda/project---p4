using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;
using System.Data;

namespace OrderSystemDAL {
    public class OrderItemDAL : Base{
        ItemDAL itemDAL = new ItemDAL();

        public List<OrderItem> Db_Get_All_OrderItems(Order order) {
            string query = "SELECT itemID, status, amount, comment, timeOfOrder FROM [ORDER_CONTAINS] WHERE OrderID = @OrderID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", order.orderID)
            };
            return ReadOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> ReadOrderItems(DataTable dataTable) {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows) {
                OrderItem orderItem = new OrderItem() {
                     item = itemDAL.Db_Get_Item(new Item { itemID = (int)dr["itemID"] }),
                     amount = (int)dr["amount"],
                     status = (OrderItem.Status)dr["status"],
                     comment = (string)dr["comment"],
                     TimeOfOrder = (DateTime)dr["timeOfOrder"]
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
    }
}
