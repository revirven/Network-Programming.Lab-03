using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai01
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Lab03_Bai01_Load(object sender, EventArgs e)
        {

        }

        private void bttn_Client_Click(object sender, EventArgs e)
        {
            Client Lab03_Bai01_Client = new Client();
            Lab03_Bai01_Client.Show();
        }

        private void bttn_Server_Click(object sender, EventArgs e)
        {
            Server Lab03_Bai01_Client = new Server();
            Lab03_Bai01_Client.Show();
        }
    }
}
