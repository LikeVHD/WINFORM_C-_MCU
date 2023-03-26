using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Them 3 dong nay de su dung Serial Port
using System.IO;
using System.IO.Ports;
using System.Xml;
//
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Drawing2D;
using System.Xml.Linq;

namespace WindowsFormUART2_STM32F411
{
    public partial class Form1 : Form
    {
        string dataOut;
        string inData;
        public Form1()
        {
            InitializeComponent();
                // LAY CAC CONG COM CO TREN MAY TINH
                // 1.1. Lay tat ca cac cong COM co tren may tinh
                string[] ComList = SerialPort.GetPortNames();
                int[] ComNumberList = new int[ComList.Length];

                // 1.2. Sap xep cac cong COM theo thu tu tu thap den cao
                for (int i = 0; i < ComList.Length; i++)
                {
                    ComNumberList[i] = int.Parse(ComList[i].Substring(3));
                }
                Array.Sort(ComNumberList);
                foreach (int ComNumber in ComNumberList)
                {

                    cbCom.Items.Add("COM" + ComNumber.ToString());
                }

                // KHAI BAO TOC DO BAUD
                string[] baudList = { "9600", "14400", "19200", "38400", "57600", "115200" };   // Khai bao danh sach toc do Baud
                foreach (string baudName in baudList)
                {
                    cbBaudRate.Items.Add(baudName);
                }

                //  KHAI BAO DATA SIZE
                string[] dataSizeList = { "7", "8" };   // Khai bao danh sach kich co datasize
                foreach (string dataSize in dataSizeList)
                {
                    cbDatasize.Items.Add(dataSize);
                }

                //  KHAI BAO PARITY
                string[] parityList = { "none", "odd", "even", "mark", "space" };
                foreach (string str in parityList)
                {
                    cbParity.Items.Add(str);
                }

                // KHAI BAO STOP BIT
                string[] stopBit = { "0", "1", "2" };
                cbStopBit.Items.AddRange(stopBit);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //-----------------------------------------------------------------
            // 1. LOAD COM
            //-----------------------------------------------------------------
            // 1.1. Load cong com tu lan su dung truoc
            bool found = false;
            foreach (string str in cbCom.Items)
            {
                if (str == Properties.Settings.Default.PortName)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                cbCom.Text = Properties.Settings.Default.PortName;
            }

            //-----------------------------------------------------------------
            // 2. LOAD BAUDRATE
            //-----------------------------------------------------------------
            cbBaudRate.Text = Properties.Settings.Default.BaudRateNumber.ToString();

            //-----------------------------------------------------------------
            // 3. LOAD DATASIZE
            //-----------------------------------------------------------------
            cbDatasize.Text = Properties.Settings.Default.DataSizeNumber.ToString();

            //-----------------------------------------------------------------
            // 4. LOAD PARITY
            //-----------------------------------------------------------------
            cbParity.Text = Properties.Settings.Default.ParityList.ToString();
            
            //-----------------------------------------------------------------
            // 5. LOAD STOPBIT
            //-----------------------------------------------------------------
            cbStopBit.Text = Properties.Settings.Default.StopBitNumber.ToString();

            //-----------------------------------------------------------------
            // 6. LOAD TOA DO CUA SO
            //-----------------------------------------------------------------
            this.Location = new Point(Properties.Settings.Default.Left, Properties.Settings.Default.Top);

            //-----------------------------------------------------------------
            // 7. LOAD THONG TIN TU DONG KET NOI
            //-----------------------------------------------------------------
            chbAutoConnect.Checked = Properties.Settings.Default.AutoConnect;
            if (chbAutoConnect.Checked)
                btnConnect_Click(null, null);

        } // End Form1.Load

