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
    public class ItemDAL : Base {

        //Gets all item from the datatbase
        public List<Item> Db_Get_All_Items() {
            string query = "SELECT itemID, name, stock, price, course, description, TAX, foodtype FROM [ITEMS]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadItems(ExecuteSelectQuery(query, sqlParameters));
        }

        //Gets a single item from the database
        public Item Db_Get_Item(Item item) {
            string query = "SELECT itemID, name, stock, price, course, description, TAX, foodtype FROM [ITEMS] WHERE itemID = @itemID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@itemID", item.itemID)
            };
            return ReadItems(ExecuteSelectQuery(query, sqlParameters))[0];
        }

        //Puts the values gained from the database into an item object
        private List<Item> ReadItems(DataTable dataTable)
        {
            List<Item> items = new List<Item>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Item item = new Item()
                {
                    itemID = (int)dr["itemID"],
                    name = (string)dr["name"],
                    stock = (int)(dr["stock"]),
                    price = (double)(dr["price"]),
                    course = (string)dr["course"],
                    description = (string)dr["description"],
                    tax = (int)(dr["TAX"]),
                    foodtype = (string)dr["foodtype"]
                };
                items.Add(item);
            }
            return items;
        }

        //Add item to databse
        public void AddItem(Item item)
        {
            string query = "INSERT INTO [ITEMS] (itemID, name, stock, price, TAX, course, foodtype, description) VALUES ((SELECT COALESCE(MAX(itemID)+1, 0) FROM [ITEMS]), @name, @stock, @price, @TAX, @course, @foodtype, @description)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@name", item.name),
                new SqlParameter("@stock", item.stock),
                new SqlParameter("@price", item.price),
                new SqlParameter("@TAX", item.tax),
                new SqlParameter("@course", item.course),
                new SqlParameter("@foodtype", item.foodtype),
                new SqlParameter("@description", item.description)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        //Edit item in database
        public void EditItem(Item item)
        {
            string query = "UPDATE [ITEMS] SET name = @name, stock = @stock, price = @price, TAX = @TAX, course = @course, foodtype = @foodtype, description = @description WHERE itemID = @itemID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@itemID", item.itemID),
                new SqlParameter("@name", item.name),
                new SqlParameter("@stock", item.stock),
                new SqlParameter("@price", item.price),
                new SqlParameter("@TAX", item.tax),
                new SqlParameter("@course", item.course),
                new SqlParameter("@foodtype", item.foodtype),
                new SqlParameter("@description", item.description)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        //Delete item from database
        public void DeleteItem(Item item)
        {
            string query = "DELETE FROM [ITEMS] WHERE itemID = @itemID";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@itemID", item.itemID)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
