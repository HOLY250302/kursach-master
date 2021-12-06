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

        private void btLoad_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
        public void UpdateTable()
        {
           dataGridView1.Rows.Clear();

            DbConnect connection = new DbConnect();
            DataTable table = connection.Select("Select * from users");

            foreach (DataRow row in table.Rows)
            {
                User user = new User(row);
                int r = dataGridView1.Rows.Add(user.ID, user.Login, user.Password);
                dataGridView1.Rows[r].Tag = user;
            }
           
        }

       
    }
}
