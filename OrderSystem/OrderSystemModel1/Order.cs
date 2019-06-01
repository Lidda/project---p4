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
        public int employeeID { get; set; }
        public double tip = 0;
        public double totalAmount;
        public DateTime orderDate { get; set; }
        public string comment { get; set; }
        public Employee Employee { get; set; }
        public Table Table { get; set; }

        //list of ordered items
        public List<Item> items { get; set; }

        public Order()
        {
            items = new List<Item>();
        }
        public double GetTotalAmount(string priceType)
        {
            //get total amount,total taxes, prices without tax 
            double total = 0;
            foreach(Item item in items)
            {
                total = total + item.GetAmount(priceType);
            }
            if (priceType == "Total" && tip > 0)
            {
                total = total + tip;
            }
            return total;
        }
    }
}

