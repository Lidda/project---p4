using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel {
    public class Table {
        public enum Availability { Unavailable, Available, Reserved };

        public Availability Status { get; set; }
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public int Capacity { get; set; }
    }
}
