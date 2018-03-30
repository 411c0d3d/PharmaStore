using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Admin
    {
        private int aid;
        private string aname;
        private string pwd;
        private string email;

        public Admin(int aid, string aname, string pwd, string email)
        {
            this.aid = aid;
            this.aname = aname;
            this.pwd = pwd;
            this.email = email;
        }

        public int Aid
        {
            get { return aid; }
            set { aid = value; }
        }

        public string Aname
        {
            get { return aname; }
            set { aname = value; }
        }

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Admin()
        {
            aid = 0;
            aname = "";
            email = "";
            pwd = "";
            
        }
    }
}
