using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.Aqua;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button btn = contextMenuStrip1.SourceControl as Button;
            btn.BackColor = Color.White;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Random rd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                btn.Text = rd.Next(500) + "";
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {

        }
    }
}
