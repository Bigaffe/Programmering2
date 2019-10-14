using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovn1._5
{
    public partial class Form1 : Form
    {
        List<Fordon> vechiles = new List<Fordon>();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Btnreg_Click(object sender, EventArgs e)
        {
            string registeringsnummer = tbxregnr.Text;
            string bilmarke = tbxmarke.Text;
            string arsmodell = tbxmodell.Text;
            


            Fordon.FordonsTyp bilMC = Fordon.FordonsTyp.ickevald;
            if (cbxtyp.Text == "Bil")
            {
                bilMC = Fordon.FordonsTyp.Bilar;
            }
            else if (cbxtyp.Text == "MC")
            {
                bilMC = Fordon.FordonsTyp.MC;
            }
            else
            {
                MessageBox.Show("Välj en fordonstyp jävla mongo!");
            }
            



            Fordon vechiles = new Fordon(registeringsnummer, bilmarke, arsmodell, bilMC);




        }

        









        private void RbnBilar_Click(object sender, EventArgs e)
        {
            foreach (Fordon f in vechiles)
            {
                if (f.fordonstypen = )
                {
                    //lbxlista.Items.Add(vechiles[f]);
                }
            }
            lbxlista.Items.Clear();
        }

        private void RbnAlla_Click(object sender, EventArgs e)
        {
            lbxlista.Items.Clear();
        }

        private void RbnMC_Click(object sender, EventArgs e)
        {
            lbxlista.Items.Clear();
        }
    }
}
