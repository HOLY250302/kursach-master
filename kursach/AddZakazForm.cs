using kursach.Entities;
using kursach.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class AddZakazForm : Form
    {
        public AddZakazForm()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var zakaz = new Zakaz { Name = tbNazv.Text, Colvo = Convert.ToInt32(tbCol.Text), Itogo = Convert.ToDecimal(tbCena.Text), Date = DateTime.Now };
                zakaz.AddZakaz();
                Close();
            }
            catch
            {
                MessageBox.Show("Произошла ошибка! Некооректные данные");
            }
        }
    }
}
