using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

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
        public static User Select(string login, string pass)
        {
            DataTable table = DbConnect.Select("SELECT * FROM Users where Login = '"+login+"' and Password = '"+pass+"';");
            if (table.Rows.Count > 0)
                return new User(table.Rows[0]);
            return null;
            
        }
    }
  
}
