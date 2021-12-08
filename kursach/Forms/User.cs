using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kursach.Forms
{
   public class users
    {
        public int id;
        public string login;
        public string pass;
        public users(DataRow row)
        {
            id = Convert.ToInt32(row["users_id"]);
            login = Convert.ToString(row["login"]);
            pass = Convert.ToString(row["pass"]);
        }
        public static users Select(string login, string pass)
        {

            DataTable table = DbConnect.GetConnect().Select("SELECT * FROM users where login = '"+login+"' and pass = '"+pass+"';");
            if (table.Rows.Count > 0)
                return new users(table.Rows[0]);
            return null;
            
        }
    }
  
}
