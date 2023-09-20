using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát ?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rad_Black.Checked = true;
            chk_Nghieng.Checked = true;
        }

        private void txt_Input_TextChanged(object sender, EventArgs e)
        {
           lbl_Output.Text = txt_Input.Text;
        }

        private void rad_Red_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_Red.Checked == true)
                lbl_Output.ForeColor = rad_Red.ForeColor;
        }

        private void rad_Green_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_Green.Checked == true)
                lbl_Output.ForeColor = rad_Green.ForeColor;
        }

        private void rad_Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_Blue.Checked == true)
                lbl_Output.ForeColor = rad_Blue.ForeColor;
        }

        private void rad_Black_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_Black.Checked == true)
                lbl_Output.ForeColor = rad_Black.ForeColor;
        }

        private void chk_Indam_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Output.Font = new Font(
                lbl_Output.Font.Name,
                lbl_Output.Font.Size,
                lbl_Output.Font.Style ^FontStyle.Bold);
        }

        private void chk_Nghieng_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Output.Font = new Font(
                lbl_Output.Font.Name,
                 lbl_Output.Font.Size,
                lbl_Output.Font.Style ^ FontStyle.Italic);
        }

        private void chk_Gach_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Output.Font = new Font(
                lbl_Output.Font.Name,
                lbl_Output.Font.Size,
                lbl_Output.Font.Style ^ FontStyle.Underline);
        }
    }
}
