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
using System.Diagnostics;

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
                btnLeft.Enabled = true;
                btnNer.Enabled = true;
                btnRight.Enabled = true;
                btnUpp.Enabled = true;
                btnAnslut.Enabled = false;
                StartaLäsning(klient);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }


        }

        private void BtnUpp_Click(object sender, EventArgs e)
        {
            string direction = "U";
            btnNer.Enabled = true;
            StartaSändning(direction);
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            string direction = "L";
            btnRight.Enabled = true;
            StartaSändning(direction);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            string direction = "H";
            btnLeft.Enabled = true;
            StartaSändning(direction);

        }

        private void BtnNer_Click(object sender, EventArgs e)
        {
            string direction = "N";
            btnUpp.Enabled = true;
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
        public async void StartaLäsning(TcpClient k)
        {
            byte[] buffert = new byte[1024];
            int n = 0;
            try
            {
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }
            string test = Encoding.Unicode.GetString(buffert, 0, n);
            Debug.WriteLine(test);
            if (test == "vstop")
            {
                btnLeft.Enabled = false;
            }
            if (test == "hstop")
            {
                btnRight.Enabled = false;
            }
            if (test == "ustop")
            {
                btnUpp.Enabled = false;
            }
            if (test == "nstop")
            {
                btnNer.Enabled = false;
            }
            //MessageBox.Show(test);
            StartaLäsning(k);


        }
    }
}
