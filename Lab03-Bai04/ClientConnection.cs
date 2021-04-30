using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace Lab03_Bai04
{
    // Class dùng để lấy kết nối đến Client và tên của Client
    class ClientConnection
    {
        TcpClient connection;
        string name;

        public ClientConnection(TcpClient AcceptedClient)
        {
            connection = AcceptedClient;
        }

        public ClientConnection(ClientConnection AnotherConnection)
        {
            this.connection = AnotherConnection.connection;
            this.name = AnotherConnection.name;
        }

        public string GetClientIp()
        {
            string ip = ((IPEndPoint)connection.Client.RemoteEndPoint).Address.ToString();
            return ip;
        }

        public string GetClientPort()
        {
            string port = ((IPEndPoint)connection.Client.RemoteEndPoint).Port.ToString();
            return port;
        }

        public string GetClientName()
        {
            return name;
        }

        public TcpClient GetCurrentConnection()
        {
            return connection;
        }

        public void SetClientName(string ClientName)
        {
            this.name = ClientName;
        }
    }
}
