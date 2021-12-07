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
            User user = User.Select(tblogin.Text, tbpass.Text)
        }
    }
}
