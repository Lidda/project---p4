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
    public class OrderDAL : Base
    {
        OrderItemDAL orderItemDAL = new OrderItemDAL();
        EmployeeDAL employeeDAL = new EmployeeDAL();
        TableDAL tableDAL = new TableDAL();

        public Order Db_Get_Order(Order order)
        {
            string query = "SELECT orderID, comment, employeeID, tableID, paymentStatus, DateOrdered, TotalAmount FROM [ORDERS] WHERE OrderID = @OrderID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@OrderID", order.orderID)
            };
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        public List<Order> Db_Get_All_Orders() {
            string query = "SELECT OrderID, comment, employeeID, tableID, paymentStatus, DateOrdered, TotalAmount FROM [ORDERS]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        //gets an order from a specific date: used to cut down on unnecessary database traffic
        public List<Order> Db_Get_Orders_By_Date(DateTime date) {
            string query = "SELECT OrderID, comment, employeeID, tableID, paymentStatus, DateOrdered, TotalAmount FROM [ORDERS] WHERE DateOrdered = @date";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@date", date)
            };
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Order> ReadOrders(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order();
                order.orderID = (int)dr["OrderID"];
                order.orderDate = (DateTime)dr["DateOrdered"];
                order.orderItems = orderItemDAL.Db_Get_All_OrderItems((int)dr["orderID"]);
                order.Employee = employeeDAL.Db_Get_Employee((int)dr["EmployeeID"]);
                order.Table = tableDAL.DbGetTableByID((int)dr["tableID"]);
                if (dr["comment"] == DBNull.Value)
                {
                    order.comment = "";
                }
                else
                {
                    order.comment = (string)dr["comment"];
                }
                order.PaymentStatus = (bool)dr["PaymentStatus"];
                order.totalAmount = (double)dr["TotalAmount"];

                orders.Add(order);
            }
            return orders;
        }

        //begin kitchen and bar orders

        public List<Order> GetOrdersBar(int tableID) {
            string query = "SELECT O.OrderID,  O.comment, O.employeeID, O.tableID, O.paymentStatus, O.DateOrdered, O.TotalAmount FROM [ORDERS] AS O JOIN ORDER_CONTAINS AS C ON o.orderID = c.orderID JOIN ITEMS AS I ON C.itemID = I.itemID WHERE c.status = 0 AND o.tableID = " + tableID + " AND i.course LIKE '%drank'";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> GetOrdersKitchen(int tableID)
        {
            string query = "SELECT O.OrderID, O.comment, O.employeeID, O.tableID, O.paymentStatus, O.DateOrdered, O.TotalAmount FROM [ORDERS] AS O JOIN ORDER_CONTAINS AS C ON o.orderID = c.orderID JOIN ITEMS AS I ON C.itemID = I.itemID WHERE c.status = 0 AND o.tableID = " + tableID + " AND i.foodtype LIKE '%Dinner'  OR i.foodtype LIKE '%Lunch' AND status = 0 AND o.tableID =" + tableID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }


        //Query to update status of order
        public void ChangeOrderStatus(int tableID, OrderItem.Status status, OrderItem.Status statusChange)
        {
            string query = "UPDATE ORDER_CONTAINS SET ORDER_CONTAINS.[status] = " + (int)statusChange + " FROM ORDER_CONTAINS INNER JOIN ORDERS ON ORDER_CONTAINS.orderID = ORDERS.orderID WHERE ORDERS.TABLEID = " + tableID + " AND ORDER_CONTAINS.[status] = " + (int)status + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        
        //end kitchen and bar orders

        //begin profits
        public List<Profit> GetDailyProfits()
        {
            string query = "SELECT DateOrdered AS Date, SUM(TotalAmount) AS Total FROM [ORDERS] GROUP BY DateOrdered";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadDailyProfits(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Profit> GetMonthlyProfits()
        {
            string query = "SELECT MONTH(DateOrdered) AS Month, YEAR(DateOrdered) AS Year, SUM(TotalAmount) AS Total FROM [ORDERS] GROUP BY MONTH(DateOrdered), YEAR(DateOrdered)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMonthlyProfits(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Profit> GetYearlyProfits()
        {
            string query = "SELECT YEAR(DateOrdered) AS Date, SUM(TotalAmount) AS Total FROM [ORDERS] GROUP BY YEAR(DateOrdered)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadYearlyProfits(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Profit> ReadDailyProfits(DataTable dataTable)
        {
            List<Profit> days = new List<Profit>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Profit day = new Profit()
                {
                    date = (DateTime)dr["Date"],
                    DayIncome = (double)(dr["Total"]),
                };
                days.Add(day);
            }
            return days;
        }

        private List<Profit> ReadMonthlyProfits(DataTable dataTable)
        {
            List<Profit> months = new List<Profit>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Profit month = new Profit()
                {
                    date = DateTime.Parse("01/" + dr["Month"].ToString() + "/" + dr["Year"].ToString()),
                    DayIncome = (double)(dr["Total"]),
                };
                months.Add(month);
            }
            return months;
        }

        private List<Profit> ReadYearlyProfits(DataTable dataTable)
        {
            List<Profit> years = new List<Profit>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Profit year = new Profit()
                {
                    date = DateTime.Parse("01/01/" + dr["Date"]),
                    DayIncome = (double)(dr["Total"]),
                };
                years.Add(year);
            }
            return years;
        }
        // eind profits

        //begin afrekenen
        //
        //get unpaid order of today
        public Order Db_Get_Table_Order(Table table)
        {
            string query = "SELECT orderID, comment, employeeID, tableID, paymentStatus, DateOrdered, TotalAmount FROM [ORDERS] WHERE TableID = @tableID AND PaymentStatus = 0";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@tableID", table.ID)
            };
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters))[0];
        }
        //set order to paid
        public void SetOrderToPaid(Order order)
        {
            //set to paid
            string query = "UPDATE ORDERS SET PaymentStatus = 1, TotalAmount = @totalAmount WHERE orderID = @orderID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@totalAmount", order.GetTotalAmount("Total").ToString().Replace(',', '.')),
                new SqlParameter("@orderID", order.orderID)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        // Add comment to order
        public void EditOrderComment(Order order)
        {
            string query = "UPDATE ORDERS SET comment = @comment WHERE orderID = @orderID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@comment", order.comment),
                new SqlParameter("@orderID", order.orderID)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        //einde afrekenen queries

        //Adds new order to ORDERS
        public void AddNewOrder(Order order)
        {
            string query = "INSERT INTO [ORDERS] (employeeID, tableID) VALUES (@employeeID, @tableID)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@employeeID", order.Employee.ID),
                new SqlParameter("@tableID", order.Table.ID),
            };
            ExecuteEditQuery(query, sqlParameters);

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

        public Order DB_Get_Latest_Order()
        {
            string query = "SELECT * FROM ORDERS WHERE orderID = (SELECT MAX(orderID) FROM ORDERS)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetOrder(ExecuteSelectQuery(query, sqlParameters));
        }

        private Order GetOrder(DataTable dataTable)
        {
            Order order = new Order();
            order.orderID = (int)dataTable.Rows[0]["OrderID"];
            order.orderDate = (DateTime)dataTable.Rows[0]["DateOrdered"];
            order.orderItems = orderItemDAL.Db_Get_All_OrderItems((int)dataTable.Rows[0]["OrderID"]);
            order.Employee = employeeDAL.Db_Get_Employee((int)dataTable.Rows[0]["EmployeeID"]);
            order.Table = tableDAL.DbGetTableByID((int)dataTable.Rows[0]["tableID"]);
            if (dataTable.Rows[0]["comment"] == DBNull.Value)
            {
                order.comment = "";
            }
            else
            {
                order.comment = (string)dataTable.Rows[0]["comment"];
            }
            order.PaymentStatus = (bool)dataTable.Rows[0]["PaymentStatus"];
            order.totalAmount = (double)dataTable.Rows[0]["TotalAmount"];

            return order;
        }
    }
}
