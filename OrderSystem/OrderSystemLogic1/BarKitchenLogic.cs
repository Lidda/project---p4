using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemDAL;
using OrderSystemModel;

namespace OrderSystemLogic
{
    public class BarKitchenLogic
    {
        BarKitchenDAL barkitchen_db = new BarKitchenDAL();


        public List<Order> GetOrders()
        {
            try
            {

                List<Order> OrderList = barkitchen_db.Db_Get_All_Orders();

                return OrderList;
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong");
            }

        }


        public void OrderStatus(int statusChange)
        {
            barkitchen_db.OrderStatus(statusChange);
        }


    }
}
