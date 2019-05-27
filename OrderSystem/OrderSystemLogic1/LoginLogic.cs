using OrderSystemDAL1;
using OrderSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemLogic {
    public class LoginLogic {
        LoginDAL Login_db = new LoginDAL();

        public bool CheckForUser(Employee employee) {
           try {
                employee = Login_db.Db_Find_User(employee);

                if (employee == null) {
                    return false;
                }
                return true;

            } catch {
               throw new Exception("Something went wrong.");
            }
        }

    }
}
