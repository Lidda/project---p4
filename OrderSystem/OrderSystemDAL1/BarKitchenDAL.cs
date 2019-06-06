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
    public class BarKitchenDAL : Base {
        //Query to get all orders
        public List<OrderItem> Db_Get_All_Orders() {
            string query = "SELECT ORDER_CONTAINS.orderID, ORDER_CONTAINS.itemID, ORDER_CONTAINS.amount, ORDER_CONTAINS.status,ORDERS.tableID, ITEMS.name, items.foodtype  FROM ORDER_CONTAINS LEFT JOIN ORDERS ON ORDER_CONTAINS.orderID = ORDERS.orderID LEFT JOIN ITEMS ON ITEMS.itemID = ORDER_CONTAINS.itemID WHERE STATUS = 0 ORDER BY tableID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }
        //Query to get all food for kitchen
        public List<OrderItem> Db_Get_All_Foods(int tableID) {
            string query = "SELECT ORDER_CONTAINS.orderID, ORDER_CONTAINS.timeOfOrder, ORDER_CONTAINS.itemID, ORDER_CONTAINS.amount, ORDER_CONTAINS.status,ORDERS.tableID, ITEMS.name, items.foodtype  FROM ORDER_CONTAINS LEFT JOIN ORDERS ON ORDER_CONTAINS.orderID = ORDERS.orderID LEFT JOIN ITEMS ON ITEMS.itemID = ORDER_CONTAINS.itemID WHERE order_contains.status = 0 AND orders.tableID = ('" + tableID + "') AND items.foodtype LIKE '%Dinner' OR items.foodtype LIKE '%Lunch' AND status = 0 AND orders.tableID =" + tableID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }
        //Query to get all drinks for Bar
        public List<OrderItem> Db_Get_All_Drinks(int tableID) {
            string query = "SELECT ORDER_CONTAINS.orderID, ORDER_CONTAINS.timeOfOrder, ORDER_CONTAINS.itemID, ORDER_CONTAINS.amount, ORDER_CONTAINS.status,ORDERS.tableID, ITEMS.name, items.foodtype  FROM ORDER_CONTAINS LEFT JOIN ORDERS ON ORDER_CONTAINS.orderID = ORDERS.orderID LEFT JOIN ITEMS ON ITEMS.itemID = ORDER_CONTAINS.itemID WHERE order_contains.status = 0 AND orders.tableID = ('" + tableID + "') AND items.foodtype LIKE '%Liquor' OR items.foodtype LIKE '%Beverages' AND status = 0 AND  tableID = " + tableID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        //Query to update status of order
        public void OrderStatus(int tableID, int statusChange) {
            string query = "UPDATE ORDER_CONTAINS SET ORDER_CONTAINS.status =( '" + statusChange + "') FROM ORDER_CONTAINS INNER JOIN ORDERS ON ORDER_CONTAINS.orderID = ORDERS.orderID WHERE ORDERS.TABLEID = ( '" + tableID + "')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<OrderItem> ReadOrders(DataTable dataTable) {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows) {
                OrderItem orderItem = new OrderItem() {
                    //tableID = (int)dr["tableID"],
                    //orderID = (int)dr["orderID"],
                    //itemID = (int)dr["itemID"],
                    TimeOfOrder = (DateTime)dr["timeOfOrder"],
                    // order.orderitem.item.name = (string)dr["name"],
                    // order.orderitem.item.foodtype = (string)dr["foodtype"],
                    amount = (int)dr["amount"],
                    status = (Status)dr["status"]
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
    }
}
