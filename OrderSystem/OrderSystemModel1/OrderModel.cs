using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel
{
    public class OrderModel
    {
        public int orderID { get; set; } //e.g. 1
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
        public EmployeeModel Employee { get; set; }
        public TableModel Table { get; set; }

        //list of ordered items
        public List<ItemModel> items { get; set; }

        public OrderModel()
        {
            items = new List<ItemModel>();
        }
    }
}

