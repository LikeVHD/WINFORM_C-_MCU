using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Threading;

namespace slide13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Công việc chính mất thời gian cho nó làm trong đây
            int sum = 0;
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                sum += i;
                //gọi sự kiện progress changed
                backgroundWorker1.ReportProgress(i); //truyền i vì i đang chạy
                //Kiểm tra người dùng có bấm Cancel ko
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                }
            }
            e.Result = sum;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Tiến trình xử lý viết ở đây
            progressBar1.Value = e.ProgressPercentage;  //Update % lên progress bar
            label1.Text = "Hiện tại đã xử lý được: " +e.ProgressPercentage.ToString()+"%"; //update % lên label1
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                label2.Text = "Tiến trình bị huỷ rồi ông giáo ạ !";
            }
            else if (e.Error != null)
            {
                label2.Text = e.Error.Message;
            }
            else
            {
                label1.Text = "Đã tính xong rồi ông thím ạ :))";
                label2.Text = "Kết quả của tổng trên là: " + e.Result.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            //Ktra tiến trình có đang chạy hay ko
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                label2.Text = "Chờ tí đang xử lý chưa xong...";
            }    
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                //label2.Text = "Tiến trình bị huỷ rồi ông giáo ạ !";
                backgroundWorker1.CancelAsync();
            }
            else
                label2.Text = "Tiến trình chưa chạy, bạn không cần ấn Cancel !";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hiện tại chưa tính toán gì!";
            label2.Text = "Bấm Start để bắt đầu quá trình tính toán";
        }
    }
}
