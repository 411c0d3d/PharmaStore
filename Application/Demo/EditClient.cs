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
    public partial class EditClient : UserControl
    {
        Form1 ths;
        public EditClient(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }
        public void submit_Click(object sender, EventArgs e)
        {
            if (this.nameBox.Text.Trim() != "" && this.balanceBox.Text.Trim() != "" && this.emailBox.Text.Trim() != "")
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                    if (conn == null)
                    {
                        MessageBox.Show("error Connection");
                        return;
                    }
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("editClient", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@cid",ths.eClient.Cid);
                    SqlParameter param2 = new SqlParameter("@name",this.nameBox.Text);
                    SqlParameter param3 = new SqlParameter("@email",this.emailBox.Text);
                    SqlParameter param4 = new SqlParameter("@balance", this.balanceBox.Text);


                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);
                    cmd.Parameters.Add(param4);


                    int result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Update failed");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Update successful");
                        ths.eClient = null;
                        this.Dispose();
                        ths.editClient_Click(sender,e);
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Empty field");
            }
        }
    }
}
