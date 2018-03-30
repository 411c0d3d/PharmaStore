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
using System.Data.Common;
using System.Configuration;

namespace Demo
{
    public partial class registerForm : UserControl
    {
        Form1 ths;
        public registerForm(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;

                if (conn == null)
                {
                    MessageBox.Show("error Connection");
                    return;
                }
                
                bool error = false;
                SqlCommand cmd = new SqlCommand("addClient",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (namebox.Text.Trim().Length != 0)
                {
                    SqlParameter param0 = new SqlParameter("@name", namebox.Text.Trim());
                    cmd.Parameters.Add(param0);
                }
                else
                {
                    loglab.Text = "Empty field : Full name\n";
                    error = true;
                }
                if (emailbox.Text.Trim().Length != 0)
                {
                    SqlParameter param1 = new SqlParameter("@email", emailbox.Text.Trim());
                    cmd.Parameters.Add(param1);
                }
                else
                {
                    loglab.Text += "Empty field : Email\n";
                    error = true;
                }
                if (pwdbox.Text == pwd2box.Text && pwdbox.Text.Trim().Length != 0)
                {
                    SqlParameter param2 = new SqlParameter("@pwd", pwdbox.Text.Trim());
                    cmd.Parameters.Add(param2);
                }
                else
                {
                    error = true;
                    if (pwdbox.Text != pwd2box.Text)
                        loglab.Text += "Passwords don't match !";
                    else
                        loglab.Text += "Empty field : password";
                }
                
                if (error == true)
                {
                    MessageBox.Show("Registration Failed ! _ See Error log");

                }
                else
                {
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Successfully Registered ! ... You can login now ");
                    this.Dispose();
                    ths.registerB.BackColor = Color.Transparent;
                    Clear();
                    ths.loginPanel_Click(sender,e);
                }
            }
            
        }
        void Clear()
        {
            pwdbox.Text = pwd2box.Text = namebox.Text = emailbox.Text = "";
        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {
            loglab.Text = "";
        }
    }
}
