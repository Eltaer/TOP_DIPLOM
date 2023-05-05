using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class checkUser
    {
        public string Login { get; set; }

        public bool Is_Admin { get; }

        public bool Is_Spec { get; }

        public string Status => Is_Admin ? "Admin" : "Teh_sup";

        public checkUser(string login, bool IsAdmin, bool IsSpec)
        {
            Login = login.Trim();
            Is_Admin = IsAdmin;
            Is_Spec = IsSpec;
        }
    }
}
