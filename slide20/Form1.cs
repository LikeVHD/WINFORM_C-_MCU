using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace slide20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            //check xem người dùng đã chọn thư mục chưa
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNhapPath.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn thư mục thành công!");
            }    
        }

        private void btnTaoFile_Click(object sender, EventArgs e)
        {
            if (txtNhapPath.Text != "")
            {
                //Check thư mục có tồn tại hay không? Nếu không thì báo lỗi
                string path = txtNhapPath.Text;
                if (Directory.Exists(path))
                {
                    //Duyệt for để tạo hàng loạt
                    for (int i = 1; i <= 10; i++)
                    {
                        //thêm file hàng loạt
                        string pathCreat = path + @"\File"+ i + ".txt";
                        FileInfo f = new FileInfo(pathCreat);
                        f.Create();
                    }
                    MessageBox.Show("Đã tạo xong !");
                }
                else
                {
                    MessageBox.Show("Đường dẫn không tồn tại, kiểm tra lại !");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn !");
            }    
        }

        private void btnTaoFolder_Click(object sender, EventArgs e)
        {
            if (txtNhapPath.Text != "")
            {
                //Check thư mục có tồn tại hay không? Nếu không thì báo lỗi
                string path = txtNhapPath.Text;
                if (Directory.Exists(path))
                {
                    //Duyệt for để tạo hàng loạt
                    for (int i = 1; i <= 10; i++)
                    {
                        //thêm file hàng loạt
                        string pathCreat = path + @"\Folder" + i;
                        DirectoryInfo directory = new DirectoryInfo(pathCreat);
                        directory.Create();
                    }
                    MessageBox.Show("Đã tạo xong !");
                }
                else
                {
                    MessageBox.Show("Đường dẫn không tồn tại, kiểm tra lại !");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn !");
            }
        }
    }
}
