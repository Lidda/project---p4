using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel
{
    public enum Type { Bartender = 1, Cook, Waiter, Manager };
    public class Employee
    {
        public string name;
        public string username;
        public string password;
        public Type type;
    }
}
