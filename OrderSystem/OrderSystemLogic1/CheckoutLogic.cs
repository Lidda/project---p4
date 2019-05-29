using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemDAL;
using OrderSystemModel;

namespace OrderSystemLogic
{
    public class CheckoutLogic
    {
        CheckoutDAL checkout_db = new CheckoutDAL();

        //get all orders (+ ordered items)
        public List<Order> GetAllOrders(int tableID)
        {
            try
            {
                return checkout_db.DB_Get_All_Orders(tableID);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }
        //set order(s) to paid
        public void SetToPaid(int tableID)
        {
            try
            {
                checkout_db.SetOrderToPaid(tableID);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}

