using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klassupg2
{
    public partial class Form1 : Form
    {
        pointclass[] person = new pointclass[100];
        int personlista = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnreg_Click(object sender, EventArgs e)
        {
            string namn = tbxnamn.Text;
            int points = int.Parse(tbxpoints.Text);
            if (namn != "")
            {
                pointclass nuvrande = new pointclass(namn, points);
                person[personlista++] = nuvrande;
            }
            else
            {
                MessageBox.Show("Skriv in namn!");
            }
            namn = "";
            points = 0;
            tbxnamn.Text = "";
            tbxpoints.Text = "";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            lbxlista.Items.Clear();
            int krav = 0;
            string kravet = "";
            kravet = tbxcheck.Text;
            if (kravet != "")
            {
                krav = int.Parse(tbxcheck.Text);
            }
            if (kravet == "vinnare" || kravet == "Vinnare")
            {
                string vinnaren = "";
                int vinnarep = person[0].points;
                for (int i = 0; i < personlista; i++)
                {
                    if (vinnarep < person[i].points)
                    {
                        vinnarep = person[i].points;
                        vinnaren = person[i].namn;
                    }
                }
                lbxlista.Items.Add(vinnaren + " vann!");
            }
            else
            {
                for (int i = 0; i < personlista; i++)
                {
                    if (person[i].points == krav)
                    {
                        lbxlista.Items.Add(person[i].namn);
                    }
                }
            }
        }
    }
}
