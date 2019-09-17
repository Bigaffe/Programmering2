using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klassupg1
{
    public partial class Form1 : Form
    {
        Resa[] resor = new Resa[100];
        int reselista = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnboka_Click(object sender, EventArgs e)
        {
            string kund = tbxKund.Text;
            string destination = tbxdestination.Text;
            int dagar = int.Parse(tbxdagar.Text);

            resor[reselista++] = new Resa(kund, destination, dagar);
            
            //resor[reselista] = 
                

        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            lbxlista.Items.Clear();
            string kund = tbxsearch.Text;
            
            for (int i = 0; i < reselista; i++)
            {
                if (resor[i].Kund == kund)
                {
                    lbxlista.Items.Add(resor[i].destination + " " + resor[i].dagar);
                }
            }
            for (int i = 0; i < reselista; i++)
            {
                if (resor[i].destination == kund)
                {
                    lbxlista.Items.Add(resor[i].kund);
                }
            }
            //for (int i = 0; i < reselista; i++)
            //{
            //    if (resor[i].dagar >= 10)
            //    {
            //        lbxlista.Items.Add(res)
            //    }
            //}
            //lbxlista.Text = resor[reselista]
        }
    }
}
