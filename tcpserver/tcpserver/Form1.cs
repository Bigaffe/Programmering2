using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace tcpserver
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
            int port = 12345;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();

            klient = lyssnare.AcceptTcpClient();

            byte[] inData = new byte[256];

            int antalByte = klient.GetStream().Read(inData, 0, inData.Length);

            textBox1.Text = Encoding.Unicode.GetString(inData, 0, antalByte);
            klient.Close();
            lyssnare.Stop();
            
        }
    }
}
