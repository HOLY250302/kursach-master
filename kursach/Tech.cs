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
    }
}
