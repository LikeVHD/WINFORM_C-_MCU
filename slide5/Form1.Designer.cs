namespace slide5
{
    partial class frmGroupBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkThichTatCa = new System.Windows.Forms.CheckBox();
            this.chkDuLich = new System.Windows.Forms.CheckBox();
            this.chkNgheNhac = new System.Windows.Forms.CheckBox();
            this.chkTheThao = new System.Windows.Forms.CheckBox();
            this.chkShopping = new System.Windows.Forms.CheckBox();
            this.chkXemPhim = new System.Windows.Forms.CheckBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.radNu);
            this.groupBox1.Controls.Add(this.radNam);
            this.groupBox1.Controls.Add(this.chkThichTatCa);
            this.groupBox1.Controls.Add(this.chkDuLich);
            this.groupBox1.Controls.Add(this.chkNgheNhac);
            this.groupBox1.Controls.Add(this.chkTheThao);
            this.groupBox1.Controls.Add(this.chkShopping);
            this.groupBox1.Controls.Add(this.chkXemPhim);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox1.Location = new System.Drawing.Point(65, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(400, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sở thích";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkThichTatCa
            // 
            this.chkThichTatCa.AutoSize = true;
            this.chkThichTatCa.Location = new System.Drawing.Point(89, 215);
            this.chkThichTatCa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkThichTatCa.Name = "chkThichTatCa";
            this.chkThichTatCa.Size = new System.Drawing.Size(117, 23);
            this.chkThichTatCa.TabIndex = 5;
            this.chkThichTatCa.Text = "Thích tất cả";
            this.chkThichTatCa.UseVisualStyleBackColor = true;
            // 
            // chkDuLich
            // 
            this.chkDuLich.AutoSize = true;
            this.chkDuLich.Location = new System.Drawing.Point(89, 179);
            this.chkDuLich.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDuLich.Name = "chkDuLich";
            this.chkDuLich.Size = new System.Drawing.Size(81, 23);
            this.chkDuLich.TabIndex = 4;
            this.chkDuLich.Text = "Du lịch";
            this.chkDuLich.UseVisualStyleBackColor = true;
            // 
            // chkNgheNhac
            // 
            this.chkNgheNhac.AutoSize = true;
            this.chkNgheNhac.Location = new System.Drawing.Point(89, 145);
            this.chkNgheNhac.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkNgheNhac.Name = "chkNgheNhac";
            this.chkNgheNhac.Size = new System.Drawing.Size(106, 23);
            this.chkNgheNhac.TabIndex = 3;
            this.chkNgheNhac.Text = "Nghe nhạc";
            this.chkNgheNhac.UseVisualStyleBackColor = true;
            this.chkNgheNhac.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkTheThao
            // 
            this.chkTheThao.AutoSize = true;
            this.chkTheThao.Location = new System.Drawing.Point(89, 112);
            this.chkTheThao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkTheThao.Name = "chkTheThao";
            this.chkTheThao.Size = new System.Drawing.Size(129, 23);
            this.chkTheThao.TabIndex = 2;
            this.chkTheThao.Text = "Chơi thể thao";
            this.chkTheThao.UseVisualStyleBackColor = true;
            // 
            // chkShopping
            // 
            this.chkShopping.AutoSize = true;
            this.chkShopping.Location = new System.Drawing.Point(89, 78);
            this.chkShopping.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkShopping.Name = "chkShopping";
            this.chkShopping.Size = new System.Drawing.Size(98, 23);
            this.chkShopping.TabIndex = 1;
            this.chkShopping.Text = "Shopping";
            this.chkShopping.UseVisualStyleBackColor = true;
            // 
            // chkXemPhim
            // 
            this.chkXemPhim.AutoSize = true;
            this.chkXemPhim.Location = new System.Drawing.Point(89, 45);
            this.chkXemPhim.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkXemPhim.Name = "chkXemPhim";
            this.chkXemPhim.Size = new System.Drawing.Size(103, 23);
            this.chkXemPhim.TabIndex = 0;
            this.chkXemPhim.Text = "Xem phim";
            this.chkXemPhim.UseVisualStyleBackColor = true;
            this.chkXemPhim.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCheck.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(501, 75);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(145, 72);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.ForeColor = System.Drawing.Color.Linen;
            this.radNam.Location = new System.Drawing.Point(89, 244);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(61, 23);
            this.radNam.TabIndex = 6;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("CN-ShellaL", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.ForeColor = System.Drawing.Color.Red;
            this.radNu.Location = new System.Drawing.Point(89, 273);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(78, 42);
            this.radNu.TabIndex = 7;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // frmGroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 452);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmGroupBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học về Group Box - LiveVHD";
            this.Load += new System.EventHandler(this.frmGroupBox_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkThichTatCa;
        private System.Windows.Forms.CheckBox chkDuLich;
        private System.Windows.Forms.CheckBox chkNgheNhac;
        private System.Windows.Forms.CheckBox chkTheThao;
        private System.Windows.Forms.CheckBox chkShopping;
        private System.Windows.Forms.CheckBox chkXemPhim;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
    }
}

