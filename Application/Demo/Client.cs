using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Client
    {
        private int cid;
        private string cname;
        private string email;
        private string pwd;
        private decimal balance;

        public int Cid
        {
            get { return cid; }
            set { cid = value; }
        }

        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

            public Client(int cid, string cname, string email, string pwd, decimal balance)
        {
            this.cid = cid;
            this.cname = cname;
            this.email = email;
            this.pwd = pwd;
            this.balance = balance;
        }

        public Client()
        {
            cid = 0;
            cname = "";
            email = "";
            pwd = "";
            balance = 0;
        }
        public Client(Client C)
        {
            cid = C.cid;
            cname = C.cname;
            email = C.email;
            pwd = C.pwd;
            balance = C.balance;
        }
    }
}
