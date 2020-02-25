using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace tcpklient
{

    public partial class Form1 : Form
    {
        TcpClient klient;
        int port = 12345;




        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IPAddress adress = IPAddress.Parse(textBox1.Text);
            klient = new TcpClient();
            klient.NoDelay = true;
            if (!klient.Connected)
            {
                klient.Connect(adress, port);
            }
            //try
            //{


                if (klient.Connected)
                {
                    byte[] utData = Encoding.Unicode.GetBytes(textBox2.Text);
                    klient.GetStream().Write(utData, 0, utData.Length);
                    klient.Close();
                }
            //}
            /*catch
            {
                byte[] utData = Encoding.Unicode.GetBytes(textBox2.Text);
                klient.GetStream().Write(utData, 0, utData.Length);
                klient.Close();

            }
            */

        }
    }
}
