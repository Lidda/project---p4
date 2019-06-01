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
        public int tableID { get; set; }
        public string foodname { get; set; }
        public string foodtype { get; set; }
        public int amount { get; set; }
        public Item item { get; set; }
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
    }
}
