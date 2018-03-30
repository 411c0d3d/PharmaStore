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
    public partial class homeForm : UserControl
    {
        Form1 ths;
        public homeForm(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }
        public void bPanel_click(object sen, EventArgs e)
        {
            if (ths.client == null)
                ths.client = new Client();
            if (ths.admin == null)
                ths.admin = new Admin();
            if (ths.client.Cid != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Add to panel ?", "confirm buy product", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection())
                    {
                        conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                        if (conn == null)
                        {
                            MessageBox.Show("error Connection");
                            return;
                        }
                        SqlCommand cmd = new SqlCommand("insert into BuyOrder(pid,cid) values(" + rproduct.Pid + "," + ths.client.Cid + ")", conn);
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();
                        if (result == 0)
                        {
                            MessageBox.Show("Something went wrong");
                        }
                        else
                        {
                            Demo.Program.getData(ths);
                            ths.cartvallab.Text = ths.cart.NProducts.ToString();

                        }
                        conn.Close();
                    }
                }
            }
            else if (ths.admin.Aid != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Edit Product ?", "Edit Product confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ths.hf.Dispose();
                    ths.ep = new EditProduct(ths);
                    ths.bgPanel.Controls.Add(ths.ep);
                    ths.ep.productNameLab.Text += " " + rproduct.Pname;
                    ths.ep.priceBox.Text = rproduct.Price.ToString();
                    ths.ep.qualityBox.Text = rproduct.Quantity.ToString();
                    ths.ep.submit.Click += (sender, EventArgs) => { ths.ep.submit_Click(sen, e);};
                    ths.ep.Location = new Point(160, 115);
                }
            }
            else
            {
                MessageBox.Show("You need to login first");
            }
        }
        public void bPanel_Hover(object sen, EventArgs e)
        {
            this.Pr.BackColor = Color.FromArgb(0, 255, 0);
            this.nlab.ForeColor = Color.Black;
            this.plab.ForeColor = Color.Black;
            this.qlab.ForeColor = Color.Black;
            this.clab.ForeColor = Color.Black;
        }

        public void bPanel_Leave(object se, EventArgs e)
        {
            this.Pr.BackColor = Color.Transparent;
            this.nlab.ForeColor = Color.FromArgb(0, 255, 0);
            this.plab.ForeColor = Color.FromArgb(0, 255, 0);
            this.qlab.ForeColor = Color.FromArgb(0, 255, 0);
            this.clab.ForeColor = Color.FromArgb(0, 255, 0);
        }
    }
}
