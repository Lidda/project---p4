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

        public Status status { get; set; } 
        public int amount { get; set; }
        public Item item { get; set; }
        public DateTime TimeOfOrder { get; set; }
        public string comment { get; set; }

        public double GetAmount(string priceType)
        {
            if (priceType == "Total")
            {
                //get total price * amount
                return item.price * amount;
            }
            else if (priceType == "Tax")
            {
                //get tax only
                return (item.price * amount) / (1 + (double)item.tax / 100) * ((double)item.tax / 100);
            }
            else if (priceType == "withoutTax")
            {
                return item.price * amount / ((double)item.tax / 100 + 1);
            }
            else
            {
                //if not matches > return 0
                return 0;
            }
        }
    }
}

