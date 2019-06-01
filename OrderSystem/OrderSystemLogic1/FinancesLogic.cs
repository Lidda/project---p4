using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemModel;
using OrderSystemDAL;

namespace OrderSystemLogic
{
    public class FinancesLogic
    {
        FinancesDAL financesDAL = new FinancesDAL();

        public List<Profit> GetAllFinances()
        {
            try
            {
                return financesDAL.GetAllOrders();
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
                return financesDAL.GetMonthlyProfits();
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
                return financesDAL.GetYearlyProfits();
            }
            catch
            {
                throw new Exception("Could not get yearly profit from database");
            }
        }
    }
}
