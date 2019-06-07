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

        public List<Order> Db_Get_All_Orders()
        {
            string query = "SELECT OrderID, comment, employeeID, tableID, paymentStatus, DateOrdered, TotalAmount FROM [ORDERS]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
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
                order.orderItems = orderItemDAL.Db_Get_All_OrderItems((int)dr["OrderID"]);
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

        //Query to get all food for kitchen
        public List<Order> Db_Get_All_Foods(int tableID)
        {
            string query = "SELECT ORDER_CONTAINS.orderID, ORDER_CONTAINS.timeOfOrder, ORDER_CONTAINS.itemID, ORDER_CONTAINS.amount, ORDER_CONTAINS.status,ORDERS.tableID, ITEMS.name, items.foodtype  FROM ORDER_CONTAINS LEFT JOIN ORDERS ON ORDER_CONTAINS.orderID = ORDERS.orderID LEFT JOIN ITEMS ON ITEMS.itemID = ORDER_CONTAINS.itemID WHERE order_contains.status = 0 AND orders.tableID = ('" + tableID + "') AND items.foodtype LIKE '%Dinner' OR items.foodtype LIKE '%Lunch' AND status = 0 AND orders.tableID =" + tableID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadFoodOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        //Query to update status of order
        public void ChangeOrderStatus(int tableID, OrderItem.Status status, OrderItem.Status statusChange)
        {
            string query = "UPDATE ORDER_CONTAINS SET ORDER_CONTAINS.[status] = " + (int)statusChange + " FROM ORDER_CONTAINS INNER JOIN ORDERS ON ORDER_CONTAINS.orderID = ORDERS.orderID WHERE ORDERS.TABLEID = " + tableID + " AND ORDER_CONTAINS.[status] = " + (int)status + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Order> ReadFoodOrders(DataTable dataTable)
        {
            List<Order> FoodOrders = new List<Order>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order();

                {
                    order.Table.ID = (int)dr["tableID"];
                    order.orderItem.TimeOfOrder = (DateTime)dr["timeOfOrder"];
                    order.orderItem.item.name = (string)dr["name"];
                    order.orderItem.item.foodtype = (string)dr["foodtype"];
                    order.orderItem.amount = (int)dr["amount"];
                    order.orderItem.status = (Status)dr["status"];
                };
                FoodOrders.Add(order);
            }
            return FoodOrders;
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


    }
}
