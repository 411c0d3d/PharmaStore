using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace Demo
{
    public class Cart
    {
        private int cid;
        private decimal toPay;
        private int maxP;
        private int nProducts;
        private Product[] cartProducts;
        private int[] oids;


        public Cart()
        {
            this.cid = 0;
            this.toPay = 0;
            this.nProducts = 0;
            this.maxP = 10;
            this.cartProducts = new Product[maxP];
            this.oids = new int[maxP];
        }

        public int Cid
        {
            set { this.cid = value; }
            get { return this.cid; }
        }
        public decimal ToPay
        {
            set { this.toPay = value; }
            get { return this.toPay; }
        }
        public int NProducts
        {
            set { this.nProducts = value; }
            get { return this.nProducts; }
        }
        public Product[] CartProducts
        {
            set { this.cartProducts = value; }
            get { return this.cartProducts; }
        }
        public int[] Oids
        {
            set { this.oids = value; }
            get { return this.oids; }
        }

        public bool addOrder(Product added, int oid)
        {
            if (nProducts < maxP)
            {
                this.cartProducts[nProducts] = new Product(added);
                this.oids[nProducts] = oid;
                this.toPay += added.Price;
                this.nProducts++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool removeProductById(int pid)
        {
            int f = 0;
            bool found = false;
            for (int i = 0; i < this.nProducts; i++)
            {
                if (cartProducts[i].Pid == pid) {
                    cartProducts[i] = cartProducts[i + 1];
                    this.nProducts--;
                    f = 1;
                    found = true;
                }
                if (f == 1)
                {
                    if (cartProducts[i + 1] != null)
                        cartProducts[i] = cartProducts[i + 1];
                    else
                        f = 0;
                }
            }
            return found;
        }
        public void CancelOrder(int pid, int oid)
        {
            if (removeProductById(pid))
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                    if (conn == null)
                    {
                        MessageBox.Show("error Connection");
                        return;
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "delete from BuyOrder where oid=" + oid;
                        cmd.Connection = conn;
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result == 0)
                        {
                            MessageBox.Show("Buy order canceled");
                            return;
                        }
                    }
                }
            }
        }
    
        public void BuyOrder(int pid,int oid)
        {
            if (removeProductById(pid))
            {
                using(SqlConnection conn =new SqlConnection())
                {
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                    if (conn == null)
                    {
                        MessageBox.Show("error Connection");
                        return;
                    }
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("buyProc", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter("@oid", oid);
                    cmd.Parameters.Add(param);
                    int result = cmd.ExecuteNonQuery();
                    if (result == -1 || result == 0)
                    {
                        MessageBox.Show("payment failed");
                        return;
                    }
                    else if (result != -1 && result != 0)
                    {
                        MessageBox.Show("payment successful");
                        
                    }
                    conn.Close();
                }
            }
        }
    }
}
