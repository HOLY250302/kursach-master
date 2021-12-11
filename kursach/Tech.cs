using kursach.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    class Tech
    {
        public int id;
        public string nazv;
        public int colvo;
        public int cena;
        public int summ;
        public Tech(DataRow row)
        {
            id = Convert.ToInt32(row["tech_id"]);
            nazv = Convert.ToString(row["nazv"]);
            colvo = Convert.ToInt32(row["colvo"]);
            cena = Convert.ToInt32(row["cena"]);
            summ = Convert.ToInt32(row["summ"]);
           
        }
        public static Tech Select(string nazv, int colvo, int cena, int summ)
        {

            DataTable table = DbConnect.GetConnect().Select("SELECT * FROM tech where nazv = '" + nazv + "' and colvo = '" + colvo + " and cena = '"+cena+"' and summ = '"+summ+"");
            if (table.Rows.Count > 0)
                return new Tech(table.Rows[0]);
            return null;

        }

    }
}
