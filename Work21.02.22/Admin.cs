using System;
using System.Collections.Generic;
using System.Text;

namespace Work21._02._22
{
    class Admin : User
    {
        private bool IsSuperAdmin;
        private string Section;

        public Admin(bool issuperadmin, string section, string username, string password): base
            (username, password)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
        }
        
                       
    }
}
