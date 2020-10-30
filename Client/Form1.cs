using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPIP_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 10;
        }

        Socket _Sock;
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.Opacity = 0.1 * trackBar1.Value;
        }

        private void stripMenuStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            _Sock.Close();
            MessageBox.Show("STOP");
            
        }

        private void stripMenuStart_Click(object sender, EventArgs e)
        {
            _Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                pCount = 0;
                _Sock.Connect(tbServerIP.Text, int.Parse(tbPort.Text));

                timer1.Interval = int.Parse(tbInterval.Text);
                timer1.Enabled = true;
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        int pCount;
        private void timer1_Tick(object sender, EventArgs e)
        {
            // 프로토콜 정의 : [STX:02][s1:05][s2:05][s3:05][s4:05][ETX:03]
            String[] values = new string[]
            {

                tbFCode.Text,
                tbVStatus.Text,
                tbTStatus.Text,
                tbWStatus.Text,
                tbCStatus.Text
            };

            pCount++;
            String message = $"[{pCount}][STX]"+String.Join("", values)+"[ETX]";
            
            
            string cmd = string.Empty;
            byte[] buff = Encoding.UTF8.GetBytes(message);
            _Sock.Send(buff, SocketFlags.None);
            

        }
    }
}
