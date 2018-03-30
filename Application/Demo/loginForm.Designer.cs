namespace Demo
{
    partial class loginForm
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
            this.emaillab = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.titlelab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emaillab
            // 
            this.emaillab.AutoSize = true;
            this.emaillab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.emaillab.Location = new System.Drawing.Point(76, 65);
            this.emaillab.Name = "emaillab";
            this.emaillab.Size = new System.Drawing.Size(32, 13);
            this.emaillab.TabIndex = 1;
            this.emaillab.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(76, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // submit
            // 
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.ForeColor = System.Drawing.Color.Green;
            this.submit.Location = new System.Drawing.Point(107, 157);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(121, 30);
            this.submit.TabIndex = 9;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.Black;
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.emailBox.Location = new System.Drawing.Point(179, 62);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 22);
            this.emailBox.TabIndex = 11;
            // 
            // pwdBox
            // 
            this.pwdBox.BackColor = System.Drawing.Color.Black;
            this.pwdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwdBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.pwdBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pwdBox.Location = new System.Drawing.Point(179, 110);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.PasswordChar = '#';
            this.pwdBox.Size = new System.Drawing.Size(100, 22);
            this.pwdBox.TabIndex = 12;
            // 
            // titlelab
            // 
            this.titlelab.AutoSize = true;
            this.titlelab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.titlelab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelab.ForeColor = System.Drawing.Color.Black;
            this.titlelab.Location = new System.Drawing.Point(19, 0);
            this.titlelab.MaximumSize = new System.Drawing.Size(300, 30);
            this.titlelab.MinimumSize = new System.Drawing.Size(300, 30);
            this.titlelab.Name = "titlelab";
            this.titlelab.Size = new System.Drawing.Size(300, 30);
            this.titlelab.TabIndex = 13;
            this.titlelab.Text = "Login as ";
            this.titlelab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.titlelab);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emaillab);
            this.Name = "loginForm";
            this.Size = new System.Drawing.Size(340, 225);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label emaillab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox pwdBox;
        public System.Windows.Forms.Label titlelab;
    }
}
