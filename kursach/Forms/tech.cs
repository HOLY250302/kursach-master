using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace kursach.Forms
{
    public partial class tech : Form
    {
        public tech(DataRow row)
        {
            InitializeComponent();
            UpdateTable();

        }

        private void btLoad1_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        public void UpdateTable()
        {
            dataGridView2.Rows.Clear();

            DbConnect connection = new DbConnect();
            DataTable table = connection.Select("Select * from tech");

            foreach (DataRow row in table.Rows)
            {
                 Tech tech = new Tech(row);
                int r = dataGridView2.Rows.Add(tech.id ,tech.nazv, tech.colvo, tech.cena, tech.summ);
                dataGridView2.Rows[r].Tag = r;
            }

        }
        public static List<tech> Select(string search)
        {
            List<tech> tech = new List<tech>();
            DataTable table = DbConnect.Select("SELECT * FROM `ISPr22 - 32_KutuzovPD_kursach`.tech" +
                " where nazv like '%%';");
            foreach(DataRow row in table.Rows)
            {
                tech.Add(new tech(row));
            }
            return tech;
        } 

        private void btPrepods_Click(object sender, EventArgs e)
        {
            Hide();
            new UserForm().ShowDialog();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //  INSERT INTO `ISPr22 - 32_KutuzovPD_kursach`.`tech` (`tech_id`, `nazv`, `col - vo`, `cena`, `summ`) VALUES('22', '22', '22', '22', '22');
            AddForm newForm = new AddForm();
            newForm.ShowDialog();
            UpdateTable();
        }
        public static void AddTech( string nazv, int colvo, int cena, int summ)
        {
            DbConnect connect = new DbConnect();
            connect.Select($"INSERT INTO `tech`( `nazv`, `colvo`, `cena`, `summ`) VALUES('{nazv}', '{colvo}', '{cena}', '{summ}')");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
