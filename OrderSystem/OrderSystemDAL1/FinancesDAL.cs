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
    public class FinancesDAL : Base
    {
        public List<Profit> GetAllOrders()
        {
            string query = "SELECT DateOrdered AS Date, SUM(TotalAmount) AS Total FROM [ORDERS] GROUP BY DateOrdered";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));         
        }

        public List<Profit> GetMonthlyProfits()
        {
            string query = "SELECT MONTH(DateOrdered) AS Month, YEAR(DateOrdered) AS Year, SUM(TotalAmount) AS Total FROM [ORDERS] GROUP BY MONTH(DateOrdered), YEAR(DateOrdered)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMonthlyOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Profit> GetYearlyProfits()
        {
            string query = "SELECT YEAR(DateOrdered) AS Date, SUM(TotalAmount) AS Total FROM [ORDERS] GROUP BY YEAR(DateOrdered)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadYearlyOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Profit> ReadOrders(DataTable dataTable)
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

        private List<Profit> ReadYearlyOrders(DataTable dataTable)
        {
            List<Profit> days = new List<Profit>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Profit day = new Profit()
                {
                    date = DateTime.Parse("01/01/" + dr["Date"]),
                    DayIncome = (double)(dr["Total"]),
                };
                days.Add(day);
            }
            return days;
        }

        private List<Profit> ReadMonthlyOrders(DataTable dataTable)
        {
            List<Profit> days = new List<Profit>();

            foreach (DataRow dr in dataTable.Rows)
            {

                Profit day = new Profit()
                {
                    date = DateTime.Parse("01/" + dr["Month"].ToString() + "/" + dr["Year"].ToString()),
                    DayIncome = (double)(dr["Total"]),
                };
                days.Add(day);
            }
            return days;
        }
    }
}
