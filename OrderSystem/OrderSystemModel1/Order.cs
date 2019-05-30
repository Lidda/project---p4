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
        public int tableID { get; set; }
        public int employeeID { get; set; }
        public string comment
        {
            get
            {
                return comment;
            }
            set
            {
                //check if value is not null before assigning it
                if (value != null)
                {
                    comment = value;
                }
                else
                {
                    comment = "";
                }
            }
        }
        public Employee Employee { get; set; }
        public Table Table { get; set; }

        //list of ordered items
        public List<Item> items { get; set; }

        public Order()
        {
            items = new List<Item>();
        }
    }
}

