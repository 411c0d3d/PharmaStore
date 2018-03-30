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
    public partial class EditProduct : UserControl
    {
        Form1 ths;
        public EditProduct(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }
        public void submit_Click(object sender,EventArgs e,int k)
        {
            if(this.priceBox.Text.Trim()!="" && this.qualityBox.Text.Trim() != "")
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
                    SqlCommand cmd = new SqlCommand("editProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@pid",ths.productGrid.products[k].Pid);
                    SqlParameter param2 = new SqlParameter("@price", priceBox.Text);
                    SqlParameter param3 = new SqlParameter("@quantity", qualityBox.Text);

                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Update failed");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Update successful");

                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Empty field");
            }
        }
        public void submit_Click(object sender, EventArgs e)
        {
            if (this.priceBox.Text.Trim() != "" && this.qualityBox.Text.Trim() != "")
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
                    SqlCommand cmd = new SqlCommand("editProduct", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter("@pid", ths.hf.rproduct.Pid);
                    SqlParameter param2 = new SqlParameter("@price", priceBox.Text);
                    SqlParameter param3 = new SqlParameter("@quantity", qualityBox.Text);

                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Update failed");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Update successful");

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
