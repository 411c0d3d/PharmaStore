using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
   public class Product
    {
        private int pid;
        private string pname;
        private string category;
        private decimal price;
        private byte[] image;
        private int quantity;
        private string provider;


        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }

        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product(int pid, string pname, string category, decimal price,int quantity,string provider, byte[] image)
        {
            this.pid = pid;
            this.pname = pname;
            this.category = category;
            this.price = price;
            this.quantity = quantity;
            this.image = image;
            this.provider = provider;
        }
        public Product()
        {
            this.pid = 0;
            this.pname = "";
            this.category = "";
            this.price = 0;
            this.image = null;
            this.quantity = 0;
            this.provider = "";
        }
        public Product(Product P)
        {
            this.pid = P.pid;
            this.pname = P.pname;
            this.category = P.category;
            this.price = P.price;
            this.quantity = P.quantity;
            this.image = P.image;
            this.provider = P.provider;
        }
    }
}
