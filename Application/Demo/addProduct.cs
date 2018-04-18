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
    public partial class addProduct : UserControl
    {
        Form1 ths;
        public addProduct(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }
        public void upImage_hover(Object sender, EventArgs e)
        {
            this.upImage.Size = new Size(75, 75);
            this.upImage.Cursor = Cursors.Hand;
        }
        public void upImage_Leave(Object sender, EventArgs e)
        {
            this.upImage.Size = new Size(65, 65);
        }

        private void upImage_Click(object sender, EventArgs e)
        {
            this.upImage.Size = new Size(65, 65);
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png(|*.png";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    imageBox.ImageLocation = imageLocation;
                }
            }catch(Exception)
            {
                MessageBox.Show("Error uploading image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(float.Parse(priceBox.Text) > 0  && nameBox.Text.Length >5 && qunatBox.TextLength > 0 && imageBox.ImageLocation.Length > 0 && CategoryBox.TextLength >0 && providerBox.TextLength > 0)
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
                    string path = imageBox.ImageLocation;
                    byte[] imgBytes = System.IO.File.ReadAllBytes(path);
                    SqlCommand cmd = new SqlCommand("insert into Product(pname,price,quantity,category,img,provider) values('"+nameBox.Text+"','"+priceBox.Text+"',"+qunatBox.Text+",'"+
                        CategoryBox.Text+"',@img,"+"'"+providerBox.Text+"');", conn);
                    IDataParameter par = cmd.CreateParameter();
                    par.ParameterName = "img";
                    par.DbType = DbType.Binary;
                    par.Value = imgBytes;
                    cmd.Parameters.Add(par);
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
                    ths.home_Click(sender,e);
                }
            }
            else
            {
                MessageBox.Show("Empty field");
            }

        }
    }
}
