using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemModel;
using OrderSystemDAL;

namespace OrderSystemLogic
{
    public class OrderLogic
    {
        OrderDAL orderDAL = new OrderDAL();

        public Order get_Order(Order order)
        {
            try
            {
                return orderDAL.Db_Get_Order(order);
            }
            catch
            {
                throw new Exception("Could not get order from database");
            }
        }

        public List<Order> Get_All_Orders()
        {
            try
            {
                return orderDAL.Db_Get_All_Orders();
            }
            catch
            {
               throw new Exception("Could not get orders from database");
            }
        }

        public List<Order> GetFoodOrders(int tableID)
        {
            try
            {
                List<Order> OrderList = orderDAL.Db_Get_All_Foods(tableID);

                return OrderList;
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong");
            }

        }

        public void ChangeOrderStatus(int tableID, OrderItem.Status status, OrderItem.Status statusChange)
        {
            orderDAL.ChangeOrderStatus(tableID, status, statusChange);
        }

        public List<Profit> DailyProfit()
        {
            try
            {
                return orderDAL.GetDailyProfits();
            }
            catch
            {
                throw new Exception("Could not get daily profits from database");
            }
        }

        public List<Profit> MonthlyProfit()
        {
            try
            {
                return orderDAL.GetMonthlyProfits();
            }
            catch
            {
                throw new Exception("Could not get monthly profits from database");
            }
        }

        public List<Profit> YearlyProfit()
        {
            try
            {
                return orderDAL.GetYearlyProfits();
            }
            catch
            {
                throw new Exception("Could not get yearly profits from database");
            }
        }

        public void Set_Order_To_Paid(Order order)
        {
            try
            {
                orderDAL.SetOrderToPaid(order);
            }
            catch
            {
                throw new Exception("something went wrong");
            }
        }
        public void Edit_Order_Comment(Order order)
        {
            try
            {
                orderDAL.EditOrderComment(order);
            }
            catch
            {
                throw new Exception("something went wrong");
            }
        }

        public void AddNewOrder(Order order)
        {
            try
            {
                orderDAL.AddNewOrder(order);
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
                orderDAL.RemoveOrder(order);
            }
            catch
            {
                throw new Exception("Something went wrong while removing order");
            }
        }

        public Order GetLatestOrderID()
        {
            try
            {
                return orderDAL.DB_Get_Latest_Order();
            }
            catch
            {
                throw new Exception("Something went wrong while retrieving orderID");
            }
        }
    }
}
