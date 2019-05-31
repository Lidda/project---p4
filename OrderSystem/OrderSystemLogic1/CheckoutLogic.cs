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
        public OrderModel GetOrder(TableModel table, EmployeeModel employee)
        {
            try
            {
                return checkout_db.DB_Get_Order(table, employee);
            }
            catch
            {
                throw new Exception("Couldn't connect to the database");
            }
        }

        //add comment
        public void AddComment(OrderModel order)
        {
            try
            {
                checkout_db.AddCommentToOrder(order);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
        //set order to paid
        public void SetToPaid(OrderModel order, float Tip)
        {
            try
            {
                checkout_db.SetOrderToPaid(order, Tip);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }
    }
}

