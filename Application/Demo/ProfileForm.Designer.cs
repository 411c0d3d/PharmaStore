using System.Windows.Forms;

namespace Demo
{
    partial class ProfileForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.namelab = new System.Windows.Forms.Label();
            this.emaillab = new System.Windows.Forms.Label();
            this.bHistorylab = new System.Windows.Forms.Label();
            this.balancelab = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.npbox = new System.Windows.Forms.TextBox();
            this.balancebox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changetitle = new System.Windows.Forms.Label();
            this.opwdlab = new System.Windows.Forms.Label();
            this.pwd1 = new System.Windows.Forms.Label();
            this.npwd2lab = new System.Windows.Forms.Label();
            this.opwd = new System.Windows.Forms.TextBox();
            this.npwd1 = new System.Windows.Forms.TextBox();
            this.npwd2 = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // namelab
            // 
            this.namelab.AutoSize = true;
            this.namelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.namelab.Location = new System.Drawing.Point(64, 76);
            this.namelab.Name = "namelab";
            this.namelab.Size = new System.Drawing.Size(54, 13);
            this.namelab.TabIndex = 0;
            this.namelab.Text = "Full Name";
            // 
            // emaillab
            // 
            this.emaillab.AutoSize = true;
            this.emaillab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.emaillab.Location = new System.Drawing.Point(64, 125);
            this.emaillab.Name = "emaillab";
            this.emaillab.Size = new System.Drawing.Size(32, 13);
            this.emaillab.TabIndex = 1;
            this.emaillab.Text = "Email";
            // 
            // bHistorylab
            // 
            this.bHistorylab.AutoSize = true;
            this.bHistorylab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.bHistorylab.Location = new System.Drawing.Point(64, 178);
            this.bHistorylab.Name = "bHistorylab";
            this.bHistorylab.Size = new System.Drawing.Size(108, 13);
            this.bHistorylab.TabIndex = 2;
            this.bHistorylab.Text = "Number of purchases";
            // 
            // balancelab
            // 
            this.balancelab.AutoSize = true;
            this.balancelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.balancelab.Location = new System.Drawing.Point(64, 230);
            this.balancelab.Name = "balancelab";
            this.balancelab.Size = new System.Drawing.Size(46, 13);
            this.balancelab.TabIndex = 3;
            this.balancelab.Text = "Balance";
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.Color.Black;
            this.namebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namebox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.ForeColor = System.Drawing.Color.Green;
            this.namebox.Location = new System.Drawing.Point(203, 73);
            this.namebox.Name = "namebox";
            this.namebox.ReadOnly = true;
            this.namebox.Size = new System.Drawing.Size(100, 17);
            this.namebox.TabIndex = 4;
            this.namebox.Text = F.client.Cname;
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.Color.Black;
            this.emailbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.emailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbox.ForeColor = System.Drawing.Color.Green;
            this.emailbox.Location = new System.Drawing.Point(203, 125);
            this.emailbox.Name = "emailbox";
            this.emailbox.ReadOnly = true;
            this.emailbox.Size = new System.Drawing.Size(100, 17);
            this.emailbox.TabIndex = 5;
            this.emailbox.Text = F.client.Email;
            // 
            // npbox
            // 
            this.npbox.BackColor = System.Drawing.Color.Black;
            this.npbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.npbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.npbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npbox.ForeColor = System.Drawing.Color.Green;
            this.npbox.Location = new System.Drawing.Point(203, 178);
            this.npbox.Name = "npbox";
            this.npbox.ReadOnly = true;
            this.npbox.Size = new System.Drawing.Size(100, 17);
            this.npbox.TabIndex = 6;
            this.npbox.Text = Program.get_Number_purchases(F.client).ToString();
            // 
            // balancebox
            // 
            this.balancebox.BackColor = System.Drawing.Color.Black;
            this.balancebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balancebox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.balancebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancebox.ForeColor = System.Drawing.Color.Green;
            this.balancebox.Location = new System.Drawing.Point(203, 230);
            this.balancebox.Name = "balancebox";
            this.balancebox.ReadOnly = true;
            this.balancebox.Size = new System.Drawing.Size(100, 17);
            this.balancebox.TabIndex = 7;
            this.balancebox.Text = F.client.Balance.ToString();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(321, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 257);
            this.panel1.TabIndex = 8;
            // 
            // changetitle
            // 
            this.changetitle.AutoSize = true;
            this.changetitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changetitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.changetitle.Location = new System.Drawing.Point(415, 15);
            this.changetitle.Name = "changetitle";
            this.changetitle.Size = new System.Drawing.Size(130, 18);
            this.changetitle.TabIndex = 9;
            this.changetitle.Text = "Change Password";
            // 
            // opwdlab
            // 
            this.opwdlab.AutoSize = true;
            this.opwdlab.BackColor = System.Drawing.Color.Black;
            this.opwdlab.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.opwdlab.Location = new System.Drawing.Point(356, 94);
            this.opwdlab.Name = "opwdlab";
            this.opwdlab.Size = new System.Drawing.Size(71, 13);
            this.opwdlab.TabIndex = 10;
            this.opwdlab.Text = "Old password";
            // 
            // pwd1
            // 
            this.pwd1.AutoSize = true;
            this.pwd1.BackColor = System.Drawing.Color.Black;
            this.pwd1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pwd1.Location = new System.Drawing.Point(356, 154);
            this.pwd1.Name = "pwd1";
            this.pwd1.Size = new System.Drawing.Size(77, 13);
            this.pwd1.TabIndex = 11;
            this.pwd1.Text = "New password";
            // 
            // npwd2lab
            // 
            this.npwd2lab.AutoSize = true;
            this.npwd2lab.BackColor = System.Drawing.Color.Black;
            this.npwd2lab.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.npwd2lab.Location = new System.Drawing.Point(356, 212);
            this.npwd2lab.Name = "npwd2lab";
            this.npwd2lab.Size = new System.Drawing.Size(113, 13);
            this.npwd2lab.TabIndex = 12;
            this.npwd2lab.Text = "Confirm new password";
            // 
            // opwd
            // 
            this.opwd.BackColor = System.Drawing.Color.Black;
            this.opwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.opwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.opwd.Location = new System.Drawing.Point(475, 90);
            this.opwd.MaximumSize = new System.Drawing.Size(100, 22);
            this.opwd.MinimumSize = new System.Drawing.Size(100, 22);
            this.opwd.Name = "opwd";
            this.opwd.PasswordChar = '#';
            this.opwd.Size = new System.Drawing.Size(100, 22);
            this.opwd.TabIndex = 13;
            // 
            // npwd1
            // 
            this.npwd1.BackColor = System.Drawing.Color.Black;
            this.npwd1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npwd1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.npwd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npwd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.npwd1.Location = new System.Drawing.Point(475, 150);
            this.npwd1.Name = "npwd1";
            this.npwd1.PasswordChar = '#';
            this.npwd1.Size = new System.Drawing.Size(100, 22);
            this.npwd1.TabIndex = 14;
            // 
            // npwd2
            // 
            this.npwd2.BackColor = System.Drawing.Color.Black;
            this.npwd2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.npwd2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.npwd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npwd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.npwd2.Location = new System.Drawing.Point(475, 208);
            this.npwd2.Name = "npwd2";
            this.npwd2.PasswordChar = '#';
            this.npwd2.Size = new System.Drawing.Size(100, 22);
            this.npwd2.TabIndex = 15;
            // 
            // submit
            // 
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.ForeColor = System.Drawing.Color.Green;
            this.submit.Location = new System.Drawing.Point(409, 272);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(121, 30);
            this.submit.TabIndex = 16;
            this.submit.Text = "Update";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.submit);
            this.Controls.Add(this.npwd2);
            this.Controls.Add(this.npwd1);
            this.Controls.Add(this.opwd);
            this.Controls.Add(this.npwd2lab);
            this.Controls.Add(this.pwd1);
            this.Controls.Add(this.opwdlab);
            this.Controls.Add(this.changetitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.balancebox);
            this.Controls.Add(this.npbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.balancelab);
            this.Controls.Add(this.bHistorylab);
            this.Controls.Add(this.emaillab);
            this.Controls.Add(this.namelab);
            this.Name = "ProfileForm";
            this.Size = new System.Drawing.Size(608, 335);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label namelab;
        private System.Windows.Forms.Label emaillab;
        private System.Windows.Forms.Label bHistorylab;
        private System.Windows.Forms.Label balancelab;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox npbox;
        private System.Windows.Forms.TextBox balancebox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label changetitle;
        private System.Windows.Forms.Label opwdlab;
        private System.Windows.Forms.Label pwd1;
        private System.Windows.Forms.Label npwd2lab;
        private System.Windows.Forms.TextBox opwd;
        private System.Windows.Forms.TextBox npwd1;
        private System.Windows.Forms.TextBox npwd2;
        private System.Windows.Forms.Button submit;
    }
}
