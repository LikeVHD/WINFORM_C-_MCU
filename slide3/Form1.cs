using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide3
{
    public partial class frmMes : Form
    {
        public frmMes()
        {
            InitializeComponent();
        }
        #region Xử lý nút bấm
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã Click!", "Thông báo!", MessageBoxButtons.YesNo);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        #endregion
        private void frmMes_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn thoát?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;

        }
    }
}
