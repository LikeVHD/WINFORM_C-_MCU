namespace WindowsFormUART2_STM32F411
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOrangeLED = new System.Windows.Forms.Button();
            this.lb1DieuKhienLED = new System.Windows.Forms.Label();
            this.btnBlueLED = new System.Windows.Forms.Button();
            this.btnGreenLED = new System.Windows.Forms.Button();
            this.btnRedLED = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grbUart2 = new System.Windows.Forms.GroupBox();
            this.chbAutoConnect = new System.Windows.Forms.CheckBox();
            this.cbStopBit = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDatasize = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.lbStopBit = new System.Windows.Forms.Label();
            this.cbCom = new System.Windows.Forms.ComboBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.lbDatasize = new System.Windows.Forms.Label();
            this.lbBaudrate = new System.Windows.Forms.Label();
            this.lbCOM = new System.Windows.Forms.Label();
            this.lbReceived = new System.Windows.Forms.Label();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.mySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.grbDieuKhienLed = new System.Windows.Forms.GroupBox();
            this.txtFeedBack = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.grbUart2.SuspendLayout();
            this.grbDieuKhienLed.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrangeLED
            // 
            this.btnOrangeLED.BackColor = System.Drawing.Color.Snow;
            this.btnOrangeLED.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrangeLED.ForeColor = System.Drawing.Color.Black;
            this.btnOrangeLED.Location = new System.Drawing.Point(174, 48);
            this.btnOrangeLED.Name = "btnOrangeLED";
            this.btnOrangeLED.Size = new System.Drawing.Size(78, 43);
            this.btnOrangeLED.TabIndex = 0;
            this.btnOrangeLED.Text = "Orange\r\nLED\r\n";
            this.btnOrangeLED.UseVisualStyleBackColor = false;
            this.btnOrangeLED.Click += new System.EventHandler(this.btnOrangeLED_Click);
            this.btnOrangeLED.MouseEnter += new System.EventHandler(this.btnOrangeLED_MouseEnter);
            this.btnOrangeLED.MouseLeave += new System.EventHandler(this.btnOrangeLED_MouseLeave);
            // 
            // lb1DieuKhienLED
            // 
            this.lb1DieuKhienLED.AutoSize = true;
            this.lb1DieuKhienLED.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1DieuKhienLED.Location = new System.Drawing.Point(140, 0);
            this.lb1DieuKhienLED.Name = "lb1DieuKhienLED";
            this.lb1DieuKhienLED.Size = new System.Drawing.Size(145, 21);
            this.lb1DieuKhienLED.TabIndex = 1;
            this.lb1DieuKhienLED.Text = "ĐIỀU KHIỂN LED";
            // 
            // btnBlueLED
            // 
            this.btnBlueLED.BackColor = System.Drawing.Color.Snow;
            this.btnBlueLED.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlueLED.ForeColor = System.Drawing.Color.Black;
            this.btnBlueLED.Location = new System.Drawing.Point(174, 128);
            this.btnBlueLED.Name = "btnBlueLED";
            this.btnBlueLED.Size = new System.Drawing.Size(78, 43);
            this.btnBlueLED.TabIndex = 0;
            this.btnBlueLED.Text = "Blue\r\nLED";
            this.btnBlueLED.UseVisualStyleBackColor = false;
            this.btnBlueLED.Click += new System.EventHandler(this.btnBlueLED_Click);
            this.btnBlueLED.MouseEnter += new System.EventHandler(this.btnBlueLED_MouseEnter);
            this.btnBlueLED.MouseLeave += new System.EventHandler(this.btnBlueLED_MouseLeave);
            // 
            // btnGreenLED
            // 
            this.btnGreenLED.BackColor = System.Drawing.Color.Snow;
            this.btnGreenLED.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenLED.ForeColor = System.Drawing.Color.Black;
            this.btnGreenLED.Location = new System.Drawing.Point(95, 89);
            this.btnGreenLED.Name = "btnGreenLED";
            this.btnGreenLED.Size = new System.Drawing.Size(78, 43);
            this.btnGreenLED.TabIndex = 0;
            this.btnGreenLED.Text = "Green\r\nLED";
            this.btnGreenLED.UseVisualStyleBackColor = false;
            this.btnGreenLED.Click += new System.EventHandler(this.btnGreenLED_Click);
            this.btnGreenLED.MouseEnter += new System.EventHandler(this.btnGreenLED_MouseEnter);
            this.btnGreenLED.MouseLeave += new System.EventHandler(this.btnGreenLED_MouseLeave);
            // 
            // btnRedLED
            // 
            this.btnRedLED.BackColor = System.Drawing.Color.Snow;
            this.btnRedLED.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedLED.ForeColor = System.Drawing.Color.Black;
            this.btnRedLED.Location = new System.Drawing.Point(253, 89);
            this.btnRedLED.Name = "btnRedLED";
            this.btnRedLED.Size = new System.Drawing.Size(78, 43);
            this.btnRedLED.TabIndex = 0;
            this.btnRedLED.Text = "Red\r\nLED";
            this.btnRedLED.UseVisualStyleBackColor = false;
            this.btnRedLED.Click += new System.EventHandler(this.btnRedLED_Click);
            this.btnRedLED.MouseEnter += new System.EventHandler(this.btnRedLED_MouseEnter);
            this.btnRedLED.MouseLeave += new System.EventHandler(this.btnRedLED_MouseLeave);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Snow;
            this.btnConnect.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Black;
            this.btnConnect.Location = new System.Drawing.Point(46, 251);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(110, 43);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "KẾT NỐI";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grbUart2
            // 
            this.grbUart2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbUart2.Controls.Add(this.chbAutoConnect);
            this.grbUart2.Controls.Add(this.cbStopBit);
            this.grbUart2.Controls.Add(this.btnConnect);
            this.grbUart2.Controls.Add(this.cbParity);
            this.grbUart2.Controls.Add(this.cbDatasize);
            this.grbUart2.Controls.Add(this.cbBaudRate);
            this.grbUart2.Controls.Add(this.lbStopBit);
            this.grbUart2.Controls.Add(this.cbCom);
            this.grbUart2.Controls.Add(this.lbParity);
            this.grbUart2.Controls.Add(this.lbDatasize);
            this.grbUart2.Controls.Add(this.lbBaudrate);
            this.grbUart2.Controls.Add(this.lbCOM);
            this.grbUart2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUart2.ForeColor = System.Drawing.Color.Black;
            this.grbUart2.Location = new System.Drawing.Point(12, 12);
            this.grbUart2.Name = "grbUart2";
            this.grbUart2.Size = new System.Drawing.Size(226, 306);
            this.grbUart2.TabIndex = 2;
            this.grbUart2.TabStop = false;
            this.grbUart2.Text = "Cấu hình truyền thông";
            // 
            // chbAutoConnect
            // 
            this.chbAutoConnect.AutoSize = true;
            this.chbAutoConnect.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAutoConnect.Location = new System.Drawing.Point(99, 206);
            this.chbAutoConnect.Name = "chbAutoConnect";
            this.chbAutoConnect.Size = new System.Drawing.Size(120, 20);
            this.chbAutoConnect.TabIndex = 2;
            this.chbAutoConnect.Text = "Tự động kết nối";
            this.chbAutoConnect.UseVisualStyleBackColor = true;
            this.chbAutoConnect.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbStopBit
            // 
            this.cbStopBit.FormattingEnabled = true;
            this.cbStopBit.Location = new System.Drawing.Point(99, 169);
            this.cbStopBit.Name = "cbStopBit";
            this.cbStopBit.Size = new System.Drawing.Size(121, 22);
            this.cbStopBit.TabIndex = 1;
            this.cbStopBit.SelectedIndexChanged += new System.EventHandler(this.cbStopBit_SelectedIndexChanged);
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(99, 131);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 22);
            this.cbParity.TabIndex = 1;
            this.cbParity.SelectedIndexChanged += new System.EventHandler(this.cbParity_SelectedIndexChanged);
            // 
            // cbDatasize
            // 
            this.cbDatasize.FormattingEnabled = true;
            this.cbDatasize.Location = new System.Drawing.Point(99, 97);
            this.cbDatasize.Name = "cbDatasize";
            this.cbDatasize.Size = new System.Drawing.Size(121, 22);
            this.cbDatasize.TabIndex = 1;
            this.cbDatasize.SelectedIndexChanged += new System.EventHandler(this.cbDatasize_SelectedIndexChanged);
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(99, 63);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 22);
            this.cbBaudRate.TabIndex = 1;
            this.cbBaudRate.SelectedIndexChanged += new System.EventHandler(this.cbBaudrate_SelectedIndexChanged);
            // 
            // lbStopBit
            // 
            this.lbStopBit.AutoSize = true;
            this.lbStopBit.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStopBit.Location = new System.Drawing.Point(19, 166);
            this.lbStopBit.Name = "lbStopBit";
            this.lbStopBit.Size = new System.Drawing.Size(72, 16);
            this.lbStopBit.TabIndex = 0;
            this.lbStopBit.Text = "STOP BIT:";
            // 
            // cbCom
            // 
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Location = new System.Drawing.Point(99, 26);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(121, 22);
            this.cbCom.TabIndex = 1;
            this.cbCom.SelectedIndexChanged += new System.EventHandler(this.cbCom_SelectedIndexChanged);
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParity.Location = new System.Drawing.Point(33, 128);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(58, 16);
            this.lbParity.TabIndex = 0;
            this.lbParity.Text = "PARITY:";
            // 
            // lbDatasize
            // 
            this.lbDatasize.AutoSize = true;
            this.lbDatasize.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatasize.Location = new System.Drawing.Point(14, 94);
            this.lbDatasize.Name = "lbDatasize";
            this.lbDatasize.Size = new System.Drawing.Size(75, 16);
            this.lbDatasize.TabIndex = 0;
            this.lbDatasize.Text = "DATA SIZE:";
            // 
            // lbBaudrate
            // 
            this.lbBaudrate.AutoSize = true;
            this.lbBaudrate.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaudrate.Location = new System.Drawing.Point(6, 60);
            this.lbBaudrate.Name = "lbBaudrate";
            this.lbBaudrate.Size = new System.Drawing.Size(81, 16);
            this.lbBaudrate.TabIndex = 0;
            this.lbBaudrate.Text = "BAUDRATE:";
            // 
            // lbCOM
            // 
            this.lbCOM.AutoSize = true;
            this.lbCOM.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCOM.Location = new System.Drawing.Point(52, 26);
            this.lbCOM.Name = "lbCOM";
            this.lbCOM.Size = new System.Drawing.Size(41, 16);
            this.lbCOM.TabIndex = 0;
            this.lbCOM.Text = "COM:";
            // 
            // lbReceived
            // 
            this.lbReceived.AutoSize = true;
            this.lbReceived.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceived.Location = new System.Drawing.Point(6, 229);
            this.lbReceived.Name = "lbReceived";
            this.lbReceived.Size = new System.Drawing.Size(70, 16);
            this.lbReceived.TabIndex = 1;
            this.lbReceived.Text = "Feedback:";
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(82, 192);
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(300, 25);
            this.tbSend.TabIndex = 3;
            this.tbSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSend_KeyDown);
            // 
            // mySerialPort
            // 
            this.mySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.mySerialPort_DataReceived);
            // 
            // grbDieuKhienLed
            // 
            this.grbDieuKhienLed.Controls.Add(this.txtFeedBack);
            this.grbDieuKhienLed.Controls.Add(this.btnClear);
            this.grbDieuKhienLed.Controls.Add(this.btnSend);
            this.grbDieuKhienLed.Controls.Add(this.btnBlueLED);
            this.grbDieuKhienLed.Controls.Add(this.btnRedLED);
            this.grbDieuKhienLed.Controls.Add(this.btnGreenLED);
            this.grbDieuKhienLed.Controls.Add(this.lb1DieuKhienLED);
            this.grbDieuKhienLed.Controls.Add(this.tbSend);
            this.grbDieuKhienLed.Controls.Add(this.lbReceived);
            this.grbDieuKhienLed.Controls.Add(this.btnOrangeLED);
            this.grbDieuKhienLed.Enabled = false;
            this.grbDieuKhienLed.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDieuKhienLed.Location = new System.Drawing.Point(244, 12);
            this.grbDieuKhienLed.Name = "grbDieuKhienLed";
            this.grbDieuKhienLed.Size = new System.Drawing.Size(388, 306);
            this.grbDieuKhienLed.TabIndex = 5;
            this.grbDieuKhienLed.TabStop = false;
            this.grbDieuKhienLed.Enter += new System.EventHandler(this.grbDieuKhienLed_Enter);
            // 
            // txtFeedBack
            // 
            this.txtFeedBack.Location = new System.Drawing.Point(82, 229);
            this.txtFeedBack.Multiline = true;
            this.txtFeedBack.Name = "txtFeedBack";
            this.txtFeedBack.ReadOnly = true;
            this.txtFeedBack.Size = new System.Drawing.Size(295, 71);
            this.txtFeedBack.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(0, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(1, 192);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 25);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 327);
            this.Controls.Add(this.grbUart2);
            this.Controls.Add(this.grbDieuKhienLed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UART STM32F411 Discovery board (by Like VHD)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbUart2.ResumeLayout(false);
            this.grbUart2.PerformLayout();
            this.grbDieuKhienLed.ResumeLayout(false);
            this.grbDieuKhienLed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb1DieuKhienLED;
        private System.Windows.Forms.Button btnOrangeLED;
        private System.Windows.Forms.Button btnBlueLED;
        private System.Windows.Forms.Button btnGreenLED;
        private System.Windows.Forms.Button btnRedLED;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grbUart2;
        private System.Windows.Forms.Label lbCOM;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.Label lbDatasize;
        private System.Windows.Forms.Label lbBaudrate;
        private System.Windows.Forms.Label lbReceived;
        private System.Windows.Forms.Label lbStopBit;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDatasize;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbCom;
        private System.Windows.Forms.ComboBox cbStopBit;
        private System.Windows.Forms.TextBox tbSend;
        private System.IO.Ports.SerialPort mySerialPort;
        private System.Windows.Forms.GroupBox grbDieuKhienLed;
        private System.Windows.Forms.CheckBox chbAutoConnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtFeedBack;
        private System.Windows.Forms.Button btnClear;
    }
}

