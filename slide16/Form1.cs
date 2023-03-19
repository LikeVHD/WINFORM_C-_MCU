using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã tạo file mới");
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đã mở file");
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            mnuFileOpen.PerformClick();
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            mnuFileNew.PerformClick();
        }
    }
}
