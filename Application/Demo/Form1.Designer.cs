namespace Demo
{
    public partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.registerIcon = new System.Windows.Forms.PictureBox();
            this.productsIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.registerB = new System.Windows.Forms.Button();
            this.productsB = new System.Windows.Forms.Button();
            this.homeB = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.welcomePanel = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginlab = new System.Windows.Forms.Label();
            this.loginIcon = new System.Windows.Forms.PictureBox();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.welcomePanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).BeginInit();
            this.bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Black;
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Controls.Add(this.panel8);
            this.sidePanel.Controls.Add(this.panel7);
            this.sidePanel.Controls.Add(this.panel6);
            this.sidePanel.Controls.Add(this.panel5);
            this.sidePanel.Controls.Add(this.registerIcon);
            this.sidePanel.Controls.Add(this.productsIcon);
            this.sidePanel.Controls.Add(this.homeIcon);
            this.sidePanel.Controls.Add(this.registerB);
            this.sidePanel.Controls.Add(this.productsB);
            this.sidePanel.Controls.Add(this.homeB);
            this.sidePanel.Controls.Add(this.pictureBox2);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(208, 466);
            this.sidePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "PHARMASTORE";
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(0, 354);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 44);
            this.panel8.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 283);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 44);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 211);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 44);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 44);
            this.panel5.TabIndex = 0;
            // 
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
            // productsIcon
            // 
            this.productsIcon.Image = global::Demo.Properties.Resources.categoryg;
            this.productsIcon.Location = new System.Drawing.Point(23, 211);
            this.productsIcon.Name = "productsIcon";
            this.productsIcon.Size = new System.Drawing.Size(41, 44);
            this.productsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productsIcon.TabIndex = 7;
            this.productsIcon.TabStop = false;
            this.productsIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.productsIcon_MouseClick);
            this.productsIcon.MouseLeave += new System.EventHandler(this.products_Leave);
            this.productsIcon.MouseHover += new System.EventHandler(this.products_Hover);
            // 
            // homeIcon
            // 
            this.homeIcon.Image = global::Demo.Properties.Resources.houseg;
            this.homeIcon.Location = new System.Drawing.Point(23, 141);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(41, 44);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeIcon.TabIndex = 6;
            this.homeIcon.TabStop = false;
            this.homeIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.homeIcon_MouseClick);
            this.homeIcon.MouseLeave += new System.EventHandler(this.home_Leave);
            this.homeIcon.MouseHover += new System.EventHandler(this.home_Hover);
            // 
            // registerB
            // 
            this.registerB.FlatAppearance.BorderSize = 0;
            this.registerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.registerB.ForeColor = System.Drawing.Color.Lime;
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
            // 
            // productsB
            // 
            this.productsB.FlatAppearance.BorderSize = 0;
            this.productsB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productsB.ForeColor = System.Drawing.Color.Lime;
            this.productsB.Location = new System.Drawing.Point(12, 211);
            this.productsB.Name = "productsB";
            this.productsB.Size = new System.Drawing.Size(188, 44);
            this.productsB.TabIndex = 3;
            this.productsB.Text = "              Products";
            this.productsB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productsB.UseVisualStyleBackColor = true;
            this.productsB.Click += new System.EventHandler(this.products_Click);
            this.productsB.MouseLeave += new System.EventHandler(this.products_Leave);
            this.productsB.MouseHover += new System.EventHandler(this.products_Hover);
            // 
            // homeB
            // 
            this.homeB.BackColor = System.Drawing.Color.Black;
            this.homeB.FlatAppearance.BorderSize = 0;
            this.homeB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.homeB.ForeColor = System.Drawing.Color.Lime;
            this.homeB.Location = new System.Drawing.Point(12, 141);
            this.homeB.Name = "homeB";
            this.homeB.Size = new System.Drawing.Size(188, 44);
            this.homeB.TabIndex = 1;
            this.homeB.Text = "              Home";
            this.homeB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeB.UseVisualStyleBackColor = false;
            this.homeB.Click += new System.EventHandler(this.home_Click);
            this.homeB.MouseLeave += new System.EventHandler(this.home_Leave);
            this.homeB.MouseHover += new System.EventHandler(this.home_Hover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Demo.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(49, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // welcomePanel
            // 
            this.welcomePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomePanel.BackColor = System.Drawing.Color.Lime;
            this.welcomePanel.Controls.Add(this.title);
            this.welcomePanel.Location = new System.Drawing.Point(201, 0);
            this.welcomePanel.Name = "welcomePanel";
            this.welcomePanel.Size = new System.Drawing.Size(722, 19);
            this.welcomePanel.TabIndex = 3;
            this.welcomePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(307, 1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(120, 16);
            this.title.TabIndex = 0;
            this.title.Text = "Welcome guest";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Lime;
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
            // 
            // bgPanel
            // 
            this.bgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bgPanel.BackgroundImage = global::Demo.Properties.Resources.bg;
            this.bgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgPanel.Controls.Add(this.closeIcon);
            this.bgPanel.Location = new System.Drawing.Point(201, 0);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(722, 466);
            this.bgPanel.TabIndex = 3;
            // 
            // closeIcon
            // 
            this.closeIcon.BackColor = System.Drawing.Color.Transparent;
            this.closeIcon.Image = ((System.Drawing.Image)(resources.GetObject("closeIcon.Image")));
            this.closeIcon.Location = new System.Drawing.Point(680, 424);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(30, 30);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeIcon.TabIndex = 1;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closer_Click);
            this.closeIcon.MouseLeave += new System.EventHandler(this.closer_Leave);
            this.closeIcon.MouseHover += new System.EventHandler(this.closer_hover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 466);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.welcomePanel);
            this.Controls.Add(this.bgPanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.welcomePanel.ResumeLayout(false);
            this.welcomePanel.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).EndInit();
            this.bgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox cartIcon;
        public System.Windows.Forms.Label cartlab;
        public System.Windows.Forms.Label cartvallab;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button homeB;
        private System.Windows.Forms.Button productsB;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox productsIcon;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.PictureBox loginIcon;
        private System.Windows.Forms.Label loginlab;
        private registerForm registerForm1;
        public Products productGrid;
        public System.Windows.Forms.Button registerB;
        public System.Windows.Forms.Panel bgPanel;
        public loginForm loginForm1;
        public System.Windows.Forms.Panel loginPanel;
        public System.Windows.Forms.PictureBox registerIcon;
        public System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel welcomePanel;
        public System.Windows.Forms.Panel sidePanel;
        public System.Windows.Forms.Panel cartp;
        public System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
    }
}

