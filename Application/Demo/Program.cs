using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;
using System.Drawing;
using System.IO;

namespace Demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        public static Bitmap ByteToImage(byte[] blob)
        {
                MemoryStream mStream = new MemoryStream();
                mStream.Write(blob, 0, Convert.ToInt32(blob.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();

                return bm;
          
        }
        public static Product[] get_Products()
        {
            int nP = get_Number_Products(), i = 0;
            Product[] P = new Product[nP];
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                if (conn == null)
                {
                    MessageBox.Show("error Connection");
                    return null;
                }
                SqlCommand cmd = new SqlCommand("SELECT pid,pname,price,category,img,quantity,provider from Product", conn);
                conn.Open();
                
                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read() && i<nP)
                    {
                        P[i] = new Product();
                        P[i].Pid =(int)dataReader["pid"];
                        P[i].Pname = (string)dataReader["pname"];
                        P[i].Category = (string)dataReader["category"];
                        P[i].Price = (decimal)dataReader["price"];
                        P[i].Quantity = (int)dataReader["quantity"];
                        P[i].Image = (byte[])dataReader["img"];
                        P[i].Provider = (string)dataReader["provider"];
                        i++;
                    }
                    dataReader.Close();
                }
                conn.Close();
                return P;
            }
        }
        public static Product get_rand_Product()
        {
            Product P = new Product();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                if (conn == null)
                {
                    MessageBox.Show("error Connection");
                    return null;
                }
                SqlCommand cmd = new SqlCommand("select top 1 pid,pname,price,category,img,quantity,provider FROM Product ORDER by NEWID()", conn);
                conn.Open();

                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read() )
                    {
                        P = new Product();
                        P.Pid = (int)dataReader["pid"];
                        P.Pname = (string)dataReader["pname"];
                        P.Category = (string)dataReader["category"];
                        P.Price = (decimal)dataReader["price"];
                        P.Quantity = (int)dataReader["quantity"];
                        P.Image = (byte[])dataReader["img"];
                        P.Provider = (string)dataReader["provider"];
                    }
                    dataReader.Close();
                }
                conn.Close();
                return P;
            }
        }
        public static int get_Number_Products()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                if (conn == null)
                {
                    MessageBox.Show("error Connection");
                    return 0;
                }


                SqlCommand cmd = new SqlCommand("select count(pid) as 'nProducts' from Product", conn);

                //______________  FOR SELECT CASE ______________
                int nProducts = 0;
                conn.Open();
                using (DbDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        nProducts = (int)dataReader["nProducts"];
                    }
                }
                conn.Close();
                return nProducts;
            }
        }
        public static int get_Number_purchases(Client C)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                if (conn == null)
                {
                    MessageBox.Show("error Connection");
                    return 0;
                }

                
                SqlCommand cmd = new SqlCommand("select count(bid) as 'nPurchases' from BuyHistory where cid="+C.Cid, conn);

                //______________  FOR SELECT CASE ______________
                int nProducts = 0;
                conn.Open();
                using (DbDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        nProducts = (int)dataReader["nPurchases"];
                    }
                }
                conn.Close();
                return nProducts;
            }
        }
        public static bool getData(Form1 F)
        {
            bool state = false;
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                if (conn == null)
                {
                    MessageBox.Show("error Connection");
                    state= false;
                }
                else
                {
                    if (F.client != null)
                    {
                       
                        
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "select oid,o.pid,pname,price,category,img,provider from buyOrder o join Product p on  p.pid=o.pid WHERE o.cid=" + F.client.Cid;
                        cmd.Connection = conn;
                        conn.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        if (rdr.HasRows)
                        {
                            F.cart = new Cart();
                            while (rdr.Read())
                            {
                                
                                F.cart.addOrder(new Product((int)rdr["pid"], (string)rdr["pname"], (string)rdr["category"],(decimal)rdr["price"], 1, (string)rdr["provider"], (byte[])rdr["img"]), (int)rdr["oid"]);

                            }
                        }
                        rdr.Close();
                        conn.Close();
                        if (F.cartp!=null)
                            F.cartvallab.Text = F.cart.NProducts.ToString();
                        F.title.Text = "Welcome " + F.client.Cname + "    Balance:  " + F.client.Balance.ToString() + " DH";

                        state = true;
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.CommandText = "select * from Client where cid=" + F.client.Cid;
                        cmd2.Connection = conn;
                        conn.Open();
                        SqlDataReader rdr2 = cmd2.ExecuteReader();
                        if (rdr2.HasRows)
                        {
                            while (rdr2.Read())
                            {
                                F.client = new Client((int)rdr2["cid"], (string)rdr2["cname"], (string)rdr2["email"], (string)rdr2["pwd"], (decimal)rdr2["balance"]);
                            }
                        }
                        rdr2.Close();
                    }
                    else if (F.admin != null)
                    {
                        F.title.Text = "Welcome " + F.admin.Aname;
                        state = true;
                    }
                    //----------------------------------------------------------------
                    conn.Close();
                }
            }
            return state;
        }
    }
}
