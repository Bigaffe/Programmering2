using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banken
{
    public partial class Form1 : Form
    {
        List<Bank> Allakonton = new List<Bank>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnInsats_Click(object sender, EventArgs e)
        { //Insättning
            int positivsumma = int.Parse(tbxbelopp.Text);


        }

        private void BtnUttag_Click(object sender, EventArgs e)
        { //Uttag
            int negativsumma = int.Parse(tbxbelopp.Text);
            int index = lbxlista.SelectedIndex;


            if ( Allakonton[index].kredit != 0)
            {
                MessageBox.Show("Denna är ett lånekonto");
            }
            else
            {
                MessageBox.Show("Detta konto kan inte ha under 0kr");
            }

        }

        private void BtnRegistrera_Click(object sender, EventArgs e)
        { //Registrering 
            string personNr = tbxpersonnr.Text;
            double rantesats = double.Parse(tbxrantesats.Text);
            double kredit = 0;
            if (tbxkredit.Text != "")
            {
                kredit = double.Parse(tbxkredit.Text);
            }
            Bank nykund = new Bank(personNr, rantesats, kredit);
            Allakonton.Add(nykund);
            lbxlista.Items.Add(nykund);
        }

        private void BtnUppdate_Click(object sender, EventArgs e)
        { //Uppdatering

        }
    }
}
