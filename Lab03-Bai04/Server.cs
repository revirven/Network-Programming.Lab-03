using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Lab03_Bai04
{
    public partial class Server : Form
    {
        TcpListener TCPListener = null;
        bool KeepListening = true;

        static IPAddress IpAddr = IPAddress.Parse("127.0.0.1");
        IPEndPoint IpEndPoint = new IPEndPoint(IpAddr, 8080);

        List<ClientConnection> ClientList = new List<ClientConnection>();

        Message MessageMethod = new Message();

        public Server()
        {
            InitializeComponent();
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread Listen = new Thread(new ThreadStart(StartListen));
            Listen.Start();
        }

        // Listen trong 1 thread khác để không gián đoạn chương trình
        void StartListen()
        {
            try
            {
                TCPListener = new TcpListener(IpEndPoint);
                button_Listen.Enabled = false;

                TCPListener.Start();
                RichTextBox_Messages.Text += "Server running on 127.0.0.1:8080\n";

                while (KeepListening)
                {
                    try
                    {
                        ClientConnection AcceptedClient = new ClientConnection(TCPListener.AcceptTcpClient());
                        
                        string notification = "\nNew client connected from " + AcceptedClient.GetClientIp() + ":" + AcceptedClient.GetClientPort() + "\n\n";
                        RichTextBox_Messages.Text += notification;
                        
                        string ClientName = MessageMethod.Recv(AcceptedClient.GetCurrentConnection()).Trim('\r', '\n');
                        AcceptedClient.SetClientName(ClientName);

                        BroadcastMessage(AcceptedClient.GetClientName() + " (" + AcceptedClient.GetClientIp() + ":" + AcceptedClient.GetClientPort()
                            + ") has connected\n\n");

                        ClientList.Add(AcceptedClient);
                        
                        Thread TcpThread = new Thread(ProcessingTcpClients);
                        TcpThread.IsBackground = true;
                        TcpThread.Start(AcceptedClient);
                    }
                    catch (Exception)
                    {
                        // Khi gọi TcpListener.Stop(), chương trình sẽ báo lỗi việc Listen bị gián đoạn (Blocking operation was interuptted)
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Port hiện đang được sử dụng. Vui lòng tắt ứng dụng đang sử dụng port rồi thử lại.", "Error");
                return;
            };
        }

        // Sau khi kết nối, mở 1 thread khác để nhận data từ client
        void ProcessingTcpClients(object obj)
        {
            ClientConnection AcceptedClient = (ClientConnection)obj;

            try
            {
                while (AcceptedClient.GetCurrentConnection().Client.Poll(-1, SelectMode.SelectRead)
                && AcceptedClient.GetCurrentConnection().Client.Available != 0)
                {
                    string message = DateTime.Now.ToString("HH:mm:ss")
                        + " " + AcceptedClient.GetClientName()
                        + ": " + MessageMethod.Recv(AcceptedClient.GetCurrentConnection());

                    RichTextBox_Messages.Text += message;
                    BroadcastMessage(message);
                }

                string notification = '\n' + AcceptedClient.GetClientName()
                    + " (" + AcceptedClient.GetClientIp()
                    + ':' + AcceptedClient.GetClientPort() + ") "
                    + "has disconnected\n\n";

                RichTextBox_Messages.Text += notification;
                BroadcastMessage(notification);

                AcceptedClient.GetCurrentConnection().Close();
                ClientList.Remove(AcceptedClient);
            }
            catch (Exception) { }; // Tương tự, như việc catch Exception ở dòng 69, để bỏ qua thông báo gián việc nhận dữ liệu
        }

        public void BroadcastMessage(string message)
        {
            foreach (ClientConnection ConnectedClient in ClientList)
            {
                MessageMethod.Send(ConnectedClient.GetCurrentConnection(), message);
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TCPListener != null)
            {
                KeepListening = false;
                foreach (ClientConnection ConnectedClient in ClientList)
                {
                    ConnectedClient.GetCurrentConnection().Close();
                }
                ClientList.RemoveAll(GetStatus);
                TCPListener.Stop();
            }
        }

        bool GetStatus(ClientConnection Client)
        {
            if (Client.GetCurrentConnection().Connected != false) return false;
            return true;
        }
    }
}
