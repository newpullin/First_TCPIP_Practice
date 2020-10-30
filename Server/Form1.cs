using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp4
{

    public partial class Form1 : Form
    {
        private delegate void SafeCallDelegate(string text);
        private void WriteTextSafe(string text)
        {
            if (tbOutput.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteTextSafe);
                tbOutput.Invoke(d, new object[] { text });
            }
            else
            {
                //Output.Text += text;
                tbOutput.AppendText(text);
            }
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        TcpListener tcpListener;
        TcpClient sock;
        const int buf_size = 20000;
        byte[] buf = new byte[buf_size];
        Thread ServerThread;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(tcpListener == null)
            {
                int port_number = int.Parse(tbPort.Text);
                tcpListener = new TcpListener(port_number);
                tcpListener.Start();
                ServerThread = new Thread(ServerProcess);
                ServerThread.Start();

                
                
                //tcpListener.Stop();
                //tcpListener = null;
            }
            else
            {
                ServerThread = new Thread(ServerProcess);
                ServerThread.Start();
            }
            
        }

        private void ServerProcess()
        {
            sock = tcpListener.AcceptTcpClient();
            WriteTextSafe(sock.Client.RemoteEndPoint.ToString() + "\r\n");
            while (true)
            {
                 // Session
                
                NetworkStream ns = sock.GetStream();

                if (ns.DataAvailable)
                {
                    int read_length = ns.Read(buf, 0, buf_size);
                    string str = Encoding.Default.GetString(buf);
                    if(str == "exit")
                    {

                    }
                    WriteTextSafe("\r\n>>>" + str.ToString() + "\r\n");
                    //tbOutput.Text = ">>>" + str.ToString() + "\r\n";
                }

                Thread.Sleep(0);
                
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ServerThread != null)
            {
                ServerThread.Abort();
                tcpListener.Stop();
            }
            
        }
    }
}
