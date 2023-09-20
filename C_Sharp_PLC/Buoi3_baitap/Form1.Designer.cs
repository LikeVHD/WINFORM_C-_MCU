namespace Buoi3_baitap
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
            this.rad_Green = new System.Windows.Forms.RadioButton();
            this.bnt_Thoat = new System.Windows.Forms.Button();
            this.rad_Red = new System.Windows.Forms.RadioButton();
            this.rad_Blue = new System.Windows.Forms.RadioButton();
            this.rad_Black = new System.Windows.Forms.RadioButton();
            this.chk_Indam = new System.Windows.Forms.CheckBox();
            this.chk_Nghieng = new System.Windows.Forms.CheckBox();
            this.chk_Gach = new System.Windows.Forms.CheckBox();
            this.lbl_Input = new System.Windows.Forms.Label();
            this.lbl_Hienthi = new System.Windows.Forms.Label();
            this.txt_Input = new System.Windows.Forms.TextBox();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rad_Green
            // 
            this.rad_Green.AutoSize = true;
            this.rad_Green.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rad_Green.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Green.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rad_Green.Location = new System.Drawing.Point(19, 57);
            this.rad_Green.Name = "rad_Green";
            this.rad_Green.Size = new System.Drawing.Size(69, 23);
            this.rad_Green.TabIndex = 0;
            this.rad_Green.TabStop = true;
            this.rad_Green.Text = "Green";
            this.rad_Green.UseVisualStyleBackColor = false;
            this.rad_Green.CheckedChanged += new System.EventHandler(this.rad_Green_CheckedChanged);
            // 
            // bnt_Thoat
            // 
            this.bnt_Thoat.BackColor = System.Drawing.Color.Red;
            this.bnt_Thoat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_Thoat.Location = new System.Drawing.Point(321, 236);
            this.bnt_Thoat.Name = "bnt_Thoat";
            this.bnt_Thoat.Size = new System.Drawing.Size(89, 33);
            this.bnt_Thoat.TabIndex = 1;
            this.bnt_Thoat.Text = "Thoát";
            this.bnt_Thoat.UseVisualStyleBackColor = false;
            this.bnt_Thoat.Click += new System.EventHandler(this.bnt_Thoat_Click);
            // 
            // rad_Red
            // 
            this.rad_Red.AutoSize = true;
            this.rad_Red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rad_Red.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Red.ForeColor = System.Drawing.Color.Red;
            this.rad_Red.Location = new System.Drawing.Point(19, 32);
            this.rad_Red.Name = "rad_Red";
            this.rad_Red.Size = new System.Drawing.Size(55, 23);
            this.rad_Red.TabIndex = 2;
            this.rad_Red.TabStop = true;
            this.rad_Red.Text = "Red";
            this.rad_Red.UseVisualStyleBackColor = false;
            this.rad_Red.CheckedChanged += new System.EventHandler(this.rad_Red_CheckedChanged);
            // 
            // rad_Blue
            // 
            this.rad_Blue.AutoSize = true;
            this.rad_Blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rad_Blue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Blue.ForeColor = System.Drawing.Color.Blue;
            this.rad_Blue.Location = new System.Drawing.Point(19, 86);
            this.rad_Blue.Name = "rad_Blue";
            this.rad_Blue.Size = new System.Drawing.Size(58, 23);
            this.rad_Blue.TabIndex = 3;
            this.rad_Blue.TabStop = true;
            this.rad_Blue.Text = "Blue";
            this.rad_Blue.UseVisualStyleBackColor = false;
            this.rad_Blue.CheckedChanged += new System.EventHandler(this.rad_Blue_CheckedChanged);
            // 
            // rad_Black
            // 
            this.rad_Black.AutoSize = true;
            this.rad_Black.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rad_Black.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Black.Location = new System.Drawing.Point(19, 113);
            this.rad_Black.Name = "rad_Black";
            this.rad_Black.Size = new System.Drawing.Size(66, 23);
            this.rad_Black.TabIndex = 4;
            this.rad_Black.TabStop = true;
            this.rad_Black.Text = "Black";
            this.rad_Black.UseVisualStyleBackColor = false;
            this.rad_Black.CheckedChanged += new System.EventHandler(this.rad_Black_CheckedChanged);
            // 
            // chk_Indam
            // 
            this.chk_Indam.AutoSize = true;
            this.chk_Indam.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Indam.Location = new System.Drawing.Point(6, 32);
            this.chk_Indam.Name = "chk_Indam";
            this.chk_Indam.Size = new System.Drawing.Size(117, 21);
            this.chk_Indam.TabIndex = 5;
            this.chk_Indam.Text = "In đậm (Bold)";
            this.chk_Indam.UseVisualStyleBackColor = true;
            this.chk_Indam.CheckedChanged += new System.EventHandler(this.chk_Indam_CheckedChanged);
            // 
            // chk_Nghieng
            // 
            this.chk_Nghieng.AutoSize = true;
            this.chk_Nghieng.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Nghieng.Location = new System.Drawing.Point(6, 73);
            this.chk_Nghieng.Name = "chk_Nghieng";
            this.chk_Nghieng.Size = new System.Drawing.Size(143, 21);
            this.chk_Nghieng.TabIndex = 6;
            this.chk_Nghieng.Text = "In Nghiêng (Italic)";
            this.chk_Nghieng.UseVisualStyleBackColor = true;
            this.chk_Nghieng.CheckedChanged += new System.EventHandler(this.chk_Nghieng_CheckedChanged);
            // 
            // chk_Gach
            // 
            this.chk_Gach.AutoSize = true;
            this.chk_Gach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Gach.Location = new System.Drawing.Point(6, 109);
            this.chk_Gach.Name = "chk_Gach";
            this.chk_Gach.Size = new System.Drawing.Size(164, 21);
            this.chk_Gach.TabIndex = 7;
            this.chk_Gach.Text = "Gạch Chân (Underline)";
            this.chk_Gach.UseVisualStyleBackColor = true;
            this.chk_Gach.CheckedChanged += new System.EventHandler(this.chk_Gach_CheckedChanged);
            // 
            // lbl_Input
            // 
            this.lbl_Input.AutoSize = true;
            this.lbl_Input.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Input.Location = new System.Drawing.Point(34, 26);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(96, 19);
            this.lbl_Input.TabIndex = 8;
            this.lbl_Input.Text = "Input Chuỗi:";
            // 
            // lbl_Hienthi
            // 
            this.lbl_Hienthi.AutoSize = true;
            this.lbl_Hienthi.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hienthi.Location = new System.Drawing.Point(34, 246);
            this.lbl_Hienthi.Name = "lbl_Hienthi";
            this.lbl_Hienthi.Size = new System.Drawing.Size(77, 19);
            this.lbl_Hienthi.TabIndex = 9;
            this.lbl_Hienthi.Text = "Hiển Thị:";
            // 
            // txt_Input
            // 
            this.txt_Input.Location = new System.Drawing.Point(136, 26);
            this.txt_Input.Name = "txt_Input";
            this.txt_Input.Size = new System.Drawing.Size(274, 20);
            this.txt_Input.TabIndex = 10;
            this.txt_Input.TextChanged += new System.EventHandler(this.txt_Input_TextChanged);
            // 
            // lbl_Output
            // 
            this.lbl_Output.BackColor = System.Drawing.Color.LightGray;
            this.lbl_Output.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.Location = new System.Drawing.Point(129, 236);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(186, 29);
            this.lbl_Output.TabIndex = 11;
            this.lbl_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rad_Red);
            this.groupBox1.Controls.Add(this.rad_Blue);
            this.groupBox1.Controls.Add(this.rad_Black);
            this.groupBox1.Controls.Add(this.rad_Green);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 147);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
//            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.chk_Indam);
            this.groupBox2.Controls.Add(this.chk_Nghieng);
            this.groupBox2.Controls.Add(this.chk_Gach);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(240, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 147);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Font Chữ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 289);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.txt_Input);
            this.Controls.Add(this.lbl_Hienthi);
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.bnt_Thoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Định dạng chuỗi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rad_Green;
        private System.Windows.Forms.Button bnt_Thoat;
        private System.Windows.Forms.RadioButton rad_Red;
        private System.Windows.Forms.RadioButton rad_Blue;
        private System.Windows.Forms.RadioButton rad_Black;
        private System.Windows.Forms.CheckBox chk_Indam;
        private System.Windows.Forms.CheckBox chk_Nghieng;
        private System.Windows.Forms.CheckBox chk_Gach;
        private System.Windows.Forms.Label lbl_Input;
        private System.Windows.Forms.Label lbl_Hienthi;
        private System.Windows.Forms.TextBox txt_Input;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

