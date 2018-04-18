using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        
        public void home_Click(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.FromArgb(0, 255, 0);
            this.panel6.BackColor = Color.FromArgb(0, 0, 0);
            this.panel7.BackColor = Color.FromArgb(0, 0, 0);
            this.panel8.BackColor = Color.FromArgb(0, 0, 0);
            if (!this.bgPanel.Contains(this.hf))
            {
                this.hf = new Demo.homeForm(this);
                this.bgPanel.Controls.Add(this.hf);
                this.hf.Location = new System.Drawing.Point(95, 60);
                this.hf.BackColor = System.Drawing.Color.Transparent;
                this.hf.Name = "homeForm";
                this.hf.Size = new System.Drawing.Size(518, 459);
            }
            if (this.bgPanel.Contains(this.ep))
            {
                this.bgPanel.Controls.Remove(this.ep);
                this.ep.Dispose();
            }
            if (this.bgPanel.Contains(this.ec))
            {
                this.bgPanel.Controls.Remove(this.ec);
                this.ec.Dispose();
            }
            if (this.bgPanel.Contains(this.registerForm1))
            {
                this.bgPanel.Controls.Remove(registerForm1);
                this.registerForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.productGrid))
            {
                this.bgPanel.Controls.Remove(productGrid);
                this.productGrid.Dispose();
            }
            if (this.bgPanel.Contains(this.preLogin1))
            {
                this.bgPanel.Controls.Remove(this.preLogin1);
                this.preLogin1.Dispose();
            }
            if (this.bgPanel.Contains(this.loginForm1))
            {
                this.bgPanel.Controls.Remove(this.loginForm1);
                this.loginForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.cf))
            {
                this.bgPanel.Controls.Remove(this.cf);
                this.cf.Dispose();
            }
            if (this.bgPanel.Contains(this.bh))
            {
                this.bgPanel.Controls.Remove(this.bh);
                this.bh.Dispose();
            }
            if (this.bgPanel.Contains(this.pf))
            {
                this.bgPanel.Controls.Remove(this.pf);
                this.pf.Dispose();
            }
            if (this.bgPanel.Contains(this.clf))
            {
                this.bgPanel.Controls.Remove(this.clf);
                this.clf.Dispose();
            }
            if (this.bgPanel.Contains(this.ap))
            {
                this.bgPanel.Controls.Remove(this.ap);
                this.ap.Dispose();
            }

        }

        public void products_Click(object sender, EventArgs e)
        {
            if (this.bgPanel.Contains(this.clf))
            {
                this.bgPanel.Controls.Remove(this.clf);
                this.clf.Dispose();
            }
            this.panel6.BackColor = Color.FromArgb(0, 255, 0);
            this.panel5.BackColor = Color.FromArgb(0, 0, 0);
            this.panel7.BackColor = Color.FromArgb(0, 0, 0);
            this.panel8.BackColor = Color.FromArgb(0, 0, 0);
            if (this.bgPanel.Contains(this.hf))
            {
                this.bgPanel.Controls.Remove(this.hf);
                this.hf.Dispose();
            }
            if (this.bgPanel.Contains(this.ep))
            {
                this.bgPanel.Controls.Remove(this.ep);
                this.ep.Dispose();
            }
            if (this.bgPanel.Contains(this.ec))
            {
                this.bgPanel.Controls.Remove(this.ec);
                this.ec.Dispose();
            }
            if (this.bgPanel.Contains(this.bh))
            {
                this.bgPanel.Controls.Remove(this.bh);
                this.bh.Dispose();
            }
            if (this.bgPanel.Contains(this.loginForm1))
            {
                this.bgPanel.Controls.Remove(this.loginForm1);
                this.loginForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.preLogin1))
            {
                this.bgPanel.Controls.Remove(this.preLogin1);
                this.preLogin1.Dispose();
            }
            if (this.bgPanel.Contains(this.registerForm1))
            {
                this.bgPanel.Controls.Remove(registerForm1);
                this.registerForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.cf))
            {
                this.bgPanel.Controls.Remove(this.cf);
                this.cf.Dispose();
            }
            if (!this.bgPanel.Contains(productGrid))
            {
                productGrid = new Demo.Products(this);
                productGrid.BackColor = System.Drawing.Color.Black;
                productGrid.Location = new System.Drawing.Point(25, 50);
                productGrid.Name = "productGrid";
                productGrid.Size = new System.Drawing.Size(700, 379);
                productGrid.TabIndex = 2;
                bgPanel.Controls.Add(this.productGrid);
            }
            if (this.bgPanel.Contains(this.pf))
            {
                this.bgPanel.Controls.Remove(this.pf);
                this.pf.Dispose();
            }
            if (this.bgPanel.Contains(this.ap))
            {
                this.bgPanel.Controls.Remove(this.ap);
                this.ap.Dispose();
            }
        }

        public void bHistory_Click(object sender, EventArgs e)
        {
            this.panel7.BackColor = Color.FromArgb(0, 255, 0);
            this.panel5.BackColor = Color.FromArgb(0, 0, 0);
            this.panel6.BackColor = Color.FromArgb(0, 0, 0);
            this.panel8.BackColor = Color.FromArgb(0, 0, 0);
            if (this.bgPanel.Contains(this.clf))
            {
                this.bgPanel.Controls.Remove(this.clf);
                this.clf.Dispose();
            }
            if (this.bgPanel.Contains(this.hf))
            {
                this.bgPanel.Controls.Remove(this.hf);
                this.hf.Dispose();
            }
            if (this.bgPanel.Contains(this.ep))
            {
                this.bgPanel.Controls.Remove(this.ep);
                this.ep.Dispose();
            }
            if (this.bgPanel.Contains(this.ec))
            {
                this.bgPanel.Controls.Remove(this.ec);
                this.ec.Dispose();
            }
            if (this.bgPanel.Contains(this.loginForm1))
            {
                this.bgPanel.Controls.Remove(this.loginForm1);
                this.loginForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.productGrid))
            {
                this.bgPanel.Controls.Remove(productGrid);
                this.productGrid.Dispose();
            }
            if (this.bgPanel.Contains(this.registerForm1))
            {
                this.bgPanel.Controls.Remove(registerForm1);
                this.registerForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.cf))
            {
                this.bgPanel.Controls.Remove(this.cf);
                this.cf.Dispose();
            }
            if (!this.bgPanel.Contains(this.bh))
            {
                this.bh = new BuyHistory(this);
                this.bgPanel.Controls.Add(bh);
                this.bh.Location = new System.Drawing.Point(48, 65);
                this.bh.BringToFront();
            }
            if (this.bgPanel.Contains(this.pf))
            {
                this.bgPanel.Controls.Remove(this.pf);
                this.pf.Dispose();
            }
            if (this.bgPanel.Contains(this.ap))
            {
                this.bgPanel.Controls.Remove(this.ap);
                this.ap.Dispose();
            }
        }
        public void editClient_Click(object sender, EventArgs e)
        {
            this.panel7.BackColor = Color.FromArgb(0, 255, 0);
            this.panel5.BackColor = Color.FromArgb(0, 0, 0);
            this.panel6.BackColor = Color.FromArgb(0, 0, 0);
            this.panel8.BackColor = Color.FromArgb(0, 0, 0);
            if (this.bgPanel.Contains(this.hf))
            {
                this.bgPanel.Controls.Remove(this.hf);
                this.hf.Dispose();
            }
            if (this.bgPanel.Contains(this.ep))
            {
                this.bgPanel.Controls.Remove(this.ep);
                this.ep.Dispose();
            }
            if (this.bgPanel.Contains(this.ec))
            {
                this.bgPanel.Controls.Remove(this.ec);
                this.ec.Dispose();
            }
            if (this.bgPanel.Contains(this.loginForm1))
            {
                this.bgPanel.Controls.Remove(this.loginForm1);
                this.loginForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.productGrid))
            {
                this.bgPanel.Controls.Remove(productGrid);
                this.productGrid.Dispose();
            }
            if (this.bgPanel.Contains(this.registerForm1))
            {
                this.bgPanel.Controls.Remove(registerForm1);
                this.registerForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.cf))
            {
                this.bgPanel.Controls.Remove(this.cf);
                this.cf.Dispose();
            }
            if (!this.bgPanel.Contains(this.clf))
            {
                this.clf = new ClientsForm(this);
                this.bgPanel.Controls.Add(clf);
                this.clf.Location = new System.Drawing.Point(48, 65);
                this.clf.BringToFront();
            }
            if (this.bgPanel.Contains(this.pf))
            {
                this.bgPanel.Controls.Remove(this.pf);
                this.pf.Dispose();
            }
            if (this.bgPanel.Contains(this.ap))
            {
                this.bgPanel.Controls.Remove(this.ap);
                this.ap.Dispose();
            }
        }
        public void registerB_Click(object sender, EventArgs e)
        {
            this.panel7.BackColor = Color.FromArgb(0, 255, 0);
            this.panel5.BackColor = Color.FromArgb(0, 0, 0);
            this.panel6.BackColor = Color.FromArgb(0, 0, 0);
            this.panel8.BackColor = Color.FromArgb(0, 0, 0);
            if (this.bgPanel.Contains(this.clf))
            {
                this.bgPanel.Controls.Remove(this.clf);
                this.clf.Dispose();
            }
            if (this.bgPanel.Contains(this.hf))
            {
                this.bgPanel.Controls.Remove(this.hf);
                this.hf.Dispose();
            }
            if (this.bgPanel.Contains(this.loginForm1))
            {
                this.bgPanel.Controls.Remove(this.loginForm1);
                this.loginForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.preLogin1))
            {
                this.bgPanel.Controls.Remove(this.preLogin1);
                this.preLogin1.Dispose();
            }
            if (this.bgPanel.Contains(this.productGrid))
            {
                this.bgPanel.Controls.Remove(productGrid);
                this.productGrid.Dispose();
            }
            if (this.bgPanel.Contains(this.cf))
            {
                this.bgPanel.Controls.Remove(this.cf);
                this.cf.Dispose();
            }
            if (!this.bgPanel.Contains(this.registerForm1))
            {
                // registerForm1
                // 
                this.registerForm1 = new Demo.registerForm(this);
                this.bgPanel.Controls.Add(this.registerForm1);
                this.registerForm1.BackColor = System.Drawing.Color.Transparent;
                this.registerForm1.Location = new System.Drawing.Point(48, 65);
                this.registerForm1.Name = "registerForm1";
                this.registerForm1.Size = new System.Drawing.Size(519, 333);
                this.registerForm1.TabIndex = 2;
            }
            if (this.bgPanel.Contains(this.bh))
            {
                this.bgPanel.Controls.Remove(this.bh);
                this.bh.Dispose();
            }
            if (this.bgPanel.Contains(this.pf))
            {
                this.bgPanel.Controls.Remove(this.pf);
                this.pf.Dispose();
            }
            if (this.bgPanel.Contains(this.ep))
            {
                this.bgPanel.Controls.Remove(this.ep);
                this.ep.Dispose();
            }
            if (this.bgPanel.Contains(this.ec))
            {
                this.bgPanel.Controls.Remove(this.ec);
                this.ec.Dispose();
            }
            if (this.bgPanel.Contains(this.ap))
            {
                this.bgPanel.Controls.Remove(this.ap);
                this.ap.Dispose();
            }
        }

        public void profileB_Click(object sender, EventArgs e)
        {
            this.panel8.BackColor = Color.FromArgb(0, 255, 0);
            this.panel5.BackColor = Color.FromArgb(0, 0, 0);
            this.panel6.BackColor = Color.FromArgb(0, 0, 0);
            this.panel7.BackColor = Color.FromArgb(0, 0, 0);
            if (this.bgPanel.Contains(this.clf))
            {
                this.bgPanel.Controls.Remove(this.clf);
                this.clf.Dispose();
            }
            if (this.bgPanel.Contains(this.hf))
            {
                this.bgPanel.Controls.Remove(this.hf);
                this.hf.Dispose();
            }
            if (!this.bgPanel.Contains(this.pf))
            {
                pf = new Demo.ProfileForm(this);
                this.bgPanel.Controls.Add(this.pf);
                pf.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                pf.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                pf.BackColor = System.Drawing.Color.Transparent;
                pf.Location = new System.Drawing.Point(35, 65);
                pf.Name = "ProfileForm";
                pf.Size = new System.Drawing.Size(608, 335);
                this.pf.BringToFront();

            }
            if (this.bgPanel.Contains(this.ep))
            {
                this.bgPanel.Controls.Remove(this.ep);
                this.ep.Dispose();
            }
            if (this.bgPanel.Contains(this.ec))
            {
                this.bgPanel.Controls.Remove(this.ec);
                this.ec.Dispose();
            }
            if (this.bgPanel.Contains(this.bh))
            {
                this.bgPanel.Controls.Remove(this.bh);
                this.bh.Dispose();
            }
            if (this.bgPanel.Contains(this.registerForm1))
            {
                this.bgPanel.Controls.Remove(registerForm1);
                this.registerForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.productGrid))
            {
                this.bgPanel.Controls.Remove(productGrid);
                this.productGrid.Dispose();
            }
            if (this.bgPanel.Contains(this.loginForm1))
            {
                this.bgPanel.Controls.Remove(this.loginForm1);
                this.loginForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.cf))
            {
                this.bgPanel.Controls.Remove(this.cf);
                this.cf.Dispose();
            }
            if (this.bgPanel.Contains(this.ap))
            {
                this.bgPanel.Controls.Remove(this.ap);
                this.ap.Dispose();
            }

        }

        public void addProductB_Click(object sender, EventArgs e)
        {
            this.panel8.BackColor = Color.FromArgb(0, 255, 0);
            this.panel5.BackColor = Color.FromArgb(0, 0, 0);
            this.panel6.BackColor = Color.FromArgb(0, 0, 0);
            this.panel7.BackColor = Color.FromArgb(0, 0, 0);
            if (this.bgPanel.Contains(this.clf))
            {
                this.bgPanel.Controls.Remove(this.clf);
                this.clf.Dispose();
            }
            if (this.bgPanel.Contains(this.hf))
            {
                this.bgPanel.Controls.Remove(this.hf);
                this.hf.Dispose();
            }
            if(this.bgPanel.Contains(this.pf))
            {
                this.bgPanel.Controls.Remove(this.pf);
                this.pf.Dispose();
            }
            if (!this.bgPanel.Contains(this.ap))
            {
                this.ap = new Demo.addProduct(this);
                this.bgPanel.Controls.Add(this.ap);
                this.ap.BackColor = System.Drawing.Color.Transparent;
                this.ap.Location = new System.Drawing.Point(38, 32);
                this.ap.Name = "addProduct";
                this.ap.Size = new System.Drawing.Size(654, 392);
                this.ap.TabIndex = 2;
                this.ap.BringToFront();

            }
            if (this.bgPanel.Contains(this.ep))
            {
                this.bgPanel.Controls.Remove(this.ep);
                this.ep.Dispose();
            }
            if (this.bgPanel.Contains(this.ec))
            {
                this.bgPanel.Controls.Remove(this.ec);
                this.ec.Dispose();
            }
            if (this.bgPanel.Contains(this.bh))
            {
                this.bgPanel.Controls.Remove(this.bh);
                this.bh.Dispose();
            }
            if (this.bgPanel.Contains(this.registerForm1))
            {
                this.bgPanel.Controls.Remove(registerForm1);
                this.registerForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.productGrid))
            {
                this.bgPanel.Controls.Remove(productGrid);
                this.productGrid.Dispose();
            }
            if (this.bgPanel.Contains(this.loginForm1))
            {
                this.bgPanel.Controls.Remove(this.loginForm1);
                this.loginForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.cf))
            {
                this.bgPanel.Controls.Remove(this.cf);
                this.cf.Dispose();
            }
        }

        public void home_Hover(object sender, EventArgs e)
        {
            this.homeB.Cursor = Cursors.Hand;
            this.homeIcon.Cursor = Cursors.Hand;

            this.homeB.BackColor = Color.FromArgb(0, 255, 0);
            this.homeIcon.BackColor = Color.FromArgb(0, 229, 0);
            this.homeB.ForeColor = Color.FromArgb(0, 0, 0);
            this.homeIcon.Image = global::Demo.Properties.Resources.house;
        }
        public void home_Leave(object sender, EventArgs e)
        {
            this.homeB.BackColor = Color.FromArgb(0, 0, 0);
            this.homeIcon.BackColor= Color.FromArgb(0, 0, 0);
            this.homeB.ForeColor = Color.FromArgb(0, 255, 0);
            this.homeIcon.Image = global::Demo.Properties.Resources.houseg;
        }
        public void products_Hover(object sender, EventArgs e)
        {
            this.productsB.Cursor = Cursors.Hand;
            this.productsIcon.Cursor = Cursors.Hand;
            this.productsB.BackColor = Color.FromArgb(0, 255, 0);
            this.productsIcon.BackColor = Color.FromArgb(0, 229, 0);
            this.productsB.ForeColor = Color.FromArgb(0, 0, 0);
            this.productsIcon.Image = global::Demo.Properties.Resources.category;
        }
        public void products_Leave(object sender, EventArgs e)
        {
            this.productsB.BackColor = Color.FromArgb(0, 0, 0);
            this.productsIcon.BackColor = Color.FromArgb(0, 0, 0);
            this.productsB.ForeColor = Color.FromArgb(0, 255, 0);
            this.productsIcon.Image = global::Demo.Properties.Resources.categoryg;
        }
        public void bHistory_Hover(object sender, EventArgs e)
        {
            this.bHistoryB.Cursor = Cursors.Hand;
            this.bHistoryIcon.Cursor = Cursors.Hand;
            this.bHistoryB.BackColor = Color.FromArgb(0, 255, 0);
            this.bHistoryIcon.BackColor = Color.FromArgb(0, 229, 0);
            this.bHistoryB.ForeColor = Color.FromArgb(0, 0, 0);
            this.bHistoryIcon.Image = global::Demo.Properties.Resources.history;
        }
        
        public void bHistory_Leave(object sender, EventArgs e)
        {
            this.bHistoryB.BackColor = Color.FromArgb(0, 0, 0);
            this.bHistoryIcon.BackColor = Color.FromArgb(0, 0, 0);
            this.bHistoryB.ForeColor = Color.FromArgb(0, 255, 0);
            this.bHistoryIcon.Image = global::Demo.Properties.Resources.historyg;
        }
        public void editClient_Hover(object sender, EventArgs e)
        {
            this.editClient.Cursor = Cursors.Hand;
            this.editClientIcon.Cursor = Cursors.Hand;
            this.editClient.BackColor = Color.FromArgb(0, 255, 0);
            this.editClientIcon.BackColor = Color.FromArgb(0, 229, 0);
            this.editClient.ForeColor = Color.FromArgb(0, 0, 0);
            this.editClientIcon.Image = global::Demo.Properties.Resources.group;
        }
        public void editClient_Leave(object sender, EventArgs e)
        {
            this.editClient.BackColor = Color.FromArgb(0, 0, 0);
            this.editClientIcon.BackColor = Color.FromArgb(0, 0, 0);
            this.editClient.ForeColor = Color.FromArgb(0, 255, 0);
            this.editClientIcon.Image = global::Demo.Properties.Resources.groupg;
        }
        public void registerB_Hover(object sender, EventArgs e)
        {
            this.registerB.Cursor = Cursors.Hand;
            this.registerIcon.Cursor = Cursors.Hand;
            this.registerB.BackColor = Color.FromArgb(0, 255, 0);
            this.registerIcon.BackColor = Color.FromArgb(0, 229, 0);
            this.registerB.ForeColor = Color.FromArgb(0, 0, 0);
            this.registerIcon.Image = global::Demo.Properties.Resources.register;
        }
        public void registerB_Leave(object sender, EventArgs e)
        {
            this.registerB.BackColor = Color.FromArgb(0, 0, 0);
            this.registerB.ForeColor = Color.FromArgb(0, 255, 0);
            this.registerIcon.BackColor = Color.FromArgb(0, 0, 0);
            this.registerIcon.Image = global::Demo.Properties.Resources.registerg;
        }
        public void profileB_Hover(object sender, EventArgs e)
        {
            this.profileB.Cursor = Cursors.Hand;
            this.profileIcon.Cursor = Cursors.Hand;
            this.profileB.BackColor = Color.FromArgb(0, 255, 0);
            this.profileIcon.BackColor = Color.FromArgb(0, 229, 0);
            this.profileB.ForeColor = Color.FromArgb(0, 0, 0);
            this.profileIcon.Image = global::Demo.Properties.Resources.avatar;
        }
        public void addProductB_Hover(object sender, EventArgs e)
        {
            this.addProductB.Cursor = Cursors.Hand;
            this.addProductIcon.Cursor = Cursors.Hand;
            this.addProductB.BackColor = Color.FromArgb(0, 255, 0);
            this.addProductIcon.BackColor = Color.FromArgb(0, 229, 0);
            this.addProductB.ForeColor = Color.FromArgb(0, 0, 0);
            this.addProductIcon.Image = global::Demo.Properties.Resources.addP;
        }
        public void profileB_Leave(object sender, EventArgs e)
        {
            this.profileB.BackColor = Color.FromArgb(0, 0, 0);
            this.profileB.ForeColor = Color.FromArgb(0, 255, 0);
            this.profileIcon.BackColor = Color.FromArgb(0, 0, 0);
            this.profileIcon.Image = global::Demo.Properties.Resources.avatarg;
        }
        public void addProductB_Leave(object sender, EventArgs e)
        {
            this.addProductB.BackColor = Color.FromArgb(0, 0, 0);
            this.addProductB.ForeColor = Color.FromArgb(0, 255, 0);
            this.addProductIcon.BackColor = Color.FromArgb(0, 0, 0);
            this.addProductIcon.Image = global::Demo.Properties.Resources.addPg;
        }

        public void login_Hover(object sender, EventArgs e)
        {
            this.loginPanel.Cursor = Cursors.Hand;
            this.loginIcon.Cursor = Cursors.Hand;
            this.loginlab.Cursor = Cursors.Hand;

            this.loginPanel.BackColor = Color.FromArgb(0, 0, 0);
            this.loginIcon.BackColor = Color.FromArgb(0, 0, 0);
            this.loginlab.ForeColor = Color.FromArgb(0, 255, 0);
            this.loginIcon.Image = global::Demo.Properties.Resources.loging;
        }
        public void login_Leave(object sender, EventArgs e)
        {
            this.loginPanel.BackColor = Color.FromArgb(0, 255, 0);
            this.loginIcon.BackColor = Color.FromArgb(0, 255, 0);
            this.loginlab.ForeColor = Color.FromArgb(0, 0, 0);
            this.loginIcon.Image = global::Demo.Properties.Resources.login;
            
        }
        public void logout_Hover(object sender, EventArgs e)
        {
            this.logoutPanel.Cursor = Cursors.Hand;
            this.logoutIcon.Cursor = Cursors.Hand;
            this.logoutlab.Cursor = Cursors.Hand;

            this.logoutPanel.BackColor = Color.FromArgb(0, 0, 0);
            this.logoutIcon.BackColor = Color.FromArgb(0, 0, 0);
            this.logoutlab.ForeColor = Color.FromArgb(0, 255, 0);
            this.logoutIcon.Image = global::Demo.Properties.Resources.logoutg;
        }
        public void logout_Leave(object sender, EventArgs e)
        {
            this.logoutPanel.BackColor = Color.FromArgb(0, 255, 0);
            this.logoutIcon.BackColor = Color.FromArgb(0, 255, 0);
            this.logoutlab.ForeColor = Color.FromArgb(0, 0, 0);
            this.logoutIcon.Image = global::Demo.Properties.Resources.logout;

        }
        public void cart_Hover(object sender, EventArgs e)
        {
            this.cartp.Cursor = Cursors.Hand;
            this.cartIcon.Cursor = Cursors.Hand;
            this.cartlab.Cursor = Cursors.Hand;
            
            this.cartp.BackColor = Color.FromArgb(0, 0, 0);
            this.cartIcon.BackColor = Color.FromArgb(0, 0, 0);
            this.cartlab.ForeColor = Color.FromArgb(0, 255, 0);
            this.cartIcon.Image = global::Demo.Properties.Resources.cartg;
        }

        public void cart_Leave(object sender, EventArgs e)
        {
            this.cartp.BackColor = Color.FromArgb(0, 255, 0);
            this.cartIcon.BackColor = Color.FromArgb(0, 255, 0);
            this.cartlab.ForeColor = Color.FromArgb(0, 0, 0);
            this.cartIcon.Image = global::Demo.Properties.Resources.cart;

        }

        public void closer_hover(Object sender, EventArgs e)
        {
            this.closeIcon.Size = new Size(35, 35);
            this.closeIcon.Cursor = Cursors.Hand;
        }
        public void closer_Leave(Object sender, EventArgs e)
        {
            this.closeIcon.Size = new Size(30,30);
        }
        
        public void closer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void registerIcon_MouseClick(object sender, MouseEventArgs e)
        {
            registerB_Click(sender,e);
        }

        public void bHistoryIcon_MouseClick(object sender, MouseEventArgs e)
        {
            bHistory_Click(sender, e);
        }

        public void productsIcon_MouseClick(object sender, MouseEventArgs e)
        {
            products_Click(sender, e);
        }

        public void homeIcon_MouseClick(object sender, MouseEventArgs e)
        {
            home_Click(sender, e);
        }

        public void profileIcon_Click(object sender, EventArgs e)
        {
            profileB_Click(sender, e);
        }
          public void loginPanel_Click(object sender, EventArgs e)
        {
            this.panel5.BackColor = Color.FromArgb(0, 0, 0);
            this.panel6.BackColor = Color.FromArgb(0, 0, 0);
            this.panel7.BackColor = Color.FromArgb(0, 0, 0);
            this.panel8.BackColor = Color.FromArgb(0, 0, 0);
            if (this.bgPanel.Contains(this.clf))
            {
                this.bgPanel.Controls.Remove(this.clf);
                this.clf.Dispose();
            }
            if (this.bgPanel.Contains(this.hf))
            {
                this.bgPanel.Controls.Remove(this.hf);
                this.hf.Dispose();
            }
            if (this.bgPanel.Contains(this.pf))
            {
                this.bgPanel.Controls.Remove(this.pf);
                this.pf.Dispose();
            }
            if (!this.bgPanel.Contains(this.preLogin1))
            {
                this.preLogin1 = new Demo.preLogin(this);
                this.bgPanel.Controls.Add(this.preLogin1);
                // preLogin1
                // 
                this.preLogin1.BackColor = System.Drawing.Color.Transparent;
                this.preLogin1.Location = new System.Drawing.Point(126, 77);
                this.preLogin1.Name = "preLogin1";
                this.preLogin1.Size = new System.Drawing.Size(453, 267);
                this.preLogin1.TabIndex = 2;
            }
            if (this.bgPanel.Contains(this.loginForm1))
            {
                this.bgPanel.Controls.Remove(loginForm1);
                this.loginForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.registerForm1))
            {
                this.bgPanel.Controls.Remove(registerForm1);
                this.registerForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.productGrid))
            {
                this.bgPanel.Controls.Remove(productGrid);
                this.productGrid.Dispose();
            }
            if (this.bgPanel.Contains(this.cf))
            {
                this.bgPanel.Controls.Remove(this.cf);
                this.cf.Dispose();
            }
            if (this.bgPanel.Contains(this.ap))
            {
                this.bgPanel.Controls.Remove(this.ap);
                this.ap.Dispose();
            }
        }

        public void logoutPanel_Click(object sender, EventArgs e)
        {
            if(cartp!=null)
                this.cartp.Dispose();

            this.cartp = null;
            this.client = null;
            this.admin = null;
            this.panel5.BackColor = Color.FromArgb(0, 0, 0);
            this.panel6.BackColor = Color.FromArgb(0, 0, 0);
            this.panel7.BackColor = Color.FromArgb(0, 0, 0);
            this.panel8.BackColor = Color.FromArgb(0, 0, 0);
            logoutPanel.Dispose();
            if (bHistoryB != null)
            {
                this.bHistoryB.Dispose();
                this.bHistoryIcon.Dispose();
                this.profileB.Dispose();
                this.profileIcon.Dispose();
                
            }
            if (addProductB != null)
            {
                this.addProductIcon.Dispose();
                this.addProductB.Dispose();
                this.editClientIcon.Dispose();
                this.editClient.Dispose();
            }
            this.title.Text = "Welcome guest";
            //---------------------------------------------------

            this.registerIcon = new System.Windows.Forms.PictureBox();
            this.registerB = new System.Windows.Forms.Button();
            this.sidePanel.Controls.Add(this.registerIcon);
            this.sidePanel.Controls.Add(this.registerB);

            // registerIcon
            // 
            this.registerIcon.Image = global::Demo.Properties.Resources.registerg;
            this.registerIcon.Location = new System.Drawing.Point(23, 283);
            this.registerIcon.Name = "registerIcon";
            this.registerIcon.Size = new System.Drawing.Size(41, 44);
            this.registerIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.registerIcon.TabIndex = 9;
            this.registerIcon.TabStop = false;
            this.registerIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.registerIcon_MouseClick);
            this.registerIcon.MouseLeave += new System.EventHandler(this.registerB_Leave);
            this.registerIcon.MouseHover += new System.EventHandler(this.registerB_Hover);
            // 
            // registerB
            // 
            this.registerB.FlatAppearance.BorderSize = 0;
            this.registerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.registerB.Location = new System.Drawing.Point(12, 283);
            this.registerB.Name = "registerB";
            this.registerB.Size = new System.Drawing.Size(188, 44);
            this.registerB.TabIndex = 5;
            this.registerB.Text = "              Register";
            this.registerB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registerB.UseVisualStyleBackColor = true;
            this.registerB.Click += new System.EventHandler(this.registerB_Click);
            this.registerB.MouseLeave += new System.EventHandler(this.registerB_Leave);
            this.registerB.MouseHover += new System.EventHandler(this.registerB_Hover);

            this.registerB.BringToFront();
            this.registerIcon.BringToFront();
            //------------------------------------------------------------------------------
            //login

            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginlab = new System.Windows.Forms.Label();
            this.loginIcon = new System.Windows.Forms.PictureBox();
            this.Controls.Add(this.loginPanel);

            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.loginPanel.Controls.Add(this.loginlab);
            this.loginPanel.Controls.Add(this.loginIcon);
            this.loginPanel.Location = new System.Drawing.Point(201, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(69, 63);
            this.loginPanel.TabIndex = 4;
            this.loginPanel.Click += new System.EventHandler(this.loginPanel_Click);
            this.loginPanel.MouseLeave += new System.EventHandler(this.login_Leave);
            this.loginPanel.MouseHover += new System.EventHandler(this.login_Hover);
            // 
            // loginlab
            // 
            this.loginlab.AutoSize = true;
            this.loginlab.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.loginlab.ForeColor = System.Drawing.Color.Black;
            this.loginlab.Location = new System.Drawing.Point(6, 42);
            this.loginlab.Name = "loginlab";
            this.loginlab.Size = new System.Drawing.Size(58, 18);
            this.loginlab.TabIndex = 4;
            this.loginlab.Text = "Login";
            this.loginlab.Click += new System.EventHandler(this.loginPanel_Click);
            this.loginlab.MouseLeave += new System.EventHandler(this.login_Leave);
            this.loginlab.MouseHover += new System.EventHandler(this.login_Hover);
            // 
            // loginIcon
            // 
            this.loginIcon.BackColor = System.Drawing.Color.Transparent;
            this.loginIcon.Image = global::Demo.Properties.Resources.login;
            this.loginIcon.Location = new System.Drawing.Point(13, 3);
            this.loginIcon.Name = "loginIcon";
            this.loginIcon.Size = new System.Drawing.Size(42, 38);
            this.loginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginIcon.TabIndex = 3;
            this.loginIcon.TabStop = false;
            this.loginIcon.Click += new System.EventHandler(this.loginPanel_Click);
            this.loginIcon.MouseLeave += new System.EventHandler(this.login_Leave);
            this.loginIcon.MouseHover += new System.EventHandler(this.login_Hover);
            this.loginPanel.BringToFront();
            //---------------------------------------------------
            if (this.bgPanel.Contains(this.hf))
            {
                this.bgPanel.Controls.Remove(this.hf);
                this.hf.Dispose();
            }
            if (this.bgPanel.Contains(this.ep))
            {
                this.bgPanel.Controls.Remove(this.ep);
                this.ep.Dispose();
            }
            if (this.bgPanel.Contains(this.ec))
            {
                this.bgPanel.Controls.Remove(this.ec);
                this.ec.Dispose();
            }
            if (this.bgPanel.Contains(this.bh))
            {
                this.bgPanel.Controls.Remove(this.bh);
                this.bh.Dispose();
            }
            if (this.bgPanel.Contains(this.registerForm1))
            {
                this.bgPanel.Controls.Remove(registerForm1);
                this.registerForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.productGrid))
            {
                this.bgPanel.Controls.Remove(productGrid);
                this.productGrid.Dispose();
            }
            if (this.bgPanel.Contains(this.clf))
            {
                this.bgPanel.Controls.Remove(this.clf);
                this.clf.Dispose();
            }
            this.home_Click(sender,e);
        }
        
        public void cartp_Click(object sender ,EventArgs e)
        {
            if (this.bgPanel.Contains(this.clf))
            {
                this.bgPanel.Controls.Remove(this.clf);
                this.clf.Dispose();
            }
            if (this.bgPanel.Contains(this.hf))
            {
                this.bgPanel.Controls.Remove(this.hf);
                this.hf.Dispose();
            }
            if (this.bgPanel.Contains(this.ep))
            {
                this.bgPanel.Controls.Remove(this.ep);
                this.ep.Dispose();
            }
            if (this.bgPanel.Contains(this.ec))
            {
                this.bgPanel.Controls.Remove(this.ec);
                this.ec.Dispose();
            }
            if (this.bgPanel.Contains(this.pf))
            {
                this.bgPanel.Controls.Remove(this.pf);
                this.pf.Dispose();
            }
            if (this.bgPanel.Contains(this.bh))
            {
                this.bgPanel.Controls.Remove(this.bh);
                this.bh.Dispose();
            }
            if (this.bgPanel.Contains(this.registerForm1))
            {
                this.bgPanel.Controls.Remove(registerForm1);
                this.registerForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.productGrid))
            {
                this.bgPanel.Controls.Remove(productGrid);
                this.productGrid.Dispose();
            }
            if (this.bgPanel.Contains(this.preLogin1))
            {
                this.bgPanel.Controls.Remove(this.preLogin1);
                this.preLogin1.Dispose();
            }
            if (this.bgPanel.Contains(this.loginForm1))
            {
                this.bgPanel.Controls.Remove(this.loginForm1);
                this.loginForm1.Dispose();
            }
            if (this.bgPanel.Contains(this.ap))
            {
                this.bgPanel.Controls.Remove(this.ap);
                this.ap.Dispose();
            }
            if (!this.bgPanel.Contains(cf))
            {
                Demo.Program.getData(this);
                cf = new Demo.CartForm(this);
                cf.Location = new System.Drawing.Point(35, 65);
                cf.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                cf.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                cf.BackColor = System.Drawing.Color.Transparent;
                cf.Name = "CartForm";
                cf.Size = new System.Drawing.Size(620, 343);
                bgPanel.Controls.Add(this.cf);
                cf.AutoScroll = true;
                this.cf.BringToFront();
                if (this.cart.NProducts == 0)
                {
                    this.label1 = new System.Windows.Forms.Label();
                    // 
                    // label1
                    // 
                    this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
                    this.label1.Location = new System.Drawing.Point(107, 161);
                    this.label1.Name = "label1";
                    this.label1.Size = new System.Drawing.Size(373, 34);
                    this.label1.TabIndex = 0;
                    this.label1.Text = "Cart is still empty ... Click on [Products]";
                    this.cf.Controls.Add(label1);
                }
            }
        }
        public System.Windows.Forms.Button editClient;
        public System.Windows.Forms.PictureBox editClientIcon;
        public System.Windows.Forms.Button bHistoryB;
        public System.Windows.Forms.PictureBox bHistoryIcon;
        public System.Windows.Forms.PictureBox profileIcon;
        public System.Windows.Forms.Button profileB;
        public System.Windows.Forms.PictureBox addProductIcon;
        public System.Windows.Forms.Button addProductB;
        public System.Windows.Forms.Panel logoutPanel;
        public System.Windows.Forms.Label logoutlab;
        public System.Windows.Forms.PictureBox logoutIcon;
        public preLogin preLogin1;
        public Client client = new Client();
        public Client eClient;
        public Admin admin = new Admin();
        public Cart cart = new Cart();
        public CartForm cf;
        public BuyHistory bh;
        public ProfileForm pf;
        public EditProduct ep;
        public addProduct ap;
        public homeForm hf;
        public ClientsForm clf;
        public EditClient ec;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.home_Click(sender,e);
        }
    }
}