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
        public List<DailyProfit> GetAllOrders()
        {
            string query = "SELECT DateOrdered, SUM(TotalAmount) AS DayTotal FROM [ORDERS] GROUP BY DateOrdered";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));         
        }

        private List<DailyProfit> ReadOrders(DataTable dataTable)
        {
            List<DailyProfit> days = new List<DailyProfit>();

            foreach (DataRow dr in dataTable.Rows)
            {
                DailyProfit day = new DailyProfit()
                {
                    date = (DateTime)dr["DateOrdered"],
                    DayIncome = (double)(dr["DayTotal"]),
                };
                days.Add(day);
            }
            return days;
        }
    }
}
