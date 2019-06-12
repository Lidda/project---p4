using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel
{
    public class OrderItem
    {
        public enum Status { ordered, ready, delivered };

        public int ID { get; set; }
        public Status status { get; set; } 
        public int amount { get; set; }
        public Item item { get; set; }
        public DateTime TimeOfOrder { get; set; }
        public string comment { get; set; }

        public double GetAmount(string priceType)
        {
            if (priceType == "Total")
            {
                //get total price 
                return item.price * amount;
            }
            else if (priceType == "Tax")
            {
                //get tax only
                return (item.price * amount) / (1 + (double)item.tax / 100) * ((double)item.tax / 100);
            }
            else if (priceType == "withoutTax")
            {
                //get price without taxes
                return item.price * amount / ((double)item.tax / 100 + 1);
            }
            else
            {
                //if no matches > return 0
                return 0;
            }
        }
    }
}

