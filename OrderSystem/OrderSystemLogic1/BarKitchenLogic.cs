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

        //get all orders
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
        //get all foods
        public List<OrderItem> GetFoods(int tableID)
        {
            try
            {
                List<OrderItem> OrderList = barkitchen_db.Db_Get_All_Foods(tableID);

                return OrderList;
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong");
            }

        }
        //get all drinks
        public List<OrderItem> GetDrinks(int tableID)
        {
            try
            {
                List<OrderItem> OrderList = barkitchen_db.Db_Get_All_Drinks(tableID);

                return OrderList;
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong");
            }

        }

        //change status
        public void OrderStatus(int tableID, int statusChange)
        {
            barkitchen_db.OrderStatus(tableID, statusChange);
        }


    }
}
