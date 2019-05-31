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

        public List<DailyProfit> GetAllFinances()
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
    }
}
