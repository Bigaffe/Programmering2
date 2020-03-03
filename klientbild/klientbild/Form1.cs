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

namespace klientbild
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

        private void BtnAnslut_Click(object sender, EventArgs e)
        {
            if (!klient.Connected) StartaAnslutning();
        }
        public async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxPort.Text);
                await klient.ConnectAsync(adress, port);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }
            //Btnsend.Enabled = true;
            //btnanslut.Enabled = false;
        }

        private void BtnUpp_Click(object sender, EventArgs e)
        {
            string direction = "U";
            StartaSändning(direction);
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            string direction = "L";
            StartaSändning(direction);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            string direction = "H";
            StartaSändning(direction);
            
        }

        private void BtnNer_Click(object sender, EventArgs e)
        {
            string direction = "N";
            StartaSändning(direction);
        }
        public async void StartaSändning(string direction)
        {
            byte[] utData = Encoding.Unicode.GetBytes(direction);
            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }
        }
    }
}
