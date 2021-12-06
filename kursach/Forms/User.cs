using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.Forms
{
   public class User
    {
        public int ID;
        public string Login;
        public string Password;
        public User(DataRow row)
        {
            ID = Convert.ToInt32(row["users_id"]);
            Login = Convert.ToString(row["login"]);
            Password = Convert.ToString(row["pass"]);
        }
    }
  
}
