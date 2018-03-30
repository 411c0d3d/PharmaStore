using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Demo
{
    public partial class ProfileForm : UserControl
    {
        Form1 F ;
        public ProfileForm(Form1 frm)
        {
            F = frm;
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string log="";

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                if (conn == null)
                {
                    MessageBox.Show("error Connection");
                    return;
                }
                
                bool error = false;
                Demo.Program.getData(F);
                if (this.npwd1.Text == npwd2.Text && npwd1.Text.Trim().Length != 0 && opwd.Text.Trim().Length != 0 && opwd.Text==F.client.Pwd)
                {
                    error = false;
                }
                else
                {
                    error = true;
                    if (npwd1.Text != npwd2.Text)
                        log += "Passwords don't match !";
                    else if (opwd.Text != F.client.Pwd)
                        log += " Old password incorrect";
                    else if (npwd1.Text.Trim().Length == 0 || npwd2.Text.Trim().Length == 0 || opwd.Text.Trim().Length == 0)
                        log += " Empty field";
                }
                if (error == true)
                {
                    MessageBox.Show("Registration Failed ! " + log);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "update Client set pwd='"+this.npwd1.Text+"' where cid="+F.client.Cid+";";
                    cmd.Connection = conn;
                    conn.Open();

                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    if(result !=0)
                        MessageBox.Show("Password changed successfully ");
                    Clear();
                }
            }
        }
        void Clear()
        {
            opwd.Text = npwd1.Text = npwd2.Text = "";
        }
    }
}
