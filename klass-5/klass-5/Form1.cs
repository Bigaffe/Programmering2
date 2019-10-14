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
            lbxlista.Items.Add(rapport);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            lbxlista.Items.Clear();

            string gammalt = tbxGammaltnamn.Text;
            string nytt = tbxNyttnamn.Text;
            int antal = Rap.antalkunder;

            //---------------------------------------------------------------------

            /*for (int i = 0; i < antal; i++)
            {
                if (gammalt == Rapport[i].Kund)
                {
                    Rapport[i].Kund = nytt;
                    //Rapport[i].ändraKund(nytt);
                }
                lbxlista.Items.Add(Rapport[i]);
            }*/
            

            foreach(Rap r in Rapport)
            {
                if (gammalt == r.Kund)
                {
                    r.Kund = nytt;
                }
                lbxlista.Items.Add(r);
            }
            
            //---------------------------------------------------------------------
        }

        private void Button3_Click(object sender, EventArgs e)
        {            
            //Rap r = (Rap)lbxlista.SelectedItem;
            Rap r = lbxlista.SelectedItem as Rap;
            if (r != null)
            {
                tbxpris.Text = Math.Round((float)(r.Tid / 30), 0) * int.Parse(tbxTidvode.Text) / 2 + " kr";
            }
            else {MessageBox.Show("Verkar som någon har gått på LBS :) ");}
        }
    }
}