        private void SaveSetting()
        {
            //-----------------------------------------------------------------
            // 1. SAVE COM
            //-----------------------------------------------------------------
            Properties.Settings.Default.PortName = cbCom.Text;      // Gan ten cong COM hien tai vao PortName

            //-----------------------------------------------------------------
            // 2. SAVE LOCATION
            //-----------------------------------------------------------------
            // Lay vi tri hien tai cua cua so vao bien Top va Left
            Properties.Settings.Default.Top = this.Top;
            Properties.Settings.Default.Left = this.Left;

            //-----------------------------------------------------------------
            // 3. SAVE CONNECT INFO
            //-----------------------------------------------------------------
            // Luu thong tin tu dong ket noi
            Properties.Settings.Default.AutoConnect = chbAutoConnect.Checked;       // Luu thong tin tu dong ket noi

            //-----------------------------------------------------------------
            // 4. SAVE BAUDRATE
            //-----------------------------------------------------------------
            // Luu toc do Baud
            Properties.Settings.Default.BaudRateNumber = int.Parse(cbBaudRate.SelectedItem.ToString());
            
            //-----------------------------------------------------------------
            // 5. SAVE DATASIZE
            //-----------------------------------------------------------------
            // Luu kich thuoc data
            Properties.Settings.Default.DataSizeNumber = int.Parse(cbDatasize.SelectedItem.ToString());

            //-----------------------------------------------------------------
            // 6. SAVE PARITY
            //-----------------------------------------------------------------
            // Luu lua chon Parity
            Properties.Settings.Default.ParityList =(cbParity.SelectedItem.ToString());
            
            //-----------------------------------------------------------------
            // 7. SAVE STOPBIT
            //-----------------------------------------------------------------
            // Luu kich thuoc data
            Properties.Settings.Default.StopBitNumber = int.Parse(cbStopBit.SelectedItem.ToString());

            //-----------------------------------------------------------------
            // SAVE ALL
            //-----------------------------------------------------------------
            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng ứng dụng?", "Xác nhận?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (mySerialPort.IsOpen)
                {
                    // Luu
                    SaveSetting();
                    mySerialPort.Close();
                }
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if ((cbCom.Text != "") & (cbBaudRate.Text != ""))       // Kiem tra va dua ra thong bao neu chua chon cong COM
            {
                    if (mySerialPort.IsOpen)
                    {
                        SaveSetting();
                        mySerialPort.Close();
                        // Thay doi mau nut bam
                        btnConnect.BackColor = System.Drawing.Color.DarkGray;
                        btnConnect.ForeColor = System.Drawing.Color.Black;
                        // Thay doi chu nut bam
                        btnConnect.Text = "KẾT NỐI";
                        // Mo cau hinh
                        cbCom.Enabled = true;
                        cbBaudRate.Enabled = true;
                        cbDatasize.Enabled = true;
                        cbParity.Enabled = true;
                        cbStopBit.Enabled = true;
                    //
                        btnGreenLED.BackColor = System.Drawing.Color.Snow;
                        btnOrangeLED.BackColor = System.Drawing.Color.Snow;
                        btnRedLED.BackColor = System.Drawing.Color.Snow;
                        btnBlueLED.BackColor = System.Drawing.Color.Snow;

                        btnGreenLED.Text = "Green LED";
                        btnOrangeLED.Text = "Orange LED";
                        btnRedLED.Text = "Red LED";
                        btnBlueLED.Text = "Blue LED";

                        //tbSend.Text = "";
                        tbSend.Clear();
                        txtFeedBack.Clear();
                    grbDieuKhienLed.Enabled = false;
                }   // end if (mySerialPort.IsOpen)
                else
                    {
                        try
                        {
                            mySerialPort.Open();                                           // Mo cong COM
                            // Doi mau va chu nut bam
                            btnConnect.BackColor = System.Drawing.Color.LimeGreen;
                            btnConnect.ForeColor = System.Drawing.Color.White;
                            btnConnect.Text = "NGẮT KẾT NỐI";

                            // Khoa bang cau hinh cong COM, Baurate, DataSize, Parity, StopBit
                            cbCom.Enabled = false;
                            cbBaudRate.Enabled = false;
                            cbDatasize.Enabled = false;
                            cbParity.Enabled = false;
                            cbStopBit.Enabled = false;

                            // Mo bang dieu khien Led va truyen nhan du lieu
                            grbDieuKhienLed.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Không thể mở cổng " + cbCom.Text, "Lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }   // end  if ((cbCom.Text != "") & (cbBaudRate.Text != ""))
            else
            {
                MessageBox.Show("Vui lòng chọn cổng COM và BAUDRARE trước khi kết nối", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (mySerialPort.IsOpen)
            {
                dataOut = tbSend.Text;
                mySerialPort.WriteLine(dataOut);
            }
            tbSend.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFeedBack.Clear();
        }
        //-------------------------------------------------------
        // Green LED
        //-------------------------------------------------------
        private void btnGreenLED_Click(object sender, EventArgs e)
        {
            // Neu Led dang tat
            if (btnGreenLED.BackColor == System.Drawing.Color.Snow)
            {
                // Xu ly mau nut bam
                btnGreenLED.BackColor = System.Drawing.Color.GreenYellow;
                btnGreenLED.ForeColor = System.Drawing.Color.White;
                btnGreenLED.Text = "ON";
            }
            // Neu Led dang bat
            else
            {
                // Xu ly mau nut bam
                btnGreenLED.BackColor = System.Drawing.Color.Snow;
                btnGreenLED.ForeColor = System.Drawing.Color.Black;
                btnGreenLED.Text = "Green LED";
            }
        }
        private void btnGreenLED_MouseEnter(object sender, EventArgs e)
        {
            if (btnGreenLED.BackColor == System.Drawing.Color.Snow)
            {
                btnGreenLED.Text = "Turn On";
            }
            else
            {
                btnGreenLED.Text = "Turn Off";
            }    
        }
        private void btnGreenLED_MouseLeave(object sender, EventArgs e)
        {
            if (btnGreenLED.BackColor == System.Drawing.Color.GreenYellow)
            {
                btnGreenLED.Text = "ON";
            }
            else
            {
                btnGreenLED.Text = "Green LED";
            }
        }
        //-------------------------------------------------------
        // Orange LED
        //-------------------------------------------------------
        private void btnOrangeLED_Click(object sender, EventArgs e)
        {
            // Neu Led dang tat
            if (btnOrangeLED.BackColor == System.Drawing.Color.Snow)
            {
                // Xu ly mau nut bam
                btnOrangeLED.BackColor = System.Drawing.Color.Orange;
                btnOrangeLED.ForeColor = System.Drawing.Color.White;
                btnOrangeLED.Text = "ON";
            }
            // Neu Led dang bat
            else
            {
                // Xu ly mau nut bam
                btnOrangeLED.BackColor = System.Drawing.Color.Snow;
                btnOrangeLED.ForeColor = System.Drawing.Color.Black;
                btnOrangeLED.Text = "Orange LED";
            }
        }
        private void btnOrangeLED_MouseEnter(object sender, EventArgs e)
        {
            if (btnOrangeLED.BackColor == System.Drawing.Color.Snow)
            {
                btnOrangeLED.Text = "Turn On";
                // Xu ly mau nut bam
                //btnYellowLED.BackColor = System.Drawing.Color.Orange;
                //btnYellowLED.ForeColor = System.Drawing.Color.White;
                //btnYellowLED.Text = "ON";
            }
            else
            {
                btnOrangeLED.Text = "Turn Off";
            }    
        }
        private void btnOrangeLED_MouseLeave(object sender, EventArgs e)
        {
            if (btnOrangeLED.BackColor == System.Drawing.Color.Orange)
            {
                btnOrangeLED.Text = "ON";
            }
            else
            {
                btnOrangeLED.Text = "Orange LED";
            }
        }

        //-------------------------------------------------------
        // Red LED
        //-------------------------------------------------------
        private void btnRedLED_Click(object sender, EventArgs e)
        {
            // Neu Led dang tat
            if (btnRedLED.BackColor == System.Drawing.Color.Snow)
            {
                // Xu ly mau nut bam
                btnRedLED.BackColor = System.Drawing.Color.Red;
                btnRedLED.ForeColor = System.Drawing.Color.White;
                btnRedLED.Text = "ON";
            }
            // Neu Led dang bat
            else
            {
                // Xu ly mau nut bam
                btnRedLED.BackColor = System.Drawing.Color.Snow;
                btnRedLED.ForeColor = System.Drawing.Color.Black;
                btnRedLED.Text = "Red LED";
            }
        }
        private void btnRedLED_MouseEnter(object sender, EventArgs e)
        {
            if (btnRedLED.BackColor == System.Drawing.Color.Snow)
            {
                btnRedLED.Text = "Turn On";
            }
            else
            {
                btnRedLED.Text = "Turn Off";
            }
        }
        private void btnRedLED_MouseLeave(object sender, EventArgs e)
        {
            if (btnRedLED.BackColor == System.Drawing.Color.Red)
            {
                btnRedLED.Text = "ON";
            }
            else
            {
                btnRedLED.Text = "Red LED";
            }
        }

        //-------------------------------------------------------
        // Blue LED
        //-------------------------------------------------------
        private void btnBlueLED_Click(object sender, EventArgs e)
        {
            // Neu Led dang tat
            if (btnBlueLED.BackColor == System.Drawing.Color.Snow)
            {
                // Xu ly mau nut bam
                btnBlueLED.BackColor = System.Drawing.Color.DeepSkyBlue;
                btnBlueLED.ForeColor = System.Drawing.Color.White;
                btnBlueLED.Text = "ON";
            }
            // Neu Led dang bat
            else
            {
                // Xu ly mau nut bam
                btnBlueLED.BackColor = System.Drawing.Color.Snow;
                btnBlueLED.ForeColor = System.Drawing.Color.Black;
                btnBlueLED.Text = "Blue LED";
            }
        }
        private void btnBlueLED_MouseEnter(object sender, EventArgs e)
        {
            if (btnBlueLED.BackColor == System.Drawing.Color.Snow)
            {
                btnBlueLED.Text = "Turn On";
            }
            else
            {
                btnBlueLED.Text = "Turn Off";
            }
        }
        private void btnBlueLED_MouseLeave(object sender, EventArgs e)
        {
            if (btnBlueLED.BackColor == System.Drawing.Color.DeepSkyBlue)
            {
                btnBlueLED.Text = "ON";
            }
            else
            {
                btnBlueLED.Text = "Blue LED";
            }
        }

        //-------------------------------------------------------
        // COMBOBOX
        //-------------------------------------------------------
        private void cbCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Gan lai ten COM cho portname
            mySerialPort.PortName = cbCom.Text;
        }
        private void cbBaudrate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Lay toc do Baud moi tu gia tri da chon cua ComboBox
            //mySerialPort.BaudRate = Convert.ToInt32(cbBaudRate.Text);   // Chuyen kieu String sang kieu Int
            mySerialPort.BaudRate = int.Parse(cbBaudRate.SelectedItem.ToString());
        }
        private void cbDatasize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Lay gia tri Datasize moi tu gia tri da chon cua ComboBox gan vao DataBits
            mySerialPort.DataBits = int.Parse(cbDatasize.SelectedItem.ToString());
         }
        private void cbParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbParity.Text)   // "none", "odd", "even", "mark", "space"
            {
                case "none":
                    mySerialPort.Parity = Parity.None;
                    break;
                case "odd":
                    mySerialPort.Parity = Parity.Odd;
                    break;
                case "even":
                    mySerialPort.Parity = Parity.Even;
                    break;
                case "mark":
                    mySerialPort.Parity = Parity.Mark;
                    break;
                case "space":
                    mySerialPort.Parity = Parity.Space;
                    break;
            }
        }
        private void cbStopBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbStopBit.Text)   // "0", "1", "2"
            {
                case "0":
                    mySerialPort.StopBits = StopBits.None;
                    break;
                case "1":
                    mySerialPort.StopBits = StopBits.One;
                    break;
                case "2":
                    mySerialPort.StopBits = StopBits.Two;
                    break;
            }
        }


        //-------------------------------------------------------
        // GROUPBOX
        //-------------------------------------------------------
        private void grbDieuKhienLed_Enter(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------
        // CHECKBOX
        //-------------------------------------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------
        //TEXTBOX
        //-------------------------------------------------------
        private void tbSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataOut = tbSend.Text;
                mySerialPort.WriteLine(dataOut);
                tbSend.Clear();
            }
        }

        private void mySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //  Sử dụng phương thức ReadExisting() để đọc dữ liệu
            inData = mySerialPort.ReadExisting();
            //txtFeedBack.AppendText (inData);
            // Thêm dữ liệu vào textbox bằng phương thức AppendText()
            // Sử dụng BeginInvoke để đảm bảo rằng việc thêm dữ liệu vào textbox được thực hiện trên thread chính của form.
            BeginInvoke(new Action(() =>
            {
                txtFeedBack.AppendText(inData);
            }));
        }


    }   // End "public partial class Form1 : Form"
}   // End "namespace WindowsFormUART2_STM32F411"
