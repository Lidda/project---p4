﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemDAL;
using OrderSystemModel;

namespace OrderSystemLogic
{
    public class OrderItemLogic
    {
        OrderItemDAL orderItem_db = new OrderItemDAL();

        public void AddItemsToOrder(Order order)
        {
            try
            {
                orderItem_db.AddItemsToOrder(order);
            }
            catch
            {
                throw new Exception("Something went wrong");
            }
        }

        public void RemoveItemsFromOrder(List<OrderItem> orderItems)
        {
            try
            {
                orderItem_db.RemoveItemsFromOrder(orderItems);
            }
            catch
            {
                throw new Exception("Something went wrong while removing items");
            }
        }
    }
}
