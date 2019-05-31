using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemModel;
using OrderSystemDAL;

namespace OrderSystemLogic
{
    public class ItemLogic
    {
        ItemDAL itemDAL = new ItemDAL();
        public List<Item> GetAllItems()
        {
            try
            {
                return itemDAL.Db_Get_All_Items();
            }
            catch
            {
                throw new Exception("Could not get items from database");
            }
        }
    }
}
