using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai03
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_Server_Click(object sender, EventArgs e)
        {
            Server TCPServer = new Server();
            TCPServer.Show();
        }

        private void button_Client_Click_1(object sender, EventArgs e)
        {
            Client TCPClient = new Client();
            TCPClient.Show();
        }
    }
}
