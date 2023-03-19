namespace slide2
{
    partial class Form1
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
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblSoNguyenA = new System.Windows.Forms.Label();
            this.lblSoNguyenB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblKetQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKetQua.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Black;
            this.lblKetQua.Location = new System.Drawing.Point(0, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(502, 58);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblSoNguyenA
            // 
            this.lblSoNguyenA.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguyenA.ForeColor = System.Drawing.Color.Blue;
            this.lblSoNguyenA.Location = new System.Drawing.Point(49, 96);
            this.lblSoNguyenA.Name = "lblSoNguyenA";
            this.lblSoNguyenA.Size = new System.Drawing.Size(100, 23);
            this.lblSoNguyenA.TabIndex = 1;
            this.lblSoNguyenA.Text = "Số Nguyên a:";
            // 
            // lblSoNguyenB
            // 
            this.lblSoNguyenB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNguyenB.ForeColor = System.Drawing.Color.Blue;
            this.lblSoNguyenB.Location = new System.Drawing.Point(49, 137);
            this.lblSoNguyenB.Name = "lblSoNguyenB";
            this.lblSoNguyenB.Size = new System.Drawing.Size(100, 23);
            this.lblSoNguyenB.TabIndex = 2;
            this.lblSoNguyenB.Text = "Số Nguyên b:";
            //this.lblSoNguyenB.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(178, 96);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(240, 20);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(178, 140);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(240, 20);
            this.txtB.TabIndex = 4;
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.Cyan;
            this.btnTong.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(101, 181);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(75, 30);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "&Tổng";
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(223, 181);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "R&eset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHieu
            // 
            this.btnHieu.BackColor = System.Drawing.Color.Chartreuse;
            this.btnHieu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHieu.Location = new System.Drawing.Point(343, 181);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(75, 30);
            this.btnHieu.TabIndex = 7;
            this.btnHieu.Text = "&Hiệu";
            this.btnHieu.UseVisualStyleBackColor = false;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SlateBlue;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(223, 234);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(502, 296);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblSoNguyenB);
            this.Controls.Add(this.lblSoNguyenA);
            this.Controls.Add(this.lblKetQua);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính Tổng - Hiệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblSoNguyenA;
        private System.Windows.Forms.Label lblSoNguyenB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnThoat;
    }
}

