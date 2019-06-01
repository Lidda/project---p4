﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;
using System.Data;
using static OrderSystemModel.OrderItem;

namespace OrderSystemDAL
{
    public class BarKitchenDAL : Base {
        TableDAL tableDAL = new TableDAL();

        public List<OrderItem> Db_Get_All_Orders() {
            string query = "Select o.tableID, i.amount, p.name, p.foodtype, i.status, i.comment FROM ORDERS AS O JOIN ORDER_CONTAINS AS I ON o.orderID = i.orderID JOIN ITEMS AS P ON p.itemid = i.itemid ORDER BY o.tableID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadOrders(ExecuteSelectQuery(query, sqlParameters));
        }

        //Updates the status order by order.orderID
        public void OrderStatus(Order order, OrderItem.Status statusChange) {
            string query = "UPDATE [ORDER_CONTAINS] SET [status] = ( '" + statusChange + "') WHERE ORDERID = ( '" + order.orderID + "')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<OrderItem> ReadOrders(DataTable dataTable) {
            List<OrderItem> orders = new List<OrderItem>();

            foreach (DataRow dr in dataTable.Rows) {
                OrderItem orderItem = new OrderItem() {
                    tableID = (int)dr["tableID"],
                    amount = (int)dr["amount"],
                    foodname = (string)dr["name"],
                    foodtype = (string)dr["foodtype"],
                    status = (Status)dr["status"],
                    comment = (string)dr["comment"],                   
                };
                orders.Add(orderItem);
            }
            return orders;
        }



    }
}
