namespace slide20
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapPath = new System.Windows.Forms.TextBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnTaoFile = new System.Windows.Forms.Button();
            this.btnTaoFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập đường dẫn vào ô bên dưới !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNhapPath
            // 
            this.txtNhapPath.Location = new System.Drawing.Point(39, 51);
            this.txtNhapPath.Name = "txtNhapPath";
            this.txtNhapPath.Size = new System.Drawing.Size(265, 20);
            this.txtNhapPath.TabIndex = 1;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(325, 48);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnTaoFile
            // 
            this.btnTaoFile.Location = new System.Drawing.Point(73, 103);
            this.btnTaoFile.Name = "btnTaoFile";
            this.btnTaoFile.Size = new System.Drawing.Size(75, 23);
            this.btnTaoFile.TabIndex = 3;
            this.btnTaoFile.Text = "Tạo File";
            this.btnTaoFile.UseVisualStyleBackColor = true;
            this.btnTaoFile.Click += new System.EventHandler(this.btnTaoFile_Click);
            // 
            // btnTaoFolder
            // 
            this.btnTaoFolder.Location = new System.Drawing.Point(195, 103);
            this.btnTaoFolder.Name = "btnTaoFolder";
            this.btnTaoFolder.Size = new System.Drawing.Size(75, 23);
            this.btnTaoFolder.TabIndex = 4;
            this.btnTaoFolder.Text = "Tạo Folder";
            this.btnTaoFolder.UseVisualStyleBackColor = true;
            this.btnTaoFolder.Click += new System.EventHandler(this.btnTaoFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 144);
            this.Controls.Add(this.btnTaoFolder);
            this.Controls.Add(this.btnTaoFile);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.txtNhapPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo file và thư mục hàng loạt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapPath;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnTaoFile;
        private System.Windows.Forms.Button btnTaoFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

