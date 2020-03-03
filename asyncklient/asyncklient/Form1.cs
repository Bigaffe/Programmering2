using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace asyncklient
{

    public partial class Form1 : Form
    {
        TcpClient klient = new TcpClient();
        int port = 12345;

        
        

        public Form1()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }

        private void btnanslut_Click(object sender, EventArgs e)
        {
            
        }
        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(textBox1.Text);
                await klient.ConnectAsync(adress, port);
            }
            catch ( Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }
            Btnsend.Enabled = true;
            btnanslut.Enabled = false;
        }

        private void Btnsend_Click(object sender, EventArgs e)
        {
            StartaSändning("Hej");
        }
        public async void StartaSändning (string message)
        {
            byte[] utData = Encoding.Unicode.GetBytes(tbxmessage.Text + "\r\n" );
            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
            }
            catch(Exception error) { MessageBox.Show(error.Message, Text); return; }
        }

        private void Btnanslut_Click_1(object sender, EventArgs e)
        {
            if (!klient.Connected) StartaAnslutning();
        }
    }
}
