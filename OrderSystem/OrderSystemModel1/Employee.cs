using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel
{
    public enum Type { Barman = 1, Serveerder, Kok, Manager };
    public class Employee
    {
        public int ID;
        public string name;
        public string username;
        public string password;
        public Type type;
    }
}
