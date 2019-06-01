using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderSystemModel;
using OrderSystemDAL;

namespace OrderSystemLogic
{
    public class ItemLogic
    {
        ItemDAL itemDAL = new ItemDAL();
        public List<Item> GetAllItems()
        {
            try
            {
                return itemDAL.Db_Get_All_Items();
            }
            catch
            {
                throw new Exception("Could not get items from database");
            }
        }

        public void Additem(Item item)
        {
            try
            {
                itemDAL.AddItem(item);
            }
            catch
            {
                throw new Exception("Could not insert item into database");
            }
        }

        public void EditItem(Item item)
        {
            try
            {
                itemDAL.EditItem(item);
            }
            catch
            {
                throw new Exception("Could not insert item into database");
            }
        }

        public void DeleteItem(Item item)
        {
            try
            {
                itemDAL.DeleteItem(item);
            }
            catch
            {
                throw new Exception("Could not delete item from database");
            }
        }
    }
}
