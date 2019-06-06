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
    }
}

