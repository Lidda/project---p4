﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;
using System.Data;

namespace OrderSystemDAL
{
    public class CheckoutDAL : Base
    {
        public Order DB_Get_Order(Table table, Employee employee)
        {
            Order order = new Order();

            string queryOrder = string.Format("SELECT orderID, comment FROM ORDERS WHERE TableID = {0} AND PaymentStatus = 0 AND DateTimeOrdered >= CONVERT(datetime, convert(varchar(10), GETDATE() ,120), 120)", table.ID);

            SqlParameter[] sqlParameters = new SqlParameter[0];

            //order ID + comment
            order = ReadOrder(ExecuteSelectQuery(queryOrder, sqlParameters));
            //ordered items
            string queryItems = string.Format("SELECT I.itemID, I.name, I.price, O.amount, I.TAX, I.stock, O.comment, I.course, I.description, I.foodtype, O.status FROM ITEMS AS I JOIN ORDER_CONTAINS AS O ON I.itemID = O.itemID JOIN ORDERS AS D on D.orderID = O.orderID WHERE D.orderID = {0}", order.orderID);
            order.items = ReadItems(ExecuteSelectQuery(queryItems, sqlParameters));
            //add table
            order.Table = table;
            //add employee
            order.Employee = employee;

            return order;
        }

        private List<OrderItem> ReadItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem();
                Item item = new Item();

                item.itemID = (int)dr["itemID"];
                item.name = (string)dr["name"];
                item.price = (float)(double)dr["price"];
                item.tax = (int)dr["TAX"];
                item.stock = (int)dr["stock"];
                item.course = (string)dr["course"];
                item.description = (string)dr["description"];
                if (dr["comment"] == DBNull.Value)
                {
                    item.comment = "";

                }
                else
                {
                    item.comment = (string)dr["comment"];
                }
                item.foodtype = (string)dr["foodtype"];

                orderItem.amount = (int)dr["amount"];
                orderItem.status = (OrderItem.Status)dr["status"];
                orderItem.item = item;

                orderItems.Add(orderItem);
            }
            return orderItems;
        }

        //
        private Order ReadOrder(DataTable dataTable)
        {
            Order order = new Order();
            foreach (DataRow dr in dataTable.Rows)
            {
                order.orderID = (int)dr["orderID"];
                if (dr["comment"] == DBNull.Value)
                {
                    order.comment = "";

                }
                else
                {
                    order.comment = (string)dr["comment"];
                }
            }
            return order;
        }


        //set order to paid
        public void SetOrderToPaid(Order order) {
            //set to paid
            string query = string.Format("UPDATE ORDERS SET PaymentStatus = 1 WHERE orderID = {0} AND PaymentStatus = 0", order.orderID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

            //update db with total paid amount
            SetTotalPaidAmount(order);
        }

        private void SetTotalPaidAmount(Order order) {
            //save total amount in DB
            double amount = order.tip;
            foreach (OrderItem i in order.items) {
                amount = amount + i.item.price * i.item.amount;
            }
            string queryTotalAmount = string.Format("UPDATE ORDERS SET TotalAmount = {0} WHERE orderID = {1}", (double)amount, order.orderID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(queryTotalAmount, sqlParameters);
        }

        // Add comment to order
        public void AddCommentToOrder(Order order)
        {
            string query = string.Format("UPDATE ORDERS SET comment = '{0}' WHERE orderID = {1}", order.comment, order.orderID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}

