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
                Order order = new Order()
                {
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
