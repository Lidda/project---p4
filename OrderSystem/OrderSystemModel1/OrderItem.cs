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
<<<<<<< HEAD
        public DateTime TimeOfOrder { get; set; }
        public DateTime dateTime { get; set; }
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
=======
        public string comment{ get; set; }
>>>>>>> c1a86512947aac1dec9c90e29646efdbd70339cd
    }
}
