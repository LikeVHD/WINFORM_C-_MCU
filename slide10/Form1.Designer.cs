namespace slide10
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
            this.chklbDanhSach = new System.Windows.Forms.CheckedListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChkIn = new System.Windows.Forms.Button();
            this.btnCheckedItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chklbDanhSach
            // 
            this.chklbDanhSach.FormattingEnabled = true;
            this.chklbDanhSach.Items.AddRange(new object[] {
            "san pham 1",
            "san pham 2",
            "san pham 3",
            "phan tu 4"});
            this.chklbDanhSach.Location = new System.Drawing.Point(57, 49);
            this.chklbDanhSach.Name = "chklbDanhSach";
            this.chklbDanhSach.Size = new System.Drawing.Size(120, 94);
            this.chklbDanhSach.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(269, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChkIn
            // 
            this.btnChkIn.Location = new System.Drawing.Point(269, 106);
            this.btnChkIn.Name = "btnChkIn";
            this.btnChkIn.Size = new System.Drawing.Size(75, 23);
            this.btnChkIn.TabIndex = 2;
            this.btnChkIn.Text = "Checked In";
            this.btnChkIn.UseVisualStyleBackColor = true;
            this.btnChkIn.Click += new System.EventHandler(this.btnChkIn_Click);
            // 
            // btnCheckedItem
            // 
            this.btnCheckedItem.Location = new System.Drawing.Point(254, 157);
            this.btnCheckedItem.Name = "btnCheckedItem";
            this.btnCheckedItem.Size = new System.Drawing.Size(90, 23);
            this.btnCheckedItem.TabIndex = 3;
            this.btnCheckedItem.Text = "Checked Item";
            this.btnCheckedItem.UseVisualStyleBackColor = true;
            this.btnCheckedItem.Click += new System.EventHandler(this.btnCheckedItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 385);
            this.Controls.Add(this.btnCheckedItem);
            this.Controls.Add(this.btnChkIn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chklbDanhSach);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbDanhSach;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChkIn;
        private System.Windows.Forms.Button btnCheckedItem;
    }
}

