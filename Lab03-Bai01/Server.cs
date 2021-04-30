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

namespace Lab03_Bai01
{
    public partial class Server : Form
    {
        bool KeepListening = true;
        UdpClient udpClient;

        public Server()
        {
            InitializeComponent();
        }

        private void bttn_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread ThdUDPServer = new Thread(new ThreadStart(ServerThread));
            ThdUDPServer.Start();    
        }
        public void ServerThread()
        {
            int Port;
            bool is_Int = Int32.TryParse(TextBox_Port.Text, out Port);
            if (!is_Int)
            {
                MessageBox.Show("Port không hợp lệ.", "Error");
                return;
            }

            try
            {
                udpClient = new UdpClient(Port);

                bttn_Listen.Enabled = false;

                ListView_Messages.Items.Add(new ListViewItem("Listening on port " + Port.ToString()));
                while (KeepListening)
                {
                    try
                    {
                        IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                        Byte[] ReceivedBytes = udpClient.Receive(ref RemoteIpEndPoint);
                        string ReturnData = Encoding.UTF8.GetString(ReceivedBytes);
                        string Mess = RemoteIpEndPoint.Address.ToString() + ": " + ReturnData;

                        ListView_Messages.Items.Add(new ListViewItem(Mess));
                    }
                    catch (Exception) { } // Thông báo việc nhận data bị gián đoạn
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể sử dụng port " + Port.ToString(), "Error");
                return;
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeepListening = false;
            if (udpClient != null)
            {
                udpClient.Close();
            }
        }
    }
}
