﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel
{
    public class Order
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
        public int employeeID { get; set; }
        public int tableID { get; set; }

        //list of ordered items
        public List<Item> items { get; set; }

        public Order()
        {
            items = new List<Item>();
        }
    }
}

