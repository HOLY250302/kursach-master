using kursach.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursach
{
    static class AuthManager
    {
        public static User user { get; private set; }

        public static bool Auth(string Login, string pass)
        {
            user = User.Select(Login, pass);
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
