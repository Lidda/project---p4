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
    public class BarKitchenDAL : Base {
        public List<Order> Db_Get_All_Orders() {
            string query = "Select o.orderID, o.employeeID, o.tableid, i.itemID, i.status FROM ORDERS AS O JOIN ORDER_CONTAINS AS I ON o.orderID = i.orderID ORDER BY o.tableID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        //Updates the status order by order.orderID
        public void OrderStatus(Order order, OrderItem.Status statusChange) {
            string query = "UPDATE [ORDER_CONTAINS] SET [status] = ( '" + statusChange + "') WHERE ORDERID = ( '" + order.orderID + "')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Order> ReadOrders(DataTable dataTable) {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows) {
                Order order = new Order() {
                    orderID = (int)dr["orderID"],
                    employeeID = (int)dr["employeeID"],
                };
                orders.Add(order);
            }
            return orders;
        }

    }
}
