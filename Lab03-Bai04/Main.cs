using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_Bai04
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_Server_Click(object sender, EventArgs e)
        {
            Server ServerForm = new Server();
            ServerForm.Show();
        }

        private void button_Client_Click(object sender, EventArgs e)
        {
            Client ClientForm = new Client();
            ClientForm.Show();
        }
    }
}
