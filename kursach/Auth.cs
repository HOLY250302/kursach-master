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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
          
            if (AuthManager.Auth(tblogin.Text, tbpass.Text))
            {
                Hide();
                new UserForm().ShowDialog();
                //AuthManager.DeAuth();
                Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
