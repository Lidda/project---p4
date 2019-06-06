using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemModel;
using OrderSystemDAL;

namespace OrderSystemLogic
{
    public class OrderLogic
    {
        OrderDAL orderDAL = new OrderDAL();








        public List<Profit> DailyProfit()
        {
            try
            {
                return orderDAL.GetDailyProfits();
            }
            catch
            {
                throw new Exception("Could not get orders from database");
            }
        }

        public List<Profit> MonthlyProfit()
        {
            try
            {
                return orderDAL.GetMonthlyProfits();
            }
            catch
            {
                throw new Exception("Could not get monthly profit from database");
            }
        }

        public List<Profit> YearlyProfit()
        {
            try
            {
                return orderDAL.GetYearlyProfits();
            }
            catch
            {
                throw new Exception("Could not get yearly profit from database");
            }
        }
    }
}
