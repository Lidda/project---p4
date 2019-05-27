using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemDAL;
using OrderSystemModel;

namespace OrderSystemLogic
{
    public class TakeOrderLogic
    {
        TakeOrderDAL takeOrderDAL = new TakeOrderDAL();

        //Get all items
        public List<Item> GetAllItems()
        {
            try
            {
                return takeOrderDAL.DB_Get_All_Items();
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}
