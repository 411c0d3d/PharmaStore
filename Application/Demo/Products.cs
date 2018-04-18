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
    public partial class Products : UserControl
    {
        Form1 ths;
        public Products(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
            this.SetStyle(
                System.Windows.Forms.ControlStyles.UserPaint |
                System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
                true);
        }
        
        private void Products_Load(object sender, EventArgs e)
        {
           
           this.products = Program.get_Products();
            int xpos = 14, ypos = 3,k=0;
            for (int i = 0; i < (float)nProducts / 3; i++)
            {
                xpos = 14;
                int j = 0;
                while (k < nProducts && j < 3)
                {
                    this.P[k] = new System.Windows.Forms.Panel();
                    this.pB[k] = new System.Windows.Forms.PictureBox();
                    this.clab[k] = new System.Windows.Forms.Label();
                    this.nlab[k] = new System.Windows.Forms.Label();
                    this.qlab[k] = new System.Windows.Forms.Label();
                    this.plab[k] = new System.Windows.Forms.Label();
                    
                    this.P[k].SuspendLayout();

                    this.P[k].Controls.Add(this.clab[k]);
                    this.P[k].Controls.Add(this.qlab[k]);
                    this.P[k].Controls.Add(this.nlab[k]);
                    this.P[k].Controls.Add(this.plab[k]);
                    this.P[k].Controls.Add(this.pB[k]);
                    
                    this.P[k].Location = new System.Drawing.Point(xpos, ypos);
                    this.P[k].Name = products[k].Pid.ToString();
                    this.P[k].Size = new System.Drawing.Size(206, 179);
                    this.P[k].TabIndex = 0;
                    this.Controls.Add(this.P[k]);
                    this.P[k].BringToFront();
                    this.P[k].ResumeLayout(false);
                    this.P[k].PerformLayout();
                    
                    //---------------------------------------------
                    this.pB[k].Location = new System.Drawing.Point(15, 29);
                    ((System.ComponentModel.ISupportInitialize)(this.pB[k])).BeginInit();
                    this.P[k].Controls.Add(this.pB[k]);
                    if(products[k].Image !=null)
                    this.pB[k].Image = Program.ByteToImage(products[k].Image);
                    this.pB[k].Name = "image"+k;
                    this.pB[k].SizeMode = PictureBoxSizeMode.Zoom;
                    this.pB[k].Size = new System.Drawing.Size(177, 97);
                    this.pB[k].TabIndex = 0;
                    this.pB[k].TabStop = false;
                    this.P[k].Cursor = Cursors.Hand;
                    this.pB[k].Cursor = Cursors.Hand;
                    ((System.ComponentModel.ISupportInitialize)(this.pB[k])).EndInit();
                    //---------------------------------------------
                    this.clab[k].AutoSize = true;
                    this.clab[k].Location = new System.Drawing.Point(55, 3);
                    this.clab[k].MinimumSize = new System.Drawing.Size(68, 20);
                    this.clab[k].Name = "category"+k;
                    this.clab[k].ForeColor = Color.FromArgb(0, 255, 0);
                    this.clab[k].Size = new System.Drawing.Size(68, 20);
                    this.clab[k].TabIndex = 4;
                    this.clab[k].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.clab[k].Text = products[k].Category;
                    this.clab[k].Cursor = Cursors.Hand;
                    //----------------------------------------------

                    this.nlab[k].AutoSize = true;
                    this.nlab[k].Location = new System.Drawing.Point(72, 141);
                    this.nlab[k].MinimumSize = new System.Drawing.Size(60, 20);
                    this.nlab[k].Name = "name"+k;
                    this.nlab[k].Size = new System.Drawing.Size(60, 20);
                    this.nlab[k].ForeColor = Color.FromArgb(0, 255, 0);
                    this.nlab[k].TabIndex = 2;
                    this.nlab[k].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.nlab[k].Text = products[k].Pname;
                    this.nlab[k].Cursor = Cursors.Hand;
                    //-----------------------------------------------
                    this.qlab[k].AutoSize = true;
                    this.qlab[k].Location = new System.Drawing.Point(150, 141);
                    this.qlab[k].MinimumSize = new System.Drawing.Size(30, 20);
                    this.qlab[k].Name = "quantity"+k;
                    this.qlab[k].Size = new System.Drawing.Size(30, 20);
                    this.qlab[k].ForeColor = Color.FromArgb(0, 255, 0);
                    this.qlab[k].TabIndex = 3;
                    this.qlab[k].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.qlab[k].Text =products[k].Quantity.ToString();
                    this.qlab[k].Cursor = Cursors.Hand;
                    //-----------------------------------------------
                    this.plab[k].AutoSize = true;
                    this.plab[k].Location = new System.Drawing.Point(6, 141);
                    this.plab[k].MinimumSize = new System.Drawing.Size(60, 20);
                    this.plab[k].Name = "price"+k;
                    this.plab[k].Size = new System.Drawing.Size(60, 20);
                    this.plab[k].ForeColor = Color.FromArgb(0, 255, 0);
                    this.plab[k].TabIndex = 1;
                    this.plab[k].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    this.plab[k].Text = products[k].Price.ToString() + " Dh";
                    this.plab[k].Cursor = Cursors.Hand;
                    //--------------------------------------------------
                    int index = k;
                    this.P[k].Click += (sen,EventArgs) => { bPanel_click(sender, EventArgs, index); };
                    this.plab[k].Click += (sen, EventArgs) => { bPanel_click(sender, EventArgs, index); }; 
                    this.clab[k].Click += (sen, EventArgs) => { bPanel_click(sender, EventArgs, index); };
                    this.nlab[k].Click += (sen, EventArgs) => { bPanel_click(sender, EventArgs, index); };
                    this.qlab[k].Click += (sen, EventArgs) => { bPanel_click(sender, EventArgs, index); };

                    this.P[k].MouseLeave += (sen, EventArgs) => { this.bPanel_Leave(sender, EventArgs, index); };
                    this.plab[k].MouseLeave += (sen, EventArgs) => { this.bPanel_Leave(sender, EventArgs, index); };
                    this.clab[k].MouseLeave += (sen, EventArgs) => { this.bPanel_Leave(sender, EventArgs, index); }; 
                    this.nlab[k].MouseLeave += (sen, EventArgs) => { this.bPanel_Leave(sender, EventArgs, index); };
                    this.qlab[k].MouseLeave += (sen, EventArgs) => { this.bPanel_Leave(sender, EventArgs, index); }; 

                    this.P[k].MouseHover += (sen, EventArgs) => { this.bPanel_Hover(sender, EventArgs, index); };
                    this.plab[k].MouseHover += (sen, EventArgs) => { this.bPanel_Hover(sender, EventArgs, index); };
                    this.clab[k].MouseHover += (sen, EventArgs) => { this.bPanel_Hover(sender, EventArgs, index); }; 
                    this.nlab[k].MouseHover += (sen, EventArgs) => { this.bPanel_Hover(sender, EventArgs, index); };
                    this.qlab[k].MouseHover += (sen, EventArgs) => { this.bPanel_Hover(sender, EventArgs, index); };

                    this.pB[k].MouseHover += (sen, EventArgs) => { this.bPanel_Hover(sender, EventArgs, index); };
                    this.pB[k].MouseLeave += (sen, EventArgs) => { this.bPanel_Leave(sender, EventArgs, index); };
                    this.pB[k].Click += (sen, EventArgs) => { bPanel_click(sender, EventArgs, index); };

                    k++;
                    j++;
                    xpos += 212;
                }
                ypos += 185;
            }
        }

    public void bPanel_click(object sen, EventArgs e,int k)
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
                     
                        //conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                        conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                        if (conn == null)
                        {
                            MessageBox.Show("error Connection");
                            return;
                        }
                        SqlCommand cmd = new SqlCommand("insert into BuyOrder(pid,cid) values(" + products[k].Pid + "," + ths.client.Cid + ")", conn);
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
                DialogResult dialogResult = MessageBox.Show("Edit Product ?","Edit Product confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ths.productGrid.Dispose();
                    ths.ep= new EditProduct(ths);
                    ths.bgPanel.Controls.Add(ths.ep);
                    ths.ep.productNameLab.Text +=" "+products[k].Pname;
                    ths.ep.priceBox.Text = products[k].Price.ToString();
                    ths.ep.qualityBox.Text = products[k].Quantity.ToString();
                    ths.ep.submit.Click += (sender, EventArgs) => { ths.ep.submit_Click(sen, e, k); };
                    ths.ep.Location = new System.Drawing.Point(160, 115);
                }
            }
            else
            {
                MessageBox.Show("You need to login first");
            }
        }
        public void bPanel_Hover(object sen, EventArgs e, int k)
        {
            this.P[k].BackColor = Color.FromArgb(0, 255, 0);
            this.nlab[k].ForeColor = Color.Black;
            this.plab[k].ForeColor = Color.Black;
            this.qlab[k].ForeColor = Color.Black;
            this.clab[k].ForeColor = Color.Black;
        }
        
        public void bPanel_Leave(object se,EventArgs e,int k)
        {
            this.P[k].BackColor = Color.Transparent ;
            this.nlab[k].ForeColor = Color.FromArgb(0, 255, 0);
            this.plab[k].ForeColor  = Color.FromArgb(0, 255, 0);
            this.qlab[k].ForeColor  = Color.FromArgb(0, 255, 0);
            this.clab[k].ForeColor  = Color.FromArgb(0, 255, 0);
        }


        static int nProducts = Program.get_Number_Products();
        public Product[] products;

        public Panel[] P = new Panel[nProducts];
        PictureBox[] pB = new PictureBox[nProducts];
        Label[] clab = new Label[nProducts];
        Label[] plab = new Label[nProducts];
        Label[] nlab = new Label[nProducts];
        Label[] qlab = new Label[nProducts];
        
    }
}
