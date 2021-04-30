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

namespace Lab03_Bai02
{
    public partial class Lab03_Bai02 : Form
    {
        Socket clientSocket;
        Socket listenerSocket;

        bool KeepListening = true;

        public Lab03_Bai02()
        {
            InitializeComponent();
        }

        private void bttn_Listen_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
        }

        void StartUnsafeThread()
        {
            int bytesReceived = 0;
            byte[] recv = new byte[1];

            IPEndPoint ipepServer = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            try
            {
                listenerSocket = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream,
                    ProtocolType.Tcp
                    );

                listenerSocket.Bind(ipepServer);

                bttn_Listen.Enabled = false;

                listenerSocket.Listen(-1);
                ListView_Commands.Items.Add(new ListViewItem("Telnet running on 127.0.0.1:8080"));
            }
            catch (Exception)
            {
                MessageBox.Show("Port 8080 hiện không khả dụng", "Error");
                return;
            }

            while (KeepListening)
            {
                try
                {
                    clientSocket = listenerSocket.Accept();
                    ListView_Commands.Items.Add(new ListViewItem("New client connected"));

                    // socket.connected chỉ trả về false khi phương thức socket.Close() được gọi.
                    // Sử dụng socket.Poll (Kiểm trạng thái của socket) kết hợp với socket.Available (Kiểm tra lượng data có thể đọc)
                    // để xác định được socket đã đóng hay chưa (Khi socket đóng, nó vẫn được xem là readable mặc dù không có data nào tồn tại,
                    // bằng chứng là một loạt các kí tự '\n' server nhận được sau khi gọi socket.Close()).
                    // Đối số -1 để tạm dừng chương trình vô thời hạn và chờ input của phía client.
                    while (clientSocket.Poll(-1, SelectMode.SelectRead) && clientSocket.Available != 0)
                    {
                        string text = "";
                        do
                        {
                            bytesReceived = clientSocket.Receive(recv);
                            text += Encoding.UTF8.GetString(recv);
                        } while (text[text.Length - 1] != '\n');

                        ListView_Commands.Items.Add(new ListViewItem(text));
                    }

                    ListView_Commands.Items.Add(new ListViewItem("Client disconnected"));
                    clientSocket.Close();
                }
                catch (Exception) { };
            }
        }

        private void Listener_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeepListening = false;
            if (listenerSocket != null)
            {
                listenerSocket.Close();
            }
        }
    }
}
