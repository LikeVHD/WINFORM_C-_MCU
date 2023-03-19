namespace slide12
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenForm4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenForm1,
            this.mnuOpenForm2,
            this.mnuOpenForm3,
            this.mnuOpenForm4});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // mnuOpenForm1
            // 
            this.mnuOpenForm1.Name = "mnuOpenForm1";
            this.mnuOpenForm1.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm1.Text = "Form 1";
            this.mnuOpenForm1.Click += new System.EventHandler(this.mnuOpenForm1_Click);
            // 
            // mnuOpenForm2
            // 
            this.mnuOpenForm2.Name = "mnuOpenForm2";
            this.mnuOpenForm2.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm2.Text = "Form 2";
            // 
            // mnuOpenForm3
            // 
            this.mnuOpenForm3.Name = "mnuOpenForm3";
            this.mnuOpenForm3.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm3.Text = "Form 3";
            // 
            // mnuOpenForm4
            // 
            this.mnuOpenForm4.Name = "mnuOpenForm4";
            this.mnuOpenForm4.Size = new System.Drawing.Size(180, 22);
            this.mnuOpenForm4.Text = "Form 4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aloToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // aloToolStripMenuItem
            // 
            this.aloToolStripMenuItem.Name = "aloToolStripMenuItem";
            this.aloToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aloToolStripMenuItem.Text = "Alo";
            this.aloToolStripMenuItem.Click += new System.EventHandler(this.aloToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 438);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm1;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm2;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm3;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenForm4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aloToolStripMenuItem;
    }
}

