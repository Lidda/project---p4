using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;
using System.Data;

namespace OrderSystemDAL {
    public class OrderDAL : Base {
        OrderItemDAL orderItemDAL = new OrderItemDAL();
        EmployeeDAL employeeDAL = new EmployeeDAL();
        TableDAL tableDAL = new TableDAL();

        public Order Db_Get_Order(Order order) {
            string query = "SELECT comment, employeeID, tableID, paymentStatus, DateOrdered, TotalAmount FROM [ORDERS] WHERE OrderID = @OrderID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            { 
                new SqlParameter("@OrderID", order.orderID)
            };
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        private List<Order> ReadOrders(DataTable dataTable) {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows) {
                Order order = new Order() {
                    orderItems = orderItemDAL.Db_Get_All_OrderItems(new Order { orderID = (int)dr["OrderID"] }),
                    Employee = employeeDAL.Db_Get_Employee((int)dr["EmployeeID"]),
                    Table = tableDAL.DbGetTableByID((int)dr["tableID"]),
                    comment = (string)dr["comment"],
                    PaymentStatus = (bool)dr["PaymentStatus"],
                    totalAmount = (double)dr["TotalAmount"]
                };
                orders.Add(order);
            }
            return orders;
        }
    }
}
