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
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Demo
{
    public partial class CartForm : UserControl
    {
        Form1 ths;
        public CartForm(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
        }
        public void CartForm_Load(object sender,EventArgs e)
        {
            orderpanels = new Panel[ths.cart.NProducts];
            this.oid = new Label[ths.cart.NProducts];
            this.pname = new Label[ths.cart.NProducts];
            this.price = new Label[ths.cart.NProducts];
            this.categ = new Label[ths.cart.NProducts];
            this.payo = new PictureBox[ths.cart.NProducts];
            this.orderpic = new PictureBox[ths.cart.NProducts];
            this.cancel = new PictureBox[ths.cart.NProducts];
            this.buyl = new Label[ths.cart.NProducts];
            int ypos = 10;
            for (int k = 0; k < ths.cart.NProducts; k++)
            {
                //orderPanel

                this.orderpanels[k] = new System.Windows.Forms.Panel();
                this.oid[k] = new System.Windows.Forms.Label();
                this.pname[k] = new System.Windows.Forms.Label();
                this.price[k] = new System.Windows.Forms.Label();
                this.categ[k] = new System.Windows.Forms.Label();
                this.payo[k] = new System.Windows.Forms.PictureBox();
                this.orderpic[k] = new System.Windows.Forms.PictureBox();
                this.cancel[k] = new System.Windows.Forms.PictureBox();
                this.buyl[k] = new System.Windows.Forms.Label();

                this.Controls.Add(orderpanels[k]);

                orderpanels[k].Controls.Add(this.oid[k]);
                orderpanels[k].Controls.Add(this.pname[k]);
                orderpanels[k].Controls.Add(this.price[k]);
                orderpanels[k].Controls.Add(this.categ[k]);
                orderpanels[k].Controls.Add(this.orderpic[k]);
                orderpanels[k].Controls.Add(this.cancel[k]);
                orderpanels[k].Controls.Add(this.payo[k]);
                orderpanels[k].Controls.Add(this.buyl[k]);

                int index = k;
                this.orderpanels[k].Location = new System.Drawing.Point(20, ypos);
                
                this.orderpanels[k].Name = ths.cart.Oids[k].ToString();
                this.orderpanels[k].Size = new System.Drawing.Size(558, 59);
                
                this.orderpanels[k].TabIndex = 2;
                this.orderpanels[k].BringToFront();
                this.orderpanels[k].BackColor = Color.Black;
                this.BringToFront();

                //oid
                this.oid[k].AutoSize = true;
                this.oid[k].Location = new System.Drawing.Point(13, 23);
                this.oid[k].Name = "oid" + k;
                this.oid[k].Size = new System.Drawing.Size(25, 13);
                this.oid[k].TabIndex = 1;
                this.oid[k].Text = ths.cart.Oids[k].ToString();
                this.oid[k].BringToFront();
                this.oid[k].ForeColor = Color.FromArgb(255,195,0);

                //name lab
                this.pname[k].AutoSize = true;
                this.pname[k].Location = new System.Drawing.Point(61, 23);
                this.pname[k].Name = "pname" + k;
                this.pname[k].Size = new System.Drawing.Size(35, 13);
                this.pname[k].TabIndex = 2;
                this.pname[k].Text = ths.cart.CartProducts[k].Pname;
                this.pname[k].ForeColor = Color.FromArgb(0, 255, 0);
                this.pname[k].BringToFront();

                //price
                // 
                this.price[k].AutoSize = true;
                this.price[k].Location = new System.Drawing.Point(151, 23);
                this.price[k].Name = "price"+k;
                this.price[k].Size = new System.Drawing.Size(35, 13);
                this.price[k].TabIndex = 3;
                this.price[k].Text = ths.cart.CartProducts[k].Price.ToString()+" Dh";
                this.price[k].ForeColor = Color.FromArgb(0, 255, 0);
                this.price[k].BringToFront();
                //category
                // 
                this.categ[k].AutoSize = true;
                this.categ[k].Location = new System.Drawing.Point(215, 23);
                this.categ[k].Name = "categ" + k;
                this.categ[k].Size = new System.Drawing.Size(35, 13);
                this.categ[k].TabIndex = 3;
                this.categ[k].Text = ths.cart.CartProducts[k].Category;
                this.categ[k].ForeColor = Color.FromArgb(0, 255, 0);
                this.categ[k].BringToFront();
                // orderedpic
                // 
                this.orderpic[k].Location = new System.Drawing.Point(270, 0);
                this.orderpic[k].Name = "orderpic" + k;
                this.orderpic[k].Size = new System.Drawing.Size(116, 59);
                this.orderpic[k].TabIndex = 6;
                this.orderpic[k].TabStop = false;
                this.orderpic[k].Image = Program.ByteToImage(ths.cart.CartProducts[k].Image);
                this.orderpic[k].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.orderpic[k].BringToFront();
                //buylab
                // 
                this.buyl[k].AutoSize = true;
                this.buyl[k].Location = new System.Drawing.Point(410, 23);
                this.buyl[k].Name = "buyl" + k;
                this.buyl[k].Size = new System.Drawing.Size(35, 13);
                this.buyl[k].TabIndex = 5;
                this.buyl[k].Text = "Buy";
                this.buyl[k].ForeColor = Color.FromArgb(0, 255, 0);
                this.buyl[k].BringToFront();
                // payo
                // 
                this.payo[k].Image = global::Demo.Properties.Resources.moneyg;
                this.payo[k].Location = new System.Drawing.Point(460, 13);
                this.payo[k].Name = "payo" + k;
                this.payo[k].Size = new System.Drawing.Size(35, 38);
                this.payo[k].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.payo[k].TabIndex = 3;
                this.payo[k].TabStop = false;
                this.payo[k].Cursor = Cursors.Hand;
                this.payo[k].BringToFront();
                this.payo[k].MouseLeave += (sen, EventArgs) => { this.payo_Leave(sender, EventArgs, index); };
                this.payo[k].MouseHover += (sen, EventArgs) => { this.payo_Hover(sender, EventArgs, index); };
                this.payo[k].Click += (sen, EventArgs) => { this.payo_Click(sender, EventArgs, index); };

                //
                // cancel
                // 
                this.cancel[k].Image = global::Demo.Properties.Resources.cancel;
                this.cancel[k].Location = new System.Drawing.Point(515, 13);
                this.cancel[k].Name = "cancel" + k;
                this.cancel[k].Size = new System.Drawing.Size(35, 38);
                this.cancel[k].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.cancel[k].TabIndex = 5;
                this.cancel[k].TabStop = false;
                this.cancel[k].Cursor = Cursors.Hand;
                this.cancel[k].BringToFront();
                this.cancel[k].Click += (sen, EventArgs) => { this.cancel_Click(sender, EventArgs, index); };
                this.cancel[k].MouseLeave += (sen, EventArgs) => { this.cancel_Leave(sender, EventArgs, index); };
                this.cancel[k].MouseHover += (sen, EventArgs) => { this.cancel_Hover(sender, EventArgs, index); };

                ypos += 75;
            }
        }
        void payo_Click(object sen, EventArgs e, int k)
        {
            if (ths.client.Balance > ths.cart.CartProducts[k].Price)
            {
                ths.cart.BuyOrder(ths.cart.CartProducts[k].Pid, ths.cart.Oids[k]);
                this.Dispose();
                this.CartForm_Load(sen, e);
                ths.cartp_Click(sen, e);
                Program.getData(ths);
            }
            else
            {
                MessageBox.Show("Insuffisant DH !");
                System.Diagnostics.Process.Start(@"D:\Projects\pharmaStore\Payment\index.html");
                using (XmlWriter writer = XmlWriter.Create(@"D:\Projects\pharmaStore\Payment\Order.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Product");
                    writer.WriteElementString("price", ths.cart.CartProducts[k].Price.ToString());
                    writer.WriteElementString("state", "pending");
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }


                XDocument xdoc = XDocument.Load(@"D:\Projects\pharmaStore\Payment\Order.xml");

                if (!File.Exists(@"D:\Projects\pharmaStore\Payment\Order.xml")) {
                        ths.cart.BuyOrder(ths.cart.CartProducts[k].Pid, ths.cart.Oids[k]);
                        this.Dispose();
                        this.CartForm_Load(sen, e);
                        ths.cartp_Click(sen, e);
                        //Program.getData(ths);
                }
            }
                
        }
        void cancel_Click(object sen, EventArgs e, int k)
        {
            ths.cart.CancelOrder(ths.cart.CartProducts[k].Pid, ths.cart.Oids[k]);
            this.Dispose();
            this.CartForm_Load(sen,e);
            ths.cartp_Click(sen, e);
        }
        public void payo_Hover(object sen, EventArgs e, int k)
        {
            this.payo[k].Size = new System.Drawing.Size(43, 48);
        }
        public void payo_Leave(object sen, EventArgs e, int k)
        {
            this.payo[k].Size = new System.Drawing.Size(35, 38);
        }
        public void cancel_Hover(object sen, EventArgs e, int k)
        {
            this.cancel[k].Size = new System.Drawing.Size(43, 48);
            
        }
        public void cancel_Leave(object sen, EventArgs e, int k)
        {
            this.cancel[k].Size = new System.Drawing.Size(35, 38);
        }
        Panel[] orderpanels;
         Label[] pname;
         Label[] price;
         Label[] oid;
         Label[] categ;
         PictureBox[] orderpic;
         PictureBox[] cancel;
         PictureBox[] payo;
         Label[] buyl ;

    }
}
