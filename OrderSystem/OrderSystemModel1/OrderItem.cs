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
        public string foodtype { get; set; }
        public int tableID { get; set; }
        public int orderID { get; set; }
        public int itemID { get; set; }
        public string name { get; set; }
        public int amount { get; set; }
        public Item item { get; set; }
        public string comment{ get; set; }
    }
}
