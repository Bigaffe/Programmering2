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

namespace natverk1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            byte[] message = Encoding.Unicode.GetBytes(textBox3.Text);

            IPAddress serverIp = IPAddress.Parse( textBox1.Text);
            int port = int.Parse(textBox2.Text);
            IPEndPoint destination = new IPEndPoint(serverIp, port);

            UdpClient klient = new UdpClient();
            klient.Send(message, message.Length, destination);
        }
    }
}
