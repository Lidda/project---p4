using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel
{
    public class Order
    {
        public int orderID { get; set; } //e.g. 1
        public double tip = 0;
        public double totalAmount;
        public DateTime orderDate { get; set; }
        public string comment { get; set; }
        public Employee Employee { get; set; }
        public Table Table { get; set; }
        public bool PaymentStatus { get; set; }
        public OrderItem orderItem { get; set; }

        //list of ordered items
        public List<OrderItem> orderItems { get; set; }

        public Order()
        {
            orderItems = new List<OrderItem>();
        }

        public double GetTotalAmount(string priceType)
        {
            //get total amount, total taxes or prices without tax 
            double total = 0;
            foreach(OrderItem i in orderItems)
            {
                total = total + i.GetAmount(priceType);
            }
            if (priceType == "Total" && tip > 0)
            {
                total = total + tip;
            }
            return total;
        }
    }
}
