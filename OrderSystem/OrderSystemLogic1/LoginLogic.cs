using OrderSystemDAL1;
using OrderSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemLogic1 {
    public class LoginLogic {
        LoginDAL Login_db = new LoginDAL();

        public bool CheckForUser(Employee employee) {
            try {
                return Login_db.Db_Check_User(employee);
            } catch {
                throw new Exception("Something went wrong.");
            }
        }

    }
}
