using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSoNguyenB_Click(object sender, EventArgs e)
        {

        }

        private void txtSoNguyenA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoNguyenB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int hieu;
            //Console.WriteLine(txtA.Text);
            //Console.WriteLine(txtB.Text);
            hieu = int.Parse(txtA.Text) - int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " " + "- " + txtB.Text + " " + "= " + hieu + "";
        }
         
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong;
            //Console.WriteLine(txtA.Text);
            //Console.WriteLine(txtB.Text);
            tong = int.Parse(txtA.Text) + int.Parse(txtB.Text);
            lblKetQua.Text = txtA.Text + " " + "+ " + txtB.Text + " " + "= " + tong + "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn Reset?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lblKetQua.Text = "Bạn vừa ấn Reset";
                txtB.Text = "";
                txtA.Text = "";
            }    
        }
    }
}
