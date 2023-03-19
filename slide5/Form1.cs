using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide5
{
    public partial class frmGroupBox : Form
    {
        public frmGroupBox()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (chkDuLich.Checked)
            //    MessageBox.Show("Có check Du Lịch");
            //else
            //    MessageBox.Show("Không check Du Lịch");
            if (radNam.Checked)
                MessageBox.Show("Bạn đã chọn Nam");
            else
                MessageBox.Show("Bạn chọn Nữ");
        }

        private void frmGroupBox_Load(object sender, EventArgs e)
        {
            radNam.Checked = true;
            radNu.Checked = false;
        }
    }
}
