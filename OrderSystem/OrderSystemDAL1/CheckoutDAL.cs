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

            string queryItems = string.Format("SELECT I.itemID, I.name, I.price, O.amount, I.TAX, I.stock, O.comment, I.course, I.description, I.foodtype FROM ITEMS AS I JOIN ORDER_CONTAINS AS O ON I.itemID = O.itemID JOIN ORDERS AS D on D.orderID = O.orderID WHERE D.orderID = {0}", order.orderID);

            //order ID + comment
            order = ReadOrder(ExecuteSelectQuery(queryOrder, sqlParameters));
            //ordered items
            order.items = ReadItems(ExecuteSelectQuery(queryItems, sqlParameters));
            //add table
            order.Table = table;
            //add employee
            order.Employee = employee;

            return order;
        }

        private List<Item> ReadItems(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    itemID = (int)dr["itemID"],
                    name = (string)dr["name"],
                    price = (float)(double)dr["price"],
                    amount = (int)dr["amount"],
                    tax = (int)dr["TAX"],
                    stock = (int)dr["stock"],
                    course = (string)dr["course"],
                    description = (string)dr["description"],
                    comment = (string)dr["comment"],
                    foodtype = (string)dr["foodtype"]
                };
                items.Add(item);
            }
            return items;
        }
        //
        private Order ReadOrder(DataTable dataTable)
        {
            Order order = new Order();
            foreach (DataRow dr in dataTable.Rows)
            {
                order.orderID = (int)dr["orderID"];
                order.comment = (string)dr["comment"];
            }
            return order;
        }
        //set order to paid
        public void SetOrderToPaid(Order order, float Tip)
        {
            //set to paid
            string query = string.Format("UPDATE ORDERS SET PaymentStatus = 1 WHERE orderID = {0} AND PaymentStatus = 0", order.orderID);
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

            //update db with total paid amount
            SetTotalPaidAmount(order, Tip);
        }
        private void SetTotalPaidAmount(Order order, float Tip)
        {
            //save total amount in DB
            float amount = Tip;
            foreach (Item item in order.items)
            {
                amount = amount + item.price * item.amount;
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

