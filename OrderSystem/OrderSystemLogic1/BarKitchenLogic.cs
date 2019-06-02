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


        public List<OrderItem> GetOrders()
        {
            try
            {
                List<OrderItem> OrderList = barkitchen_db.Db_Get_All_Orders();

                return OrderList;
            }
            catch (Exception)
           {

                throw new Exception("Something went wrong");
            }

        }
        public List<OrderItem> GetFoods()
        {
            try
            {
                List<OrderItem> OrderList = barkitchen_db.Db_Get_All_Foods();

                return OrderList;
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong");
            }

        }
        public List<OrderItem> GetDrinks()
        {
            try
            {
                List<OrderItem> OrderList = barkitchen_db.Db_Get_All_Drinks();

                return OrderList;
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong");
            }

        }


        public void OrderStatus(Order order, OrderItem.Status statusChange)
        {
            barkitchen_db.OrderStatus(order, statusChange);
        }


    }
}
