namespace slide14_baitap
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
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.btnGameMoi = new System.Windows.Forms.Button();
            this.btnQuaySo = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTien = new System.Windows.Forms.Label();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(15, 12);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(100, 88);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "7";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(141, 12);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 88);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "7";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(270, 12);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(100, 88);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "7";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTien
            // 
            this.txtTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTien.Location = new System.Drawing.Point(199, 140);
            this.txtTien.Name = "txtTien";
            this.txtTien.ReadOnly = true;
            this.txtTien.Size = new System.Drawing.Size(171, 22);
            this.txtTien.TabIndex = 3;
            this.txtTien.Text = "100";
            this.txtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGameMoi
            // 
            this.btnGameMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameMoi.Location = new System.Drawing.Point(278, 205);
            this.btnGameMoi.Name = "btnGameMoi";
            this.btnGameMoi.Size = new System.Drawing.Size(92, 34);
            this.btnGameMoi.TabIndex = 4;
            this.btnGameMoi.Text = "Game Mới";
            this.btnGameMoi.UseVisualStyleBackColor = true;
            this.btnGameMoi.Click += new System.EventHandler(this.btnGameMoi_Click);
            // 
            // btnQuaySo
            // 
            this.btnQuaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaySo.Location = new System.Drawing.Point(13, 205);
            this.btnQuaySo.Name = "btnQuaySo";
            this.btnQuaySo.Size = new System.Drawing.Size(92, 34);
            this.btnQuaySo.TabIndex = 5;
            this.btnQuaySo.Text = "Quay Số";
            this.btnQuaySo.UseVisualStyleBackColor = true;
            this.btnQuaySo.Click += new System.EventHandler(this.btnQuaySo_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(149, 205);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(92, 34);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTien
            // 
            this.lblTien.AutoSize = true;
            this.lblTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTien.Location = new System.Drawing.Point(9, 140);
            this.lblTien.Name = "lblTien";
            this.lblTien.Size = new System.Drawing.Size(169, 20);
            this.lblTien.TabIndex = 7;
            this.lblTien.Text = "Tiền của người chơi:";
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(149, 269);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(92, 34);
            this.btnKetThuc.TabIndex = 8;
            this.btnKetThuc.Text = "Kết Thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 320);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.lblTien);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnQuaySo);
            this.Controls.Add(this.btnGameMoi);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trò Chơi Quay Số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Button btnGameMoi;
        private System.Windows.Forms.Button btnQuaySo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTien;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Timer timer1;
    }
}

