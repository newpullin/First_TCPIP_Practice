namespace TCPIP_Client
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLastCode = new System.Windows.Forms.TextBox();
            this.tbTStatus = new System.Windows.Forms.TextBox();
            this.tbVStatus = new System.Windows.Forms.TextBox();
            this.tbFCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.tbKeyCode = new System.Windows.Forms.TextBox();
            this.tbWStatus = new System.Windows.Forms.TextBox();
            this.tbCStatus = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chInterval = new System.Windows.Forms.CheckBox();
            this.chSeperator = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.chDissconnect = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chMSG = new System.Windows.Forms.CheckBox();
            this.chTimeStamp = new System.Windows.Forms.CheckBox();
            this.chIPStamp = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stripMenuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 79);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(514, 290);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(506, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "수직시차제어";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtStartTime);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.chSeperator);
            this.groupBox1.Controls.Add(this.chInterval);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbCStatus);
            this.groupBox1.Controls.Add(this.tbWStatus);
            this.groupBox1.Controls.Add(this.tbKeyCode);
            this.groupBox1.Controls.Add(this.tbInterval);
            this.groupBox1.Controls.Add(this.tbLastCode);
            this.groupBox1.Controls.Add(this.tbTStatus);
            this.groupBox1.Controls.Add(this.tbVStatus);
            this.groupBox1.Controls.Add(this.tbFCode);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("궁서", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VirtualEquip Signal";
            // 
            // tbLastCode
            // 
            this.tbLastCode.Location = new System.Drawing.Point(80, 174);
            this.tbLastCode.Name = "tbLastCode";
            this.tbLastCode.Size = new System.Drawing.Size(271, 25);
            this.tbLastCode.TabIndex = 12;
            // 
            // tbTStatus
            // 
            this.tbTStatus.Location = new System.Drawing.Point(80, 137);
            this.tbTStatus.Name = "tbTStatus";
            this.tbTStatus.Size = new System.Drawing.Size(142, 25);
            this.tbTStatus.TabIndex = 11;
            // 
            // tbVStatus
            // 
            this.tbVStatus.Location = new System.Drawing.Point(80, 106);
            this.tbVStatus.Name = "tbVStatus";
            this.tbVStatus.Size = new System.Drawing.Size(142, 25);
            this.tbVStatus.TabIndex = 10;
            // 
            // tbFCode
            // 
            this.tbFCode.Location = new System.Drawing.Point(80, 74);
            this.tbFCode.Name = "tbFCode";
            this.tbFCode.Size = new System.Drawing.Size(142, 25);
            this.tbFCode.TabIndex = 9;
            this.tbFCode.Text = "10001";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "상태V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "상태T";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interval(ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Key Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "설비코드";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "시작시간";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(506, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Interaction제어";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(506, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "통합제어기";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(506, 264);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Virtual Equip";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(3, 12);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(514, 61);
            this.tbOutput.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.chIPStamp);
            this.groupBox2.Controls.Add(this.chTimeStamp);
            this.groupBox2.Controls.Add(this.chMSG);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.chDissconnect);
            this.groupBox2.Controls.Add(this.tbPort);
            this.groupBox2.Controls.Add(this.tbServerIP);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("궁서", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(7, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 186);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication Control";
            // 
            // tbInterval
            // 
            this.tbInterval.Location = new System.Drawing.Point(337, 41);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(61, 25);
            this.tbInterval.TabIndex = 13;
            this.tbInterval.Text = "100";
            // 
            // tbKeyCode
            // 
            this.tbKeyCode.Location = new System.Drawing.Point(263, 75);
            this.tbKeyCode.Name = "tbKeyCode";
            this.tbKeyCode.Size = new System.Drawing.Size(135, 25);
            this.tbKeyCode.TabIndex = 14;
            this.tbKeyCode.Text = "00001";
            // 
            // tbWStatus
            // 
            this.tbWStatus.Location = new System.Drawing.Point(263, 106);
            this.tbWStatus.Name = "tbWStatus";
            this.tbWStatus.Size = new System.Drawing.Size(135, 25);
            this.tbWStatus.TabIndex = 15;
            // 
            // tbCStatus
            // 
            this.tbCStatus.Location = new System.Drawing.Point(263, 137);
            this.tbCStatus.Name = "tbCStatus";
            this.tbCStatus.Size = new System.Drawing.Size(135, 25);
            this.tbCStatus.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "상태 W";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "상태C";
            // 
            // chInterval
            // 
            this.chInterval.AutoSize = true;
            this.chInterval.Location = new System.Drawing.Point(316, 45);
            this.chInterval.Name = "chInterval";
            this.chInterval.Size = new System.Drawing.Size(15, 14);
            this.chInterval.TabIndex = 19;
            this.chInterval.UseVisualStyleBackColor = true;
            // 
            // chSeperator
            // 
            this.chSeperator.AutoSize = true;
            this.chSeperator.Location = new System.Drawing.Point(373, 179);
            this.chSeperator.Name = "chSeperator";
            this.chSeperator.Size = new System.Drawing.Size(15, 14);
            this.chSeperator.TabIndex = 20;
            this.chSeperator.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 178);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "구분기호";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 15);
            this.label11.TabIndex = 6;
            this.label11.Text = "Server IP";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tbServerIP
            // 
            this.tbServerIP.Location = new System.Drawing.Point(87, 40);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(178, 25);
            this.tbServerIP.TabIndex = 7;
            this.tbServerIP.Text = "192.168.0.165";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(265, 40);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(68, 25);
            this.tbPort.TabIndex = 8;
            this.tbPort.Text = "9000";
            // 
            // chDissconnect
            // 
            this.chDissconnect.AutoSize = true;
            this.chDissconnect.Location = new System.Drawing.Point(339, 44);
            this.chDissconnect.Name = "chDissconnect";
            this.chDissconnect.Size = new System.Drawing.Size(15, 14);
            this.chDissconnect.TabIndex = 23;
            this.chDissconnect.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("궁서", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(360, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 12);
            this.label12.TabIndex = 24;
            this.label12.Text = "Dissconnect after Send";
            // 
            // chMSG
            // 
            this.chMSG.AutoSize = true;
            this.chMSG.Location = new System.Drawing.Point(25, 113);
            this.chMSG.Name = "chMSG";
            this.chMSG.Size = new System.Drawing.Size(80, 19);
            this.chMSG.TabIndex = 25;
            this.chMSG.Text = "DispMSG";
            this.chMSG.UseVisualStyleBackColor = true;
            // 
            // chTimeStamp
            // 
            this.chTimeStamp.AutoSize = true;
            this.chTimeStamp.Location = new System.Drawing.Point(149, 113);
            this.chTimeStamp.Name = "chTimeStamp";
            this.chTimeStamp.Size = new System.Drawing.Size(93, 19);
            this.chTimeStamp.TabIndex = 26;
            this.chTimeStamp.Text = "TimeStamp";
            this.chTimeStamp.UseVisualStyleBackColor = true;
            // 
            // chIPStamp
            // 
            this.chIPStamp.AutoSize = true;
            this.chIPStamp.Location = new System.Drawing.Point(270, 113);
            this.chIPStamp.Name = "chIPStamp";
            this.chIPStamp.Size = new System.Drawing.Size(82, 19);
            this.chIPStamp.TabIndex = 27;
            this.chIPStamp.Text = "IP Stamp";
            this.chIPStamp.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(376, 104);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 28;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuStart,
            this.stripMenuStop});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 48);
            // 
            // stripMenuStart
            // 
            this.stripMenuStart.Name = "stripMenuStart";
            this.stripMenuStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.stripMenuStart.Size = new System.Drawing.Size(187, 22);
            this.stripMenuStart.Text = "시작(START)";
            this.stripMenuStart.Click += new System.EventHandler(this.stripMenuStart_Click);
            // 
            // stripMenuStop
            // 
            this.stripMenuStop.Name = "stripMenuStop";
            this.stripMenuStop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.stripMenuStop.Size = new System.Drawing.Size(187, 22);
            this.stripMenuStop.Text = "정지(STOP)";
            this.stripMenuStop.Click += new System.EventHandler(this.stripMenuStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtStartTime
            // 
            this.dtStartTime.Location = new System.Drawing.Point(80, 40);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.Size = new System.Drawing.Size(200, 25);
            this.dtStartTime.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 576);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Virtual Equipment";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLastCode;
        private System.Windows.Forms.TextBox tbTStatus;
        private System.Windows.Forms.TextBox tbVStatus;
        private System.Windows.Forms.TextBox tbFCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chSeperator;
        private System.Windows.Forms.CheckBox chInterval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCStatus;
        private System.Windows.Forms.TextBox tbWStatus;
        private System.Windows.Forms.TextBox tbKeyCode;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chIPStamp;
        private System.Windows.Forms.CheckBox chTimeStamp;
        private System.Windows.Forms.CheckBox chMSG;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chDissconnect;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripMenuStart;
        private System.Windows.Forms.ToolStripMenuItem stripMenuStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtStartTime;
    }
}

