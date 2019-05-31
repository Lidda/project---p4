using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using OrderSystemModel;
using System.Data;

namespace OrderSystemDAL
{
    public class TakeOrderDAL : Base
    {
        public List<ItemModel> DB_Get_All_Items()
        {
            string query = "SELECT * FROM ITEMS";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetItems(ExecuteSelectQuery(query, sqlParameters));
        }

        //Get a list of all items
        private List<ItemModel> GetItems(DataTable dataTable)
        {
            List<ItemModel> items = new List<ItemModel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                ItemModel item = new ItemModel()
                {
                    itemID = (int)dr["itemID"],
                    name = (string)dr["name"],
                    price = (float)dr["price"],
                    stock = (int)dr["stock"],
                    course = (string)dr["course"],
                    description = (string)dr["description"],
                    tax = (int)dr["TAX"],
                    foodtype = (string)dr["foodtype"]
                };
                items.Add(item);
            }
            return items;
        }

        //Adds new order to ORDERS table
        public void AddNewOrder(OrderModel order)
        {
            string query = "INSERT INTO [ORDERS] (orderID, comment, employeeID, tableID) VALUES ((SELECT COALESCE(MAX(orderID)+1, 0) FROM [ORDERS]), @comment, @employeeID, @tableID)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@comment", order.comment),
                new SqlParameter("@employeeID", order.Employee.ID),
                new SqlParameter("@tableID", order.Table.ID),
            };
            ExecuteSelectQuery(query, sqlParameters);
        }

        //Adds items to ORDER_CONTAINS table
        public void AddItemsToOrder(List<OrderItemModel> orderItems)
        {
            foreach (OrderItemModel orderItem in orderItems)
            {
                string query = "INSERT INTO [ORDERS_CONTAINS] (orderID, itemID, amount, comment, status) VALUES (@orderID, @itemID, @amount, @comment, Not ready)";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@orderID", orderItem.orderID),
                    new SqlParameter("@itemID", orderItem.item.itemID),
                    new SqlParameter("@amount", orderItem.amount),
                    new SqlParameter("@comment", orderItem.comment),
                };
                ExecuteSelectQuery(query, sqlParameters);
            }
        }
    }
}
