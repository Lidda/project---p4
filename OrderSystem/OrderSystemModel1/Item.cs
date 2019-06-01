using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel
{
    public class Item
    {
        public int itemID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int tax { get; set; }
        public string foodtype { get; set; }
        public int amount { get; set; }
        public int stock { get; set; }
        public string course { get; set; }
        public string description { get; set; }

        public string comment { get; set; }

        public double GetAmount(string priceType)
        {
            if (priceType == "Total")
            {
                //get total price * amount
                return price * amount;
            }
            else if (priceType == "Tax")
            {
                //get tax only
                return (price * amount) / (1 + (double)tax / 100) * ((double)tax / 100);
            }
            else if (priceType == "withoutTax")
            {
                return price * amount / ((double)tax / 100 + 1);
            }
            else
            {
                //if not matches > return 0
                return 0;
            }
        }
    }
}

