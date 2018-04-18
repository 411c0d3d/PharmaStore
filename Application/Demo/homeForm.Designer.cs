using System.Drawing;
using System.Windows.Forms;

namespace Demo
{
    partial class homeForm
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
            this.Pr = new System.Windows.Forms.Panel();
            this.clab = new System.Windows.Forms.Label();
            this.qlab = new System.Windows.Forms.Label();
            this.nlab = new System.Windows.Forms.Label();
            this.plab = new System.Windows.Forms.Label();
            this.prB = new System.Windows.Forms.PictureBox();
            this.Pr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prB)).BeginInit();
            this.SuspendLayout();
            // 
            // Pr
            // 
            this.Pr.Controls.Add(this.clab);
            this.Pr.Controls.Add(this.prB);
            this.Pr.Controls.Add(this.qlab);
            this.Pr.Controls.Add(this.nlab);
            this.Pr.Controls.Add(this.plab);
            this.Pr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pr.Location = new System.Drawing.Point(68, 80);
            this.Pr.Name = rproduct.Pid.ToString();
            this.Pr.Size = new System.Drawing.Size(384, 283);
            this.Pr.TabIndex = 0;
            this.Pr.Click += new System.EventHandler(this.bPanel_click);
            this.Pr.MouseLeave += new System.EventHandler(this.bPanel_Leave);
            this.Pr.MouseHover += new System.EventHandler(this.bPanel_Hover);
            // 
            // clab
            // 
            this.clab.AutoSize = true;
            this.clab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.clab.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clab.Location = new System.Drawing.Point(87, 3);
            this.clab.Name = "clab";
            this.clab.Text = rproduct.Category;
            this.clab.Size = new System.Drawing.Size(0, 13);
            this.clab.TabIndex = 4;
            this.clab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clab.Click += new System.EventHandler(this.bPanel_click);
            this.clab.MouseLeave += new System.EventHandler(this.bPanel_Leave);
            this.clab.MouseHover += new System.EventHandler(this.bPanel_Hover);
            // 
            // qlab
            // 
            this.qlab.AutoSize = true;
            this.qlab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.qlab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.qlab.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlab.Location = new System.Drawing.Point(300, 228);
            this.qlab.MinimumSize = new System.Drawing.Size(30, 20);
            this.qlab.Name = "qlab";
            this.qlab.Text = rproduct.Quantity.ToString();
            this.qlab.Size = new System.Drawing.Size(30, 20);
            this.qlab.TabIndex = 3;
            this.qlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.qlab.Click += new System.EventHandler(this.bPanel_click);
            this.qlab.MouseLeave += new System.EventHandler(this.bPanel_Leave);
            this.qlab.MouseHover += new System.EventHandler(this.bPanel_Hover);
            // 
            // nlab
            // 
            this.nlab.AutoSize = true;
            this.nlab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nlab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.nlab.Location = new System.Drawing.Point(177, 228);
            this.nlab.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nlab.MinimumSize = new System.Drawing.Size(60, 20);
            this.nlab.Name = "nlab";
            this.nlab.Text = rproduct.Pname;
            this.nlab.Size = new System.Drawing.Size(60, 20);
            this.nlab.TabIndex = 2;
            this.nlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nlab.Click += new System.EventHandler(this.bPanel_click);
            this.nlab.MouseLeave += new System.EventHandler(this.bPanel_Leave);
            this.nlab.MouseHover += new System.EventHandler(this.bPanel_Hover);
            // 
            // plab
            // 
            this.plab.AutoSize = true;
            this.plab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.plab.Location = new System.Drawing.Point(54, 228);
            this.plab.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plab.MinimumSize = new System.Drawing.Size(60, 20);
            this.plab.Name = "plab";
            this.plab.Text = rproduct.Price.ToString() + " Dh";
            this.plab.Size = new System.Drawing.Size(60, 20);
            this.plab.TabIndex = 1;
            this.plab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plab.Click += new System.EventHandler(this.bPanel_click);
            this.plab.MouseLeave += new System.EventHandler(this.bPanel_Leave);
            this.plab.MouseHover += new System.EventHandler(this.bPanel_Hover);
            // 
            // prB
            // 
            this.prB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prB.Location = new System.Drawing.Point(49, 45);
            this.prB.MinimumSize = new System.Drawing.Size(247, 147);
            this.prB.Name = "prB";
            this.prB.Image = Program.ByteToImage(rproduct.Image);
            this.prB.Size = new System.Drawing.Size(281, 152);
            this.prB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prB.TabIndex = 0;
            this.prB.TabStop = false;
            this.prB.Click += new System.EventHandler(this.bPanel_click);
            this.prB.MouseLeave += new System.EventHandler(this.bPanel_Leave);
            this.prB.MouseHover += new System.EventHandler(this.bPanel_Hover);
            // 
            // homeForm
            // 
            this.Controls.Add(this.Pr);
            this.Name = "homeForm";
            this.Size = new System.Drawing.Size(518, 459);
            this.Pr.ResumeLayout(false);
            this.Pr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Product rproduct = Program.get_rand_Product();
        public Panel Pr = new Panel();
        PictureBox prB = new PictureBox();
        Label clab = new Label();
        Label plab = new Label();
        Label nlab = new Label();
        Label qlab = new Label();
    }
}




