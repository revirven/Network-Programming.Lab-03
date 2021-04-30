using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Lab03_Bai04
{
    // Class dùng để gửi và nhận messages
    class Message
    {
        public void Send(TcpClient SendTarget, string message)
        {
            byte[] ByteBuffer = Encoding.UTF8.GetBytes(message);
            NetworkStream ns = SendTarget.GetStream();
            ns.Write(ByteBuffer);
        }

        public string Recv(TcpClient RecvTarget)
        {
            string message = "";
            do
            {
                byte[] BytesReceived = new byte[1];
                NetworkStream ns = RecvTarget.GetStream();
                ns.Read(BytesReceived);
                message += Encoding.UTF8.GetString(BytesReceived);
            } while (message[message.Length - 1] != '\n');

            return message;
        }
    }
}
