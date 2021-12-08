using kursach.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    static class AuthForm
    {
        public static users user { get; private set; }

        public static bool Auth(string Login, string pass)
        {
            user = users.Select(Login, pass);
            if (user != null)
                return true;
            else
                return false;
        }
        public static void DeAuth()
        {
            user = null;
        }
    }
}
