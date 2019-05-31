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
        TakeOrderDAL takeOrder_db = new TakeOrderDAL();

        //Get all items
        public List<ItemModel> GetAllItems()
        {
            try
            {
                return takeOrder_db.DB_Get_All_Items();
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }

        public void AddItemsToOrder(List<ItemModel> items, OrderModel order)
        {
            try
            {
                takeOrder_db.DB_AddItemsToOrder(items, order);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}
