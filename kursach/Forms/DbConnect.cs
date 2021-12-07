using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace kursach.Forms
{
    public class DbConnect
    {
            private MySqlConnection _Connection;
            public DbConnect()
            {
                MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                builder.Server = "cfif31.ru";    
                builder.UserID = "ISPr22-32_KutuzovPD";
                builder.Password = "ISPr22-32_KutuzovPD";
                builder.Port = 3306;
                builder.Database = "ISPr22-32_KutuzovPD_kursach";
                builder.CharacterSet = "utf8";

                _Connection = new MySqlConnection(builder.ConnectionString);
                _Connection.Open();
            }
        public DataTable Select(string sql)
        {
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand(sql, _Connection);
            table.Load(command.ExecuteReader());
            return table;
        }
    }
}
