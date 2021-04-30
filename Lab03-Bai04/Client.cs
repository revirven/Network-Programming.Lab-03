using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Lab03_Bai04
{
    public partial class Client : Form
    {
        Message MessageMethod = new Message();
        TcpClient TCPClient = null;
        static IPAddress IpAddr = IPAddress.Parse("127.0.0.1");
        IPEndPoint IpEndPoint = new IPEndPoint(IpAddr, 8080);

        public Client()
        {
            InitializeComponent();

        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (TCPClient == null)
            {
                try
                {
                    TCPClient = new TcpClient();
                    TCPClient.Connect(IpEndPoint);
                    button_Connect.Enabled = false;

                    string addr = ((IPEndPoint)TCPClient.Client.RemoteEndPoint).Address.ToString();
                    string port = ((IPEndPoint)TCPClient.Client.RemoteEndPoint).Port.ToString();
                    RichTextBox_RecvMessages.Text += "Connected to " + addr + ':' + port + '\n';

                    string name = "";

                    if (TextBox_Name.Text == string.Empty) name = "Unknown\n";
                    else name = TextBox_Name.Text + '\n';

                    MessageMethod.Send(TCPClient, name);

                    Thread RecvThread = new Thread(StartReceiving);
                    RecvThread.IsBackground = true;
                    RecvThread.Start(TCPClient);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể connect, server không hoạt động.", "Error");
                    TCPClient = null;
                    return;
                }
            }
        }

        public void StartReceiving(object obj)
        {
            TcpClient RecvTarget = (TcpClient)obj;

            try
            {
                while (RecvTarget.Client.Poll(-1, SelectMode.SelectRead) && RecvTarget.Available != 0)
                {
                    string message = MessageMethod.Recv(RecvTarget);
                    RichTextBox_RecvMessages.Text += message;
                }
            }
            catch (Exception) { }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (TCPClient != null)
            {
                if (RichTextBox_Message.Text != string.Empty)
                {
                    MessageMethod.Send(TCPClient, RichTextBox_Message.Text);
                    RichTextBox_Message.Text = string.Empty;
                }
            }
        }

        // Nhấn Enter sẽ gửi message
        private void RichTextBox_Message_KeyPressed(object sender, KeyPressEventArgs e)
       {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (Control.ModifierKeys == Keys.Shift) {; }
                else
                {
                    button_Send.PerformClick();
                }
            }
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TCPClient != null)
            {
                TCPClient.Close();
            }
        }
    }
}
