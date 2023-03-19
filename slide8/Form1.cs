using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide8
{
    public partial class frmDanhSach : Form
    {
        public frmDanhSach()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (lstSo.SelectedIndex != -1)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndex);
            }    
        }

        private void btnUpDate_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtSo.Text);
            lstSo.Items.Add(x);
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int i in lstSo.Items)
            tong += i;
            MessageBox.Show("Tổng của danh sách là: " + tong);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                lstSo.Items[i] = (int) lstSo.Items[i] + 2;
            }    
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                lstSo.Items[i] = (int) lstSo.Items[i] * (int) lstSo.Items[i];
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int k = (int)lstSo.Items[i];
                if (k%2 == 0)
                    lstSo.SelectedIndex = i;
            }
        }
        private void btnLe_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;
            for (int i  = 0; i < lstSo.Items.Count; i++)
            {
                int k = (int)lstSo.Items[i];
                if (k%2 != 0)
                    lstSo.SelectedIndex = i;
            }    
        }

        //private void frmDanhSach_FormClosed(object sender, FormClosedEventArgs e)
        //{

        //}

        private void frmDanhSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

    }
}
