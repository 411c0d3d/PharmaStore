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
using System.Web;
using System.Configuration;

namespace Demo
{
    public partial class loginForm : UserControl
    {
        Form1 ths;
        public loginForm(Form1 frm)
        {
            ths = frm;
            InitializeComponent();
           
        }
        
        public void submit_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["Demo.Conn"].ConnectionString;
                if (conn == null)
                {
                    MessageBox.Show("error Connection");
                    return;
                }
                string email = "", pwd = "";
                string logError = "";
                bool error = false;
                string user = "";
                SqlCommand cmd = new SqlCommand();
                if (this.titlelab.Text.Contains("client"))
                {
                    cmd.CommandText = "select * from Client where email=@email and pwd=@pwd";
                    cmd.Connection = conn;
                    user = "client";
                }
                else if (this.titlelab.Text.Contains("admin"))
                {
                    cmd.CommandText = "select * from Admin where email=@email and pwd=@pwd";
                    cmd.Connection = conn;
                    user = "admin";
                }
                if (emailBox.Text.Trim().Length != 0)
                {
                    email = emailBox.Text.Trim();
                    if (cmd != null)
                        cmd.Parameters.AddWithValue("@email", email);
                }
                else
                {
                    logError = "Empty field : Email\n";
                    error = true;
                }
                if (pwdBox.Text.Trim().Length != 0)
                {
                    pwd = pwdBox.Text.Trim();
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                }
                else
                {
                    logError += "Empty field : Password\n";
                    error = true;
                }
                conn.Open();
                if (!error) { 
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            if (user.Contains("client"))
                            {
                                ths.client = new Client();
                                ths.client.Cid = (int)rdr["cid"];
                                ths.client.Cname = (string)rdr["cname"];
                                ths.client.Email = (string)rdr["email"];
                                ths.client.Pwd = (string)rdr["pwd"];
                                ths.client.Balance = (decimal)rdr["balance"];
                                ths.admin = null;
                            }
                            else if (user.Contains("admin"))
                            {
                                ths.admin = new Admin();
                                ths.client = null;
                                ths.admin.Aid = (int)rdr["aid"];
                                ths.admin.Aname = (string)rdr["aname"];
                                ths.admin.Email = (string)rdr["email"];
                                ths.admin.Pwd = (string)rdr["pwd"];
                            }
                        }
                        rdr.Close();
                    }

                    
                    if (Demo.Program.getData(ths))
                    {
                        ths.home_Click(sender,e);
                        MessageBox.Show("Successfully connected !");
                        this.Dispose();
                        ths.loginPanel.Dispose();
                        ths.registerB.Dispose();
                        ths.registerIcon.Dispose();
                        ths.sidePanel.Controls.Add(ths.bHistoryB);
                        ths.sidePanel.Controls.Add(ths.bHistoryIcon);
                    }
                   
                        
                    if (ths.client != null)
                    {
                        if (ths.sidePanel.Contains(ths.editClient))
                        {
                            ths.editClient.Dispose();
                            ths.editClientIcon.Dispose();
                        }
                        //------------------------------------------------------------------------------------
                        //bHistory Button
                        ths.bHistoryB = new System.Windows.Forms.Button();
                        ths.bHistoryIcon = new System.Windows.Forms.PictureBox();

                        ths.sidePanel.Controls.Add(ths.bHistoryIcon);
                        ths.sidePanel.Controls.Add(ths.bHistoryB);

                        ths.bHistoryIcon.Image = Demo.Properties.Resources.historyg;
                        ths.bHistoryIcon.Location = new System.Drawing.Point(23, 283);
                        ths.bHistoryIcon.Name = "bHistoryIcon";
                        ths.bHistoryIcon.Size = new System.Drawing.Size(32, 44);
                        ths.bHistoryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        ths.bHistoryIcon.TabIndex = 8;
                        ths.bHistoryIcon.TabStop = false;
                        ths.bHistoryIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(ths.bHistoryIcon_MouseClick);
                        ths.bHistoryIcon.MouseLeave += new System.EventHandler(ths.bHistory_Leave);
                        ths.bHistoryIcon.MouseHover += new System.EventHandler(ths.bHistory_Hover);
                        //-------------------------------------------------------------------------------


                        ths.bHistoryB.FlatAppearance.BorderSize = 0;
                        ths.bHistoryB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        ths.bHistoryB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                        ths.bHistoryB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
                        ths.bHistoryB.Location = new System.Drawing.Point(12, 283);
                        ths.bHistoryB.Name = "bHistoryB";
                        ths.bHistoryB.Size = new System.Drawing.Size(188, 44);
                        ths.bHistoryB.TabIndex = 4;
                        ths.bHistoryB.Text = "              Buy History";
                        ths.bHistoryB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        ths.bHistoryB.UseVisualStyleBackColor = true;
                        ths.bHistoryB.Click += new System.EventHandler(ths.bHistory_Click);
                        ths.bHistoryB.MouseLeave += new System.EventHandler(ths.bHistory_Leave);
                        ths.bHistoryB.MouseHover += new System.EventHandler(ths.bHistory_Hover);
                        //------------------------------------------------------------------------------------
                        //Profile Button

                        ths.profileB = new System.Windows.Forms.Button();
                        ths.profileIcon = new System.Windows.Forms.PictureBox();

                        ths.sidePanel.Controls.Add(ths.profileIcon);
                        ths.sidePanel.Controls.Add(ths.profileB);

                        // profileB
                        // 
                        ths.profileB.FlatAppearance.BorderSize = 0;
                        ths.profileB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        ths.profileB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                        ths.profileB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
                        ths.profileB.Location = new System.Drawing.Point(16, 354);
                        ths.profileB.Name = "profileB";
                        ths.profileB.Size = new System.Drawing.Size(186, 44);
                        ths.profileB.TabIndex = 10;
                        ths.profileB.Text = "              Profile";
                        ths.profileB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        ths.profileB.UseVisualStyleBackColor = true;
                        ths.profileB.Click += new System.EventHandler(ths.profileB_Click);
                        ths.profileB.MouseLeave += new System.EventHandler(ths.profileB_Leave);
                        ths.profileB.MouseHover += new System.EventHandler(ths.profileB_Hover);
                        // 
                        // profileIcon
                        // 
                        ths.profileIcon.Image = Demo.Properties.Resources.avatarg;
                        ths.profileIcon.Location = new System.Drawing.Point(23, 354);
                        ths.profileIcon.Name = "profileIcon";
                        ths.profileIcon.Size = new System.Drawing.Size(32, 44);
                        ths.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        ths.profileIcon.TabIndex = 11;
                        ths.profileIcon.TabStop = false;
                        ths.profileIcon.Click += new System.EventHandler(ths.profileIcon_Click);
                        ths.profileIcon.MouseLeave += new System.EventHandler(ths.profileB_Leave);
                        ths.profileIcon.MouseHover += new System.EventHandler(ths.profileB_Hover);

                        

                        //-------------------------------------------------------------------------------
                        //cart
                        ths.cartp = new System.Windows.Forms.Panel();
                        ths.cartvallab = new System.Windows.Forms.Label();
                        ths.cartlab = new System.Windows.Forms.Label();
                        ths.cartIcon = new System.Windows.Forms.PictureBox();
                        // 
                        ths.cartp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
                        ths.cartp.Controls.Add(ths.cartvallab);
                        ths.cartp.Controls.Add(ths.cartlab);
                        ths.cartp.Controls.Add(ths.cartIcon);
                        ths.cartp.Location = new System.Drawing.Point(854, 0);
                        ths.cartp.Name = "cart";
                        ths.cartp.Size = new System.Drawing.Size(69, 63);
                        ths.cartp.TabIndex = 2;
                        ths.cartp.MouseLeave += new System.EventHandler(ths.cart_Leave);
                        ths.cartp.MouseHover += new System.EventHandler(ths.cart_Hover);
                        ths.cartp.Click += new System.EventHandler(ths.cartp_Click);
                        // 
                        // cartvallab
                        // 
                        ths.cartvallab.AutoSize = true;
                        ths.cartvallab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        ths.cartvallab.ForeColor = System.Drawing.Color.Red;
                        ths.cartvallab.Location = new System.Drawing.Point(51, 47);
                        ths.cartvallab.Name = "cartvallab";
                        ths.cartvallab.Size = new System.Drawing.Size(14, 13);
                        ths.cartvallab.TabIndex = 3;
                        ths.cartvallab.Text = ths.cart.NProducts.ToString();
                        ths.cartvallab.MouseLeave += new System.EventHandler(ths.cart_Leave);
                        ths.cartvallab.MouseHover += new System.EventHandler(ths.cart_Hover);
                        ths.cartvallab.Click += new System.EventHandler(ths.cartp_Click);
                        // 
                        // cartlab
                        // 
                        ths.cartlab.AutoSize = true;
                        ths.cartlab.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
                        ths.cartlab.ForeColor = System.Drawing.Color.Black;
                        ths.cartlab.Location = new System.Drawing.Point(6, 45);
                        ths.cartlab.Name = "cartlab";
                        ths.cartlab.Size = new System.Drawing.Size(48, 18);
                        ths.cartlab.TabIndex = 3;
                        ths.cartlab.Text = "Cart";
                        ths.cartlab.MouseLeave += new System.EventHandler(ths.cart_Leave);
                        ths.cartlab.MouseHover += new System.EventHandler(ths.cart_Hover);
                        ths.cartlab.Click += new System.EventHandler(ths.cartp_Click);
                        //
                        // cartIcon
                        //
                        ths.cartIcon.Image = Demo.Properties.Resources.cart;
                        ths.cartIcon.Location = new System.Drawing.Point(12, 3);
                        ths.cartIcon.Name = "cartIcon";
                        ths.cartIcon.Size = new System.Drawing.Size(39, 42);
                        ths.cartIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        ths.cartIcon.TabIndex = 3;
                        ths.cartIcon.TabStop = false;
                        ths.cartIcon.MouseLeave += new System.EventHandler(ths.cart_Leave);
                        ths.cartIcon.MouseHover += new System.EventHandler(ths.cart_Hover);
                        ths.cartIcon.Click += new System.EventHandler(ths.cartp_Click);
                        ths.Controls.Add(ths.cartp);
                        ths.cartp.BringToFront();
                        
                    }
                    else if (ths.admin != null && ths.client == null)
                    {
                        //------------------------------------------------------------------------------------
                        //EditClinets Button
                        ths.editClient = new System.Windows.Forms.Button();
                        ths.editClientIcon = new System.Windows.Forms.PictureBox();

                        ths.sidePanel.Controls.Add(ths.editClientIcon);
                        ths.sidePanel.Controls.Add(ths.editClient);

                        ths.editClientIcon.Image = Demo.Properties.Resources.groupg;
                        ths.editClientIcon.Location = new System.Drawing.Point(23, 283);
                        ths.editClientIcon.Name = "editClientIcon";
                        ths.editClientIcon.Size = new System.Drawing.Size(32, 44);
                        ths.editClientIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        ths.editClientIcon.TabIndex = 8;
                        ths.editClientIcon.TabStop = false;
                        ths.editClientIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(ths.editClient_Click);
                        ths.editClientIcon.MouseLeave += new System.EventHandler(ths.editClient_Leave);
                        ths.editClientIcon.MouseHover += new System.EventHandler(ths.editClient_Hover);
                        //-------------------------------------------------------------------------------


                        ths.editClient.FlatAppearance.BorderSize = 0;
                        ths.editClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        ths.editClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                        ths.editClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
                        ths.editClient.Location = new System.Drawing.Point(12, 283);
                        ths.editClient.Name = "editClient";
                        ths.editClient.Size = new System.Drawing.Size(188, 44);
                        ths.editClient.TabIndex = 4;
                        ths.editClient.Text = "              Clients";
                        ths.editClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        ths.editClient.UseVisualStyleBackColor = true;
                        ths.editClient.Click += new System.EventHandler(ths.editClient_Click);
                        ths.editClient.MouseLeave += new System.EventHandler(ths.editClient_Leave);
                        ths.editClient.MouseHover += new System.EventHandler(ths.editClient_Hover);
                    }
                    //--------------------------------------------------------------------------------
                    // logout
                    ths.logoutPanel = new System.Windows.Forms.Panel();
                    ths.logoutlab = new System.Windows.Forms.Label();
                    ths.logoutIcon = new System.Windows.Forms.PictureBox();

