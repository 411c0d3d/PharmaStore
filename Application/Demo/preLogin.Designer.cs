namespace Demo
{
    partial class preLogin
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
            this.adminB = new System.Windows.Forms.Button();
            this.clientB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminB
            // 
            this.adminB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.adminB.FlatAppearance.BorderSize = 0;
            this.adminB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminB.ForeColor = System.Drawing.Color.Black;
            this.adminB.Location = new System.Drawing.Point(15, 82);
            this.adminB.Name = "adminB";
            this.adminB.Size = new System.Drawing.Size(188, 74);
            this.adminB.TabIndex = 2;
            this.adminB.Text = "Admin";
            this.adminB.UseVisualStyleBackColor = false;
            this.adminB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminB.Click += new System.EventHandler(this.adminB_Click);
            // 
            // clientB
            // 
            this.clientB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.clientB.FlatAppearance.BorderSize = 0;
            this.clientB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientB.ForeColor = System.Drawing.Color.Black;
            this.clientB.Location = new System.Drawing.Point(250, 82);
            this.clientB.Name = "clientB";
            this.clientB.Size = new System.Drawing.Size(188, 74);
            this.clientB.TabIndex = 3;
            this.clientB.Text = "Client";
            this.clientB.UseVisualStyleBackColor = false;
            this.clientB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clientB.Click += new System.EventHandler(this.clientB_Click);
            // 
            // preLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.clientB);
            this.Controls.Add(this.adminB);
            this.Name = "preLogin";
            this.Size = new System.Drawing.Size(453, 267);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button adminB;
        private System.Windows.Forms.Button clientB;
    }
}
