using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemModel1 {
    public class Table {
        public int ID { get; set; }
        public int Status { get; set; }

        public Table(int ID) {
            this.ID = ID;
        }
    }
}
