using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klasupg3
{
    public partial class Form1 : Form
    {

        List<distance> Distances = new List<distance>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegistrera_Click(object sender, EventArgs e)
        {
            double sträcka = double.Parse(tbxs.Text);
            double tid = double.Parse(tbxt.Text);
            double fart = (sträcka * 1000) / (tid * 60);
            distance calculate = new distance(tid, sträcka, fart);

            Distances.Add(calculate);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double search = double.Parse(tbxsearch.Text);
            int varv = Distances.Count;

            lbxlista.Items.Clear();
            for (int i = 0; i < varv; i++)
            {
                if (search == Distances[i].Time)
                {
                    lbxlista.Items.Add( Distances[i].Distance + " km") ;
                }

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double search = double.Parse(tbxsearch.Text);
            int varv = Distances.Count;

            lbxlista.Items.Clear();

            for (int i = 0; i <  varv; i++)
            {
                if (search == Distances[i].Distance)
                {
                    lbxlista.Items.Add(Distances[i].SPEED + " m/s");
                }

                        
            }
        }
    }
}
