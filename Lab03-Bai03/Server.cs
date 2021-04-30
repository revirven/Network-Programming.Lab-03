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
using System.Net.NetworkInformation;

namespace Lab03_Bai03
{
    public partial class Server : Form
    {
        Socket ClientSocket;
        Socket ListenerSocket;
        bool KeepListening = true;

        public Server()
        {
            InitializeComponent();
        }

        private void button_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Thread ServerThread = new Thread(new ThreadStart(StartTCPThread));
            ServerThread.Start();
        }

        void StartTCPThread()
        {
            int BytesReceived = 0;

            byte[] Recv = new byte[1];

            ListenerSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );

            IPEndPoint EndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            try
            {
                ListenerSocket.Bind(EndPoint);
                button_Listen.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Port 8080 hiện đang được sử dụng. Vui lòng đóng kết nối trước khi thực hiện Listen", "Error");
                return;
            }

            ListenerSocket.Listen(-1);
            ListView_Messages.Items.Add(new ListViewItem("Server running on 127.0.0.1:8080"));

            while(KeepListening)
            {
                try
                {
                    ClientSocket = ListenerSocket.Accept();
                    ListView_Messages.Items.Add(new ListViewItem("New client connected"));

                    while (ClientSocket.Poll(-1, SelectMode.SelectRead) && ClientSocket.Available != 0)
                    {
                        string text = "";

                        do
                        {
                            BytesReceived = ClientSocket.Receive(Recv);
                            text += Encoding.UTF8.GetString(Recv);
                        } while (text[text.Length - 1] != '\n');

                        ListView_Messages.Items.Add(new ListViewItem(text));
                    }

                    // Báo hiệu bên client đã đóng kết nối
                    ListView_Messages.Items.Add(new ListViewItem("Connection closed from client"));
                }
                catch (Exception) { };
            }
        }

        private void Server_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeepListening = false;
            if (ListenerSocket != null)
            {
                ListenerSocket.Close();
            }
        }
    }
}
