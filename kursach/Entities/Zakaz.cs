using kursach.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach.Entities
{
    public class Zakaz
    {
        public int ID;
        public string Name;
        public int Colvo;
        public decimal Itogo;
        public DateTime Date;
        public Zakaz(DataRow row)
        {
            ID = Convert.ToInt32(row["zakaz_id"]);
            Name = Convert.ToString(row["zakaz_name"]);
            Colvo = Convert.ToInt32(row["zakaz_colvo"]);
            Itogo = Convert.ToDecimal(row["zakaz_itogo"]);
            Date = Convert.ToDateTime(row["zakaz_date"]);

        }
        public Zakaz() { }
        public void AddZakaz()
        {
            DbConnect.GetConnect().Select($"INSERT INTO `zakaz` (`zakaz_name`, `zakaz_colvo`, `zakaz_itogo`, `zakaz_date`) VALUES ('{Name}', '{Colvo}', '{Itogo}', '{Date.ToString("yyyy-MM-dd")}');");
        }
        public void DeleteZakaz()
        {
            DbConnect.GetConnect().Select($"DELETE FROM zakaz WHERE zakaz_id = {ID}");
        }
    }
}
