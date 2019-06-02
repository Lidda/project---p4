using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;
using System.Data;
using static OrderSystemModel.OrderItem;

namespace OrderSystemDAL
{
    public class BarKitchenDAL : Base
    {
        public List<OrderItem> Db_Get_All_Orders()
        {
            string query = "SELECT ORDER_CONTAINS.orderID, ORDER_CONTAINS.itemID, ORDER_CONTAINS.amount, ORDER_CONTAINS.status,ORDERS.tableID, ITEMS.name, items.foodtype  FROM ORDER_CONTAINS LEFT JOIN ORDERS ON ORDER_CONTAINS.orderID = ORDERS.orderID LEFT JOIN ITEMS ON ITEMS.itemID = ORDER_CONTAINS.itemID ORDER BY tableID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }


        //Updates the status order by order.orderID
        public void OrderStatus(Order order, OrderItem.Status statusChange)
        {
            string query = "UPDATE [ORDER_CONTAINS] SET [status] = ( '" + statusChange + "') WHERE ORDERID = ( '" + order.orderID + "')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<OrderItem> ReadOrders(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                   
                    tableID = (int)dr["tableID"],
                    orderID = (int)dr["orderID"],
                    itemID = (int)dr["itemID"],
                    name = (string)dr["name"],
                    foodtype = (string)dr["foodtype"],
                    amount = (int)dr["amount"],
                    status = (Status)dr["status"]

                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }



    }
}
