using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class preLogin : UserControl
    {
        Form1 ths;
        public preLogin(Form1 frm)
        {
            InitializeComponent();
            ths = frm;
        }

        private void adminB_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ths.loginForm1 = new Demo.loginForm(ths);

                ths.bgPanel.Controls.Add(ths.loginForm1);
                ths.loginForm1.BackColor = System.Drawing.Color.Transparent;
                ths.loginForm1.Location = new System.Drawing.Point(202, 141);
                ths.loginForm1.Name = "loginForm1";
                ths.loginForm1.Size = new System.Drawing.Size(306, 200);
                ths.loginForm1.TabIndex = 2;
                ths.loginForm1.titlelab.Text += "admin";
        }

        private void clientB_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ths.loginForm1 = new Demo.loginForm(ths);

            ths.bgPanel.Controls.Add(ths.loginForm1);
            ths.loginForm1.BackColor = System.Drawing.Color.Transparent;
            ths.loginForm1.Location = new System.Drawing.Point(202, 141);
            ths.loginForm1.Name = "loginForm1";
            ths.loginForm1.Size = new System.Drawing.Size(306, 200);
            ths.loginForm1.TabIndex = 2;
            ths.loginForm1.titlelab.Text += "client";
        }
        
    }
}
