using System;
using System.Windows.Forms;

namespace Demo
{
    partial class ClientsForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 28);
            this.dataGridView2.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(0, 255, 0);
            this.dataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView2.EnableHeadersVisualStyles = false;

            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 20;
            this.dataGridView2.Size = new System.Drawing.Size(555, 306);
            this.dataGridView2.TabIndex = 0;
            dataGridView2.CellClick += new DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.dataGridView2);
            this.Name = "ClientsForm";
            this.Size = new System.Drawing.Size(591, 352);
            this.Load += new System.EventHandler(this.ClientsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
        }


        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
