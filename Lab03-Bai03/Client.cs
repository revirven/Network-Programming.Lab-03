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

namespace Lab03_Bai03
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void button_SendMessage_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint EndPoint = new IPEndPoint(ip, 8080);

            try
            {
                tcpClient.Connect(EndPoint);

                NetworkStream ns = tcpClient.GetStream();

                Byte[] Data = System.Text.Encoding.UTF8.GetBytes("Hello server\n");
                ns.Write(Data, 0, Data.Length);

                Data = System.Text.Encoding.UTF8.GetBytes("Quit\n");
                ns.Write(Data, 0, Data.Length);

                ns.Close();
                tcpClient.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Server hiện đang không hoạt động", "Error");
                return;
            }
        }
    }
}
