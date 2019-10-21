using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kap2_upg1
{
    public partial class Form1 : Form
    {

        List<Titel> biblotek = new List<Titel>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnbok_Click(object sender, EventArgs e)
        {
            string titeln = tbxboktitel.Text;
            int antalsidor = int.Parse(tbxsidor.Text);

            Bok nybok = new Bok(titeln, antalsidor);


            lbxLista.Items.Add(nybok);
            biblotek.Add(nybok);
        }

        private void Btnljud_Click(object sender, EventArgs e)
        {
            string titeln = tbxljudtitel.Text;
            double speltid = double.Parse(tbxljudtid.Text);

            Ljud nyljud = new Ljud(titeln, speltid);

            lbxLista.Items.Add(nyljud);
            biblotek.Add(nyljud);

        }

        private void Btnfilm_Click(object sender, EventArgs e)
        {
            string titeln = tbxfilmtitel.Text;
            double speltid = double.Parse(tbxfilmtid.Text);
            string upplosning = tbxuppl.Text;

            Film nyfilm = new Film(titeln, speltid, upplosning);

            lbxLista.Items.Add(nyfilm);
            biblotek.Add(nyfilm);
        }
    }
}
