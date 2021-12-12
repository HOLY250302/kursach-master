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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            UpdateTable();
        }
        
        public void UpdateTable()
        {
           dataGridView1.Rows.Clear();

            DbConnect connection = new DbConnect();
            DataTable table = connection.Select("Select * from users where `users_name` like '%" + tbSearch.Text + "%'");

            foreach (DataRow row in table.Rows)
            {
                User user = new User(row);
                int r = dataGridView1.Rows.Add(user.ID, user.Login, user.Pass, user.Name);
                dataGridView1.Rows[r].Tag = user;
            }
           
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btn_goZakaz_Click(object sender, EventArgs e)
        {
            Hide();
            new ZakazForm().ShowDialog();
            Show();
        }
    }
}
