using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace slide6
{
    public partial class frmTapTa : Form
    {
        private SoundPlayer choiNhac;

        public frmTapTa()
        {
            InitializeComponent();
            choiNhac = new SoundPlayer(@"C:\Users\Administrator\Downloads\Compressed\pic-nang-ta\nhactap.wav");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            btnClick.Text = txtName.Text;
            if (picHa.Visible == false)
                btnClick.Text = txtName.Text + "! Click để hạ tạ đi cụ.";
            else
                btnClick.Text = txtName.Text + "! Click để nâng tạ đi cụ.";
        }

        private void frmTapTa_Load(object sender, EventArgs e)
        {
            picNang.Visible = false;
            picHa.Visible = true;
        }
        int count = 1;
        private void btnClick_Click(object sender, EventArgs e)
        {
            if (picNang.Visible == true)
            {
                picNang.Visible = false;
                picHa.Visible = true;
                btnClick.Text = btnClick.Text.Replace("hạ", "nâng");
                lblCount.Text = count.ToString();
                count++;
                if (count == 16)
                {
                    DialogResult result = MessageBox.Show("Cụ đã nâng đủ chỉ tiêu hôm nay, bạn có muốn nâng tiếp?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                        Close();
                }    
            }
            else
            {
                picNang.Visible = true;
                picHa.Visible = false;
                btnClick.Text = btnClick.Text.Replace("nâng", "hạ");
            }    
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void chkMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMusic.Checked == true)
                choiNhac.Play();
            else
                choiNhac.Stop();
        }

        private void frmTapTa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng ứng dụng?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
