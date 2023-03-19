namespace slide6
{
    partial class frmTapTa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTapTa));
            this.picHa = new System.Windows.Forms.PictureBox();
            this.picNang = new System.Windows.Forms.PictureBox();
            this.lblNhapTen = new System.Windows.Forms.Label();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblDs = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNang)).BeginInit();
            this.SuspendLayout();
            // 
            // picHa
            // 
            this.picHa.Image = ((System.Drawing.Image)(resources.GetObject("picHa.Image")));
            this.picHa.Location = new System.Drawing.Point(13, 68);
            this.picHa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picHa.Name = "picHa";
            this.picHa.Size = new System.Drawing.Size(567, 369);
            this.picHa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picHa.TabIndex = 0;
            this.picHa.TabStop = false;
            // 
            // picNang
            // 
            this.picNang.Image = ((System.Drawing.Image)(resources.GetObject("picNang.Image")));
            this.picNang.Location = new System.Drawing.Point(13, 68);
            this.picNang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picNang.Name = "picNang";
            this.picNang.Size = new System.Drawing.Size(567, 369);
            this.picNang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picNang.TabIndex = 1;
            this.picNang.TabStop = false;
            this.picNang.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblNhapTen
            // 
            this.lblNhapTen.AutoSize = true;
            this.lblNhapTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapTen.Location = new System.Drawing.Point(13, 32);
            this.lblNhapTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhapTen.Name = "lblNhapTen";
            this.lblNhapTen.Size = new System.Drawing.Size(153, 16);
            this.lblNhapTen.TabIndex = 2;
            this.lblNhapTen.Text = "Nhập tên cụ vào đây:";
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMusic.Location = new System.Drawing.Point(514, 32);
            this.chkMusic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(66, 20);
            this.chkMusic.TabIndex = 3;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.chkMusic_CheckedChanged);
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.MintCream;
            this.btnClick.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClick.ForeColor = System.Drawing.Color.Red;
            this.btnClick.Location = new System.Drawing.Point(13, 443);
            this.btnClick.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(567, 45);
            this.btnClick.TabIndex = 4;
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(488, 494);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 36);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.LightSalmon;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(217, 494);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(159, 36);
            this.lblCount.TabIndex = 6;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // lblDs
            // 
            this.lblDs.AutoSize = true;
            this.lblDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDs.Location = new System.Drawing.Point(10, 514);
            this.lblDs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDs.Name = "lblDs";
            this.lblDs.Size = new System.Drawing.Size(160, 16);
            this.lblDs.TabIndex = 7;
            this.lblDs.Text = "Designed by LikeVHD";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(179, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(304, 20);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // frmTapTa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(589, 542);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDs);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.lblNhapTen);
            this.Controls.Add(this.picNang);
            this.Controls.Add(this.picHa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmTapTa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slide -  Tập tạ thôi anh em!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTapTa_FormClosing);
            this.Load += new System.EventHandler(this.frmTapTa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHa;
        private System.Windows.Forms.PictureBox picNang;
        private System.Windows.Forms.Label lblNhapTen;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblDs;
        private System.Windows.Forms.TextBox txtName;
    }
}

