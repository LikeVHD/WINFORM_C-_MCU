﻿namespace slide3
{
    partial class frmMes
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.SpringGreen;
            this.btnClick.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClick.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClick.Location = new System.Drawing.Point(101, 55);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(115, 40);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click vào đây!";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(286, 64);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 202);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnClick);
            this.Name = "frmMes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMes_FormClosing);
            this.Click += new System.EventHandler(this.button1_Click_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnThoat;
    }
}

