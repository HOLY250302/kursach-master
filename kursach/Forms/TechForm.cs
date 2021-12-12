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
    public partial class TechForm : Form
    {
        public TechForm()
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
            DataTable table = DbConnect.GetConnect().Select("SELECT * FROM tech" +
                " where nazv like '%" + tbSearch.Text + "%';");
            foreach (DataRow row in table.Rows)
            {
                Tech t = new Tech(row);
                dataGridView2.Rows.Add(t.ID, t.Nazv, t.Colvo, t.Cena, t.Summ);
            }
        }

        private void btPrepods_Click(object sender, EventArgs e)
        {
            Hide();
            new UserForm().ShowDialog();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //  INSERT INTO `ISPr22 - 32_KutuzovPD_kursach`.`tech` (`tech_id`, `nazv`, `col - vo`, `cena`, `summ`) VALUES('22', '22', '22', '22', '22');
            AddZakazForm newForm = new AddZakazForm();
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
