using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inkopslista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //string varunamn = tbxVara.Text;
            //double varupris = double.Parse(tbxPris.Text);
            double varmangd = double.Parse(tbxMangd.Text);


            if ( rbnlosvikt.Checked == true)
            {
                lbxLista.Items.Add("Hej Hej");
            }
            else if ( rbnStycksak.Checked == true)
            {
                lbxLista.Items.Add(varmangd);
                int antal = (int)varmangd;
                lbxLista.Items.Add(antal);
            }
            else
            {
                lbxLista.Items.Add("välj en varutyp");
            }

            

        }
    }
}
