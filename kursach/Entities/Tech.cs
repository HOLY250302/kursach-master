using kursach.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    public class Tech
    {
        public int ID;
        public string Nazv;
        public int Colvo;
        public int Cena;
        public int Summ;
        public Tech(DataRow row)
        {
            ID = Convert.ToInt32(row["tech_id"]);
            Nazv = Convert.ToString(row["nazv"]);
            Colvo = Convert.ToInt32(row["colvo"]);
            Cena = Convert.ToInt32(row["cena"]);
            Summ = Convert.ToInt32(row["summ"]);
           
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
