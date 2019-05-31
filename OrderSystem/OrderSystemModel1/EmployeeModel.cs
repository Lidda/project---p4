using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel
{
    public enum Type { Bartender = 1, Waiter, Cook, Manager };
    public class EmployeeModel
    {
        public int ID;
        public string name;
        public string username;
        public string password;
        public Type type;
    }
}
