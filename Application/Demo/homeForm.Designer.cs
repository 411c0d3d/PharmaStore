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
            this.SuspendLayout();
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "homeForm";
            this.Size = new System.Drawing.Size(402, 272);
            this.ResumeLayout(false);

            this.Pr = new System.Windows.Forms.Panel();
            this.prB = new System.Windows.Forms.PictureBox();
            this.clab = new System.Windows.Forms.Label();
            this.nlab = new System.Windows.Forms.Label();
            this.qlab = new System.Windows.Forms.Label();
            this.plab = new System.Windows.Forms.Label();

            this.Pr.SuspendLayout();

            this.Pr.Controls.Add(this.clab);
            this.Pr.Controls.Add(this.qlab);
            this.Pr.Controls.Add(this.nlab);
            this.Pr.Controls.Add(this.plab);
            this.Pr.Controls.Add(this.prB);

            this.Pr.Location = new System.Drawing.Point(130, 70);
            this.Pr.Name = rproduct.Pid.ToString();
            this.Pr.Size = new System.Drawing.Size(246, 200);
            this.Pr.TabIndex = 0;
            this.Controls.Add(this.Pr);
            this.Pr.BringToFront();
            this.Pr.ResumeLayout(false);
            this.Pr.PerformLayout();

            //---------------------------------------------
            this.prB.Location = new System.Drawing.Point(15, 29);
            ((System.ComponentModel.ISupportInitialize)(this.prB)).BeginInit();
            this.Pr.Controls.Add(this.prB);
            if(rproduct.Image != null)
                this.prB.Image = Program.ByteToImage(rproduct.Image);
            this.prB.Name = "image";
            this.prB.SizeMode = PictureBoxSizeMode.StretchImage;
            this.prB.Size = new System.Drawing.Size(217, 127);
            this.prB.MinimumSize = new System.Drawing.Size(217, 127);
            this.prB.TabIndex = 0;
            this.prB.TabStop = false;
            this.Pr.Cursor = Cursors.Hand;
            this.prB.Cursor = Cursors.Hand;
            ((System.ComponentModel.ISupportInitialize)(this.prB)).EndInit();
            //---------------------------------------------
            this.clab.AutoSize = true;
            this.clab.Location = new System.Drawing.Point(95, 3);
            this.clab.Name = "category" ;
            this.clab.ForeColor = Color.FromArgb(0, 255, 0);
            this.clab.Size = new System.Drawing.Size(68, 20);
            this.clab.TabIndex = 4;
            this.clab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clab.Text = rproduct.Category;
            this.clab.Cursor = Cursors.Hand;
            //----------------------------------------------

            this.nlab.AutoSize = true;
            this.nlab.Location = new System.Drawing.Point(92, 171);
            this.nlab.MinimumSize = new System.Drawing.Size(60, 20);
            this.nlab.Name = "name";
            this.nlab.Size = new System.Drawing.Size(60, 20);
            this.nlab.ForeColor = Color.FromArgb(0, 255, 0);
            this.nlab.TabIndex = 2;
            this.nlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nlab.Text = rproduct.Pname;
            this.nlab.Cursor = Cursors.Hand;
            //-----------------------------------------------
            this.qlab.AutoSize = true;
            this.qlab.Location = new System.Drawing.Point(190, 171);
            this.qlab.MinimumSize = new System.Drawing.Size(30, 20);
            this.qlab.Name = "quantity" ;
            this.qlab.Size = new System.Drawing.Size(30, 20);
            this.qlab.ForeColor = Color.FromArgb(0, 255, 0);
            this.qlab.TabIndex = 3;
            this.qlab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.qlab.Text = rproduct.Quantity.ToString();
            this.qlab.Cursor = Cursors.Hand;
            //-----------------------------------------------
            this.plab.AutoSize = true;
            this.plab.Location = new System.Drawing.Point(6, 171);
            this.plab.MinimumSize = new System.Drawing.Size(60, 20);
            this.plab.Name = "price";
            this.plab.Size = new System.Drawing.Size(60, 20);
            this.plab.ForeColor = Color.FromArgb(0, 255, 0);
            this.plab.TabIndex = 1;
            this.plab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plab.Text = rproduct.Price.ToString();
            this.plab.Cursor = Cursors.Hand;
            //--------------------------------------------------

            this.Pr.Click += new System.EventHandler(bPanel_click);
            this.plab.Click += new System.EventHandler(bPanel_click);
            this.clab.Click += new System.EventHandler(bPanel_click);
            this.nlab.Click += new System.EventHandler(bPanel_click);
            this.qlab.Click += new System.EventHandler(bPanel_click);

            this.Pr.MouseLeave += new System.EventHandler(bPanel_Leave);
            this.plab.MouseLeave += new System.EventHandler(bPanel_Leave);
            this.clab.MouseLeave += new System.EventHandler(bPanel_Leave);
            this.nlab.MouseLeave += new System.EventHandler(bPanel_Leave);
            this.qlab.MouseLeave += new System.EventHandler(bPanel_Leave);

            this.Pr.MouseHover += new System.EventHandler(bPanel_Hover);
            this.plab.MouseHover += new System.EventHandler(bPanel_Hover);
            this.clab.MouseHover += new System.EventHandler(bPanel_Hover);
            this.nlab.MouseHover += new System.EventHandler(bPanel_Hover);
            this.qlab.MouseHover += new System.EventHandler(bPanel_Hover);

            this.prB.MouseHover += new System.EventHandler(bPanel_Hover);
            this.prB.MouseLeave += new System.EventHandler(bPanel_Leave);
            this.prB.Click += new System.EventHandler(bPanel_click);
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
