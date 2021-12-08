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
        public tech()
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
            dataGridView1.Rows.Clear();

            DbConnect connection = new DbConnect();
            DataTable table = connection.Select("Select * from tech");

            foreach (DataRow row in table.Rows)
            {
                users user = new users(row);
                int r = dataGridView1.Rows.Add();
                dataGridView1.Rows[r].Tag = ;
            }
        }
    }
}
