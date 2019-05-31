﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel
{
    public class OrderItem
    {
        public int orderID { get; set; }
        public int amount { get; set; }
        public ItemModel item { get; set; }
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
        public int status { get; set; }
    }
}