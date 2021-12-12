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
        public string Pass;
        public string Name;
        public User(DataRow row)
        {
            ID = Convert.ToInt32(row["users_id"]);
            Login = Convert.ToString(row["users_login"]);
            Pass = Convert.ToString(row["users_pass"]);
            Name = Convert.ToString(row["users_name"]);
        }
        public static User Select(string login, string pass)
        {

            DataTable table = DbConnect.GetConnect().Select("SELECT * FROM users where users_login = '"+login+"' and users_pass = '"+pass+"';");
            if (table.Rows.Count > 0)
                return new User(table.Rows[0]);
            return null;
            
        }
    }
  
}
