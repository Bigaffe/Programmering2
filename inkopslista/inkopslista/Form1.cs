using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace inkopslista
{
    public partial class Form1 : Form
    {
        public static int tal;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            double varmangd = 0;
            
            if (tbxMangd.Text == ""){MessageBox.Show("Skriv i mängd"); varmangd = 1;} else { varmangd = double.Parse(tbxMangd.Text);}
            if(tbxPris.Text == ""){ MessageBox.Show("Skriv i pris"); double pris = 0 ;} else {double pris = double.Parse(tbxPris.Text);}
            if(tbxVara.Text == ""){MessageBox.Show("Skriv i vara"); string vara = " "; } else { string vara = tbxVara.Text;}
            //string varunamn = tbxVara.Text;
            //double varupris = double.Parse(tbxPris.Text);
            

            


            if ( rbnlosvikt.Checked == true)
            {
                lbxLista.Items.Add("lösvikt");
                rbnlosvikt.Checked = false;
            }
            else if ( rbnStycksak.Checked == true)
            {
                lbxLista.Items.Add(varmangd);
                int antal = (int)varmangd;
                lbxLista.Items.Add(antal);
                rbnStycksak.Checked = false;
            }
            else
            {
                lbxLista.Items.Add("Välj en varutyp");
            }

            

        }
    }
}
