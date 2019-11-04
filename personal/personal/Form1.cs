using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal
{
    public partial class Form1 : Form
    {
        List<Personal> arbetare = new List<Personal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsaljare_Click(object sender, EventArgs e)
        {
            string n = tbxsaljnamn.Text;
            double p = int.Parse(tbxprovision.Text);
            double f = int.Parse(tbxforsaljning.Text);
            new Saljare(n, p, f);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string n = tbxkonsultnamn.Text;
            double tl = int.Parse(tbxtimlon.Text);
            double t = int.Parse(tbxtid.Text);
            new Konsult(n, tl, t);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string n = tbxkontornamn.Text;
            double l = int.Parse(tbxmanadlon.Text);
            new Kontorist(n, l);

        }
    }
}
