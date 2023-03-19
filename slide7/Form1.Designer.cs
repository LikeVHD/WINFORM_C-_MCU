namespace slide7
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
            this.grbDangKy = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.dtpDangKy = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDangKy
            // 
            this.grbDangKy.Controls.Add(this.dtpDangKy);
            this.grbDangKy.Controls.Add(this.btnDangKy);
            this.grbDangKy.Controls.Add(this.txtTuoi);
            this.grbDangKy.Controls.Add(this.txtPhone);
            this.grbDangKy.Controls.Add(this.lblNgayDangKy);
            this.grbDangKy.Controls.Add(this.lblTuoi);
            this.grbDangKy.Controls.Add(this.lblPhone);
            this.grbDangKy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDangKy.Location = new System.Drawing.Point(12, 12);
            this.grbDangKy.Name = "grbDangKy";
            this.grbDangKy.Size = new System.Drawing.Size(422, 358);
            this.grbDangKy.TabIndex = 0;
            this.grbDangKy.TabStop = false;
            this.grbDangKy.Text = "Thông tin đăng ký";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(25, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 25);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            //this.lblPhone.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTuoi
            // 
            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuoi.Location = new System.Drawing.Point(25, 126);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(57, 25);
            this.lblTuoi.TabIndex = 0;
            this.lblTuoi.Text = "Tuổi:";
            // 
            // lblNgayDangKy
            // 
            this.lblNgayDangKy.AutoSize = true;
            this.lblNgayDangKy.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDangKy.Location = new System.Drawing.Point(25, 180);
            this.lblNgayDangKy.Name = "lblNgayDangKy";
            this.lblNgayDangKy.Size = new System.Drawing.Size(141, 25);
            this.lblNgayDangKy.TabIndex = 0;
            this.lblNgayDangKy.Text = "Ngày đăng ký:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(175, 76);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 29);
            this.txtPhone.TabIndex = 0;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuoi.Location = new System.Drawing.Point(175, 122);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(200, 29);
            this.txtTuoi.TabIndex = 1;
            //this.txtTuoi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(213, 233);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(112, 36);
            this.btnDangKy.TabIndex = 3;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // dtpDangKy
            // 
            this.dtpDangKy.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDangKy.CustomFormat = "dd/MM/yyyy";
            this.dtpDangKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDangKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDangKy.Location = new System.Drawing.Point(175, 176);
            this.dtpDangKy.Name = "dtpDangKy";
            this.dtpDangKy.Size = new System.Drawing.Size(200, 29);
            this.dtpDangKy.TabIndex = 2;
            //this.dtpDangKy.ValueChanged += new System.EventHandler(this.dtpDangKy_ValueChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(446, 382);
            this.Controls.Add(this.grbDangKy);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký xem phim!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.grbDangKy.ResumeLayout(false);
            this.grbDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDangKy;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblNgayDangKy;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.DateTimePicker dtpDangKy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

