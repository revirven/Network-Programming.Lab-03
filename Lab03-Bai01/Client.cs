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

namespace Lab03_Bai01
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void bttn_Send_Click(object sender, EventArgs e)
        {
            UdpClient udpClient = new UdpClient();
            Byte[] sendBytes = Encoding.UTF8.GetBytes(TextBox_Message.Text);

            int udpPort;
            bool is_Int = Int32.TryParse(TextBox_Port.Text, out udpPort);
            if (!is_Int) // Kiểm tra tính hợp lệ của Port
            {
                MessageBox.Show("Port không hợp lệ.", "Error");
                return;
            }

            IPAddress IPAddr;
            bool is_IP = IPAddress.TryParse(TextBox_IP.Text, out IPAddr);
            if (!is_IP) // Kiểm tra tính hợp lệ của IP Address
            {
                MessageBox.Show("IP không hợp lệ.", "Error");
                return;
            }

            udpClient.Send(sendBytes, sendBytes.Length, TextBox_IP.Text, udpPort);
            udpClient.Close(); // Đóng socket sau khi gửi
        }
    }
}
