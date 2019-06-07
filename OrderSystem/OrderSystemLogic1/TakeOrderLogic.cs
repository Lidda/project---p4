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

        public void AddItemsToOrder(List<OrderItem> orderItems)
        {
            try
            {
                takeOrder_db.AddItemsToOrder(orderItems);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }

        public void AddNewOrder(int employeeID, int tableID)
        {
            try
            {
                takeOrder_db.AddNewOrder(employeeID, tableID);
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
                throw new Exception("Something went wrong while removing order");
            }
        }

        public void RemoveItemsFromOrder(List<OrderItem> orderItems)
        {
            try
            {
                takeOrder_db.RemoveItemsFromOrder(orderItems);
            }
            catch
            {
                throw new Exception("Something went wrong while removing items");
            }
        }

        public int GetLatestOrderID()
        {
            try
            {
                return takeOrder_db.DB_Get_Latest_OrderID();
            }
            catch
            {
                throw new Exception("Something went wrong while retrieving orderID");
            }
        }
    }
}
