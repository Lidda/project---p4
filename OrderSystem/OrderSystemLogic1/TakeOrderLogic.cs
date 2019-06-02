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

        //Gets all drinks from Items
        public List<Item> GetBeverages()
        {
            try
            {
                return takeOrder_db.DB_Get_All_Beverages();
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }

        //Gets all dinner items from Items
        public List<Item> GetDinnerItems()
        {
            try
            {
                return takeOrder_db.DB_Get_All_DinnerItems();
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }

        //Gets all lunch items from Items
        public List<Item> GetLunchItems()
        {
            try
            {
                return takeOrder_db.DB_Get_All_LunchItems();
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }

        public void AddItemsToOrder(List<OrderItem> orderItems, Order order)
        {
            try
            {
                takeOrder_db.AddItemsToOrder(orderItems, order);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }

        public void AddNewOrder(Order order)
        {
            try
            {
                takeOrder_db.AddNewOrder(order);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }

        public void RemoveOrder(Order order)
        {
            try
            {
                takeOrder_db.RemoveOrder(order);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }

        public void RemoveItemsFromOrder(List<OrderItem> orderItems, Order order)
        {
            try
            {
                takeOrder_db.RemoveItemsFromOrder(orderItems, order);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}
