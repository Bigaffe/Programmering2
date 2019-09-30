using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klass_5
{
    public partial class Form1 : Form
    {
        List<Rap> Rapport = new List<Rap>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string kund = tbxKund.Text;
            int tid = int.Parse(tbxTid.Text);

            Rap rapport = new Rap(kund, tid);

            //int antal = Rap.antalkunder;
            Rapport.Add(rapport);
            lbxlista.Items.Add(kund + " " + tid);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lbxlista.Items.Clear();

            string gammalt = tbxGammaltnamn.Text;
            string nytt = tbxNyttnamn.Text;
            int antal = Rap.antalkunder;
            for (int i = 0; i < antal; i++)
            {
                if (gammalt == Rapport[i].Kund)
                {
                    Rapport[i].Kund = nytt;
                    //Rapport[i].ändraKund(nytt);
                }
            }
            foreach(Rap r in Rapport)
            {
                if (gammalt == r.Kund)
                {
                    r.Kund = nytt;
                }
            }

            //for (int i = 0; i < antal; i++)
            //{
            //    lbxlista.Items.Add(rapport);
            //}

        }
    }
}
