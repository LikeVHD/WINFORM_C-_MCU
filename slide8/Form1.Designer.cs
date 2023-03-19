namespace slide8
{
    partial class frmDanhSach
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
            this.lstSo = new System.Windows.Forms.ListBox();
            this.lblSo = new System.Windows.Forms.Label();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnUpDate = new System.Windows.Forms.Button();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnLe = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnBinhPhuong = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.grbDanhSach.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSo
            // 
            this.lstSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSo.FormattingEnabled = true;
            this.lstSo.Location = new System.Drawing.Point(3, 16);
            this.lstSo.Name = "lstSo";
            this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSo.Size = new System.Drawing.Size(197, 330);
            this.lstSo.TabIndex = 0;
            this.lstSo.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblSo
            // 
            this.lblSo.AutoSize = true;
            this.lblSo.Location = new System.Drawing.Point(24, 21);
            this.lblSo.Name = "lblSo";
            this.lblSo.Size = new System.Drawing.Size(50, 13);
            this.lblSo.TabIndex = 1;
            this.lblSo.Text = "Nhập số:";
            this.lblSo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(101, 12);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(245, 20);
            this.txtSo.TabIndex = 2;
            this.txtSo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUpDate
            // 
            this.btnUpDate.Location = new System.Drawing.Point(364, 12);
            this.btnUpDate.Name = "btnUpDate";
            this.btnUpDate.Size = new System.Drawing.Size(75, 23);
            this.btnUpDate.TabIndex = 3;
            this.btnUpDate.Text = "Update";
            this.btnUpDate.UseVisualStyleBackColor = true;
            this.btnUpDate.Click += new System.EventHandler(this.btnUpDate_Click);
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.lstSo);
            this.grbDanhSach.Location = new System.Drawing.Point(27, 46);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(203, 349);
            this.grbDanhSach.TabIndex = 4;
            this.grbDanhSach.TabStop = false;
            this.grbDanhSach.Text = "Danh sách số";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnLe);
            this.grbChucNang.Controls.Add(this.btnChan);
            this.grbChucNang.Controls.Add(this.btnBinhPhuong);
            this.grbChucNang.Controls.Add(this.btnTangLen2);
            this.grbChucNang.Controls.Add(this.btnXoaDangChon);
            this.grbChucNang.Controls.Add(this.btnXoaDauCuoi);
            this.grbChucNang.Controls.Add(this.btnTong);
            this.grbChucNang.Location = new System.Drawing.Point(236, 46);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(203, 349);
            this.grbChucNang.TabIndex = 5;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Các phím chức năng";
            this.grbChucNang.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(26, 289);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(156, 23);
            this.btnLe.TabIndex = 0;
            this.btnLe.Text = "Chọn các số lẻ";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(26, 242);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(156, 23);
            this.btnChan.TabIndex = 0;
            this.btnChan.Text = "Chọn các số chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnBinhPhuong
            // 
            this.btnBinhPhuong.Location = new System.Drawing.Point(26, 204);
            this.btnBinhPhuong.Name = "btnBinhPhuong";
            this.btnBinhPhuong.Size = new System.Drawing.Size(156, 23);
            this.btnBinhPhuong.TabIndex = 0;
            this.btnBinhPhuong.Text = "Thay bằng bình phương";
            this.btnBinhPhuong.UseVisualStyleBackColor = true;
            this.btnBinhPhuong.Click += new System.EventHandler(this.btnBinhPhuong_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.Location = new System.Drawing.Point(26, 165);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(156, 23);
            this.btnTangLen2.TabIndex = 0;
            this.btnTangLen2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangLen2.UseVisualStyleBackColor = true;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.Location = new System.Drawing.Point(26, 121);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(156, 23);
            this.btnXoaDangChon.TabIndex = 0;
            this.btnXoaDangChon.Text = "Xoá phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;
            this.btnXoaDangChon.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(26, 83);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(156, 23);
            this.btnXoaDauCuoi.TabIndex = 0;
            this.btnXoaDauCuoi.Text = "Xoá phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(26, 41);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(156, 23);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tổng của danh sách";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Location = new System.Drawing.Point(27, 401);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(412, 37);
            this.btnKetThuc.TabIndex = 6;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmDanhSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.btnKetThuc;
            this.ClientSize = new System.Drawing.Size(464, 452);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.btnUpDate);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.lblSo);
            this.Name = "frmDanhSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDanhSach_FormClosing);
            this.grbDanhSach.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Label lblSo;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Button btnUpDate;
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnBinhPhuong;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTong;
    }
}

