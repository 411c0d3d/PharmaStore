namespace Demo
{
    partial class registerForm
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
            this.namebox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.pwdbox = new System.Windows.Forms.TextBox();
            this.pwd2box = new System.Windows.Forms.TextBox();
            this.namelab = new System.Windows.Forms.Label();
            this.emaillab = new System.Windows.Forms.Label();
            this.pwdlab = new System.Windows.Forms.Label();
            this.pwd2lab = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.loglab = new System.Windows.Forms.Label();
            this.titlelab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.Color.Black;
            this.namebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.namebox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.namebox.Location = new System.Drawing.Point(163, 57);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(147, 20);
            this.namebox.TabIndex = 0;
            this.namebox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.Color.Black;
            this.emailbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.emailbox.Location = new System.Drawing.Point(163, 109);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(147, 20);
            this.emailbox.TabIndex = 1;
            this.emailbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // pwdbox
            // 
            this.pwdbox.BackColor = System.Drawing.Color.Black;
            this.pwdbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwdbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pwdbox.Location = new System.Drawing.Point(163, 161);
            this.pwdbox.Name = "pwdbox";
            this.pwdbox.PasswordChar = '#';
            this.pwdbox.Size = new System.Drawing.Size(147, 20);
            this.pwdbox.TabIndex = 2;
            this.pwdbox.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // pwd2box
            // 
            this.pwd2box.BackColor = System.Drawing.Color.Black;
            this.pwd2box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwd2box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pwd2box.Location = new System.Drawing.Point(163, 210);
            this.pwd2box.Name = "pwd2box";
            this.pwd2box.PasswordChar = '#';
            this.pwd2box.Size = new System.Drawing.Size(147, 20);
            this.pwd2box.TabIndex = 3;
            this.pwd2box.TextChanged += new System.EventHandler(this.inputbox_TextChanged);
            // 
            // namelab
            // 
            this.namelab.AutoSize = true;
            this.namelab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.namelab.Location = new System.Drawing.Point(51, 60);
            this.namelab.Name = "namelab";
            this.namelab.Size = new System.Drawing.Size(54, 13);
            this.namelab.TabIndex = 4;
            this.namelab.Text = "Full Name";
            // 
            // emaillab
            // 
            this.emaillab.AutoSize = true;
            this.emaillab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.emaillab.Location = new System.Drawing.Point(52, 112);
            this.emaillab.Name = "emaillab";
            this.emaillab.Size = new System.Drawing.Size(32, 13);
            this.emaillab.TabIndex = 5;
            this.emaillab.Text = "Email";
            // 
            // pwdlab
            // 
            this.pwdlab.AutoSize = true;
            this.pwdlab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pwdlab.Location = new System.Drawing.Point(52, 164);
            this.pwdlab.Name = "pwdlab";
            this.pwdlab.Size = new System.Drawing.Size(53, 13);
            this.pwdlab.TabIndex = 6;
            this.pwdlab.Text = "Password";
            // 
            // pwd2lab
            // 
            this.pwd2lab.AutoSize = true;
            this.pwd2lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pwd2lab.Location = new System.Drawing.Point(51, 213);
            this.pwd2lab.Name = "pwd2lab";
            this.pwd2lab.Size = new System.Drawing.Size(91, 13);
            this.pwd2lab.TabIndex = 7;
            this.pwd2lab.Text = "Confirm Password";
            // 
            // submit
            // 
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.ForeColor = System.Drawing.Color.Lime;
            this.submit.Location = new System.Drawing.Point(111, 275);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(121, 30);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // loglab
            // 
            this.loglab.AutoSize = true;
            this.loglab.BackColor = System.Drawing.Color.Black;
            this.loglab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loglab.ForeColor = System.Drawing.Color.Red;
            this.loglab.Location = new System.Drawing.Point(356, 128);
            this.loglab.MinimumSize = new System.Drawing.Size(150, 70);
            this.loglab.Name = "loglab";
            this.loglab.Size = new System.Drawing.Size(150, 70);
            this.loglab.TabIndex = 9;
            this.loglab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titlelab
            // 
            this.titlelab.AutoSize = true;
            this.titlelab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.titlelab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelab.ForeColor = System.Drawing.Color.Black;
            this.titlelab.Location = new System.Drawing.Point(55, 5);
            this.titlelab.MaximumSize = new System.Drawing.Size(300, 30);
            this.titlelab.MinimumSize = new System.Drawing.Size(300, 30);
            this.titlelab.Name = "titlelab";
            this.titlelab.Size = new System.Drawing.Size(300, 30);
            this.titlelab.TabIndex = 10;
            this.titlelab.Text = "Registration";
            this.titlelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(341, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(14, 204);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(11, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 16);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(196, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 10);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(407, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Error Log";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(196, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(83, 10);
            this.panel4.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(196, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(83, 10);
            this.panel5.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.panel6.Location = new System.Drawing.Point(196, 229);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(83, 10);
            this.panel6.TabIndex = 19;
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlelab);
            this.Controls.Add(this.loglab);
            this.Controls.Add(this.pwd2lab);
            this.Controls.Add(this.pwdlab);
            this.Controls.Add(this.emaillab);
            this.Controls.Add(this.namelab);
            this.Controls.Add(this.pwd2box);
            this.Controls.Add(this.pwdbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.namebox);
            this.Name = "registerForm";
            this.Size = new System.Drawing.Size(519, 333);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox pwdbox;
        private System.Windows.Forms.TextBox pwd2box;
        private System.Windows.Forms.Label namelab;
        private System.Windows.Forms.Label emaillab;
        private System.Windows.Forms.Label pwdlab;
        private System.Windows.Forms.Label pwd2lab;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label loglab;
        private System.Windows.Forms.Label titlelab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}
