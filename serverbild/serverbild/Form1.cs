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

namespace serverbild
{
    
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 12345;

        int xpos =280;
        int ypos =180;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text); return;
            }
            StartaMottagning();

        }
        public async void StartaMottagning()
        {
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }
            StartaLäsning(klient);
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
            if (test == "N")
            {
                lblAirplane.Location = new Point(xpos, ypos = ypos+10);
            } 
            else if (test == "U")
            {
                lblAirplane.Location = new Point(xpos, ypos = ypos-10);
            }
            else if (test == "L")
            {
                lblAirplane.Location = new Point(xpos = xpos-10, ypos);
            }

            else if (test == "H")
            {
                lblAirplane.Location = new Point(xpos = xpos+10, ypos);
            }
            if (lblAirplane.Location.X == 0)
            {
                string position = "vstop";
                StartaSändning(position);
            }
            else if (lblAirplane.Location.X == 780)
            {
                string position = "hstop";
                StartaSändning(position);
            }
            else if(lblAirplane.Location.Y == 0)
            {
                string position = "ustop";
                StartaSändning(position);
            }
            else if (lblAirplane.Location.Y == 480)
            {
                string position = "nstop";
                StartaSändning(position);
            }
            //StartaSändning("hej");
            //textBox1.AppendText(Encoding.Unicode.GetString(buffert, 0, n));
            StartaLäsning(k);
        }
        public async void StartaSändning(string positionen)
        {
            byte[] utData = Encoding.Unicode.GetBytes(positionen);
            try
            {
                await klient.GetStream().WriteAsync(utData, 0, utData.Length);

            }
            catch (Exception error) { MessageBox.Show(error.Message, Text); return; }
        }

    }
}