                    // logoutPanel
                    // 
                    ths.logoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
                    ths.logoutPanel.Controls.Add(ths.logoutlab);
                    ths.logoutPanel.Controls.Add(ths.logoutIcon);
                    ths.logoutPanel.Location = new System.Drawing.Point(201, -1);
                    ths.logoutPanel.Name = "logoutPanel";
                    ths.logoutPanel.Size = new System.Drawing.Size(69, 63);
                    ths.logoutPanel.TabIndex = 5;
                    ths.logoutPanel.Click += new System.EventHandler(ths.logoutPanel_Click);
                    ths.logoutPanel.MouseLeave += new System.EventHandler(ths.logout_Leave);
                    ths.logoutPanel.MouseHover += new System.EventHandler(ths.logout_Hover);
                    // 
                    // logoutlab
                    // 
                    ths.logoutlab.AutoSize = true;
                    ths.logoutlab.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
                    ths.logoutlab.ForeColor = System.Drawing.Color.Black;
                    ths.logoutlab.Location = new System.Drawing.Point(3, 43);
                    ths.logoutlab.Name = "logoutlab";
                    ths.logoutlab.Size = new System.Drawing.Size(68, 18);
                    ths.logoutlab.TabIndex = 4;
                    ths.logoutlab.Text = "Logout";
                    ths.logoutlab.Click += new System.EventHandler(ths.logoutPanel_Click);
                    ths.logoutlab.MouseLeave += new System.EventHandler(ths.logout_Leave);
                    ths.logoutlab.MouseHover += new System.EventHandler(ths.logout_Hover);
                    // 
                    // logoutIcon
                    // 
                    ths.logoutIcon.BackColor = System.Drawing.Color.Transparent;
                    ths.logoutIcon.Image = global::Demo.Properties.Resources.logout;
                    ths.logoutIcon.Location = new System.Drawing.Point(13, 3);
                    ths.logoutIcon.Name = "logoutIcon";
                    ths.logoutIcon.Size = new System.Drawing.Size(42, 38);
                    ths.logoutIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    ths.logoutIcon.TabIndex = 3;
                    ths.logoutIcon.TabStop = false;
                    ths.logoutIcon.Click += new System.EventHandler(ths.logoutPanel_Click);
                    ths.logoutIcon.MouseLeave += new System.EventHandler(ths.logout_Leave);
                    ths.logoutIcon.MouseHover += new System.EventHandler(ths.logout_Hover);

                    ths.Controls.Add(ths.logoutPanel);
                    ths.logoutPanel.BringToFront();
                }
                else
                {
                    if (error == true)
                    {
                        MessageBox.Show("login Failed ! " + logError);
                    }
                    MessageBox.Show("login Failed ! \n Password or email wrong");
                }
                conn.Close();
            }
        }
    }
}
