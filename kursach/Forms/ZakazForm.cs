using kursach.Entities;
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
    public partial class ZakazForm : Form
    {
        public ZakazForm()
        {
            InitializeComponent();
            UpdateTable();
        }
        public void UpdateTable()
        {
            dataGridView2.Rows.Clear();
            DataTable table = DbConnect.GetConnect().Select("SELECT * FROM zakaz where zakaz_name like '%" + tbSearch.Text + "%'");
            foreach (DataRow row in table.Rows)
            {
                Zakaz z = new Zakaz(row);
                int t = dataGridView2.Rows.Add(z.ID, z.Name, z.Colvo, z.Itogo, z.Date);
                dataGridView2.Rows[t].Tag = z;
            }
        }
        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new AddZakazForm().ShowDialog();
            UpdateTable();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var zakaz = dataGridView2.SelectedRows[0].Tag as Zakaz;
                zakaz.DeleteZakaz();
                UpdateTable();
            }
            catch
            {
                MessageBox.Show("Не удалось удалить заказ!");
            }
        }
    }
}
