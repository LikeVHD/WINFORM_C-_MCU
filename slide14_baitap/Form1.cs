using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide14_baitap
{
    public partial class Form1 : Form
    {
        int TienNguoiChoi = 100;
        Random rd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            if (TienNguoiChoi < 20)
            {
                MessageBox.Show("Bạn không đủ tiền, vui lòng nạp thêm để chơi tiếp!");
            }
            else
            {
                // trừ tiền người chơi đi 20
                TienNguoiChoi -= 20;
                // Update tiền người chơi lên text box  
                txtTien.Text = TienNguoiChoi.ToString();
                //chạy start timer
                timer1.Start();
            }    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl1.Text = rd.Next(0, 8).ToString();   //chạy từ 0 đến 7
            lbl2.Text = rd.Next(0, 9).ToString();   //chạy từ 0 đến 8
            lbl3.Text = rd.Next(0, 10).ToString(); //chạy từ 0 đến 9
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //  timer1.Stop();
            if (lbl1.Text == "7")
                TienNguoiChoi += 30;
            if (lbl2.Text == "7")
                TienNguoiChoi += 40;
            if (lbl3.Text == "7")
                TienNguoiChoi += 50;
            //update tiền người chơi
            txtTien.Text = TienNguoiChoi.ToString();
        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            TienNguoiChoi = 100;
            txtTien.Text = TienNguoiChoi.ToString();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát trò chơi không?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
