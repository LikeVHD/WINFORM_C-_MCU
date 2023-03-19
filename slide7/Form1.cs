using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Check thông tin đăng ký
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            bool check = true;
            errorProvider1.Clear();
            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Bạn chưa nhập Phone !");
                check = false;
             }    
            
            //Tuổi
            int tuoi;
            if (txtTuoi.Text == "")
            {
                errorProvider1.SetError(txtTuoi, "Bạn chưa nhập tuổi !");
                check = false;
            }    

            else if (int.TryParse(txtTuoi.Text, out tuoi) == false)
            {
                errorProvider1.SetError(txtTuoi, "Bạn nhập sai định dạng !");
                check = false;
            }
            else if (tuoi <= 17)
            {
                errorProvider1.SetError(txtTuoi, "Bạn chưa đủ tuổi xem phim này !");
                check = false;
            }

            //Kiểm tra ngày đăng ký
            if (dtpDangKy.Value.DayOfWeek == DayOfWeek.Monday)
            {
                errorProvider1.SetError(dtpDangKy, "Thứ 2 không chiếu phim này !");
                check = false;
            }

            //Thông báo đăng ký thành công
            if (check)
                MessageBox.Show("Bạn đã đăng ký thành công, xin cảm ơn !", "Thông báo");
         }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn dừng đăng ký?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
