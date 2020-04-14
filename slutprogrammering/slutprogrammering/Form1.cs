using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slutprogrammering
{
    public partial class Form1 : Form
    {
        List<Kort> allakort = new List<Kort>();
        public Form1()
        {
            
            InitializeComponent();
        }


        /* Råkade att dubbel klicka */
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //-----------------------------------

        private void btnTest_Click(object sender, EventArgs e)
        {

            int kolumner = dgwtabell.ColumnCount;
            int rader = dgwtabell.RowCount;
            int redokort = 0;
            int kort = rader * kolumner;
            if(kort%2 != 0)
            {
                btnAdd.Text = "Funker ej";
            }
            else
            {
                btnAdd.Text = "Hej";
                Random random = new Random();
                while (redokort < kort)
                {
                    int slumpafigur = random.Next(1, kort/2);
                    /*int slumpax = random.Next(1, kolumner - 1);
                    int slumpay = random.Next(1, rader - 1);*/

                    int xvärde = 0;
                    int yvärde = 0;
                    string figuren = "";
                    for(int i = 0; allakort.Count > i; i++)
                    {
                        if(slumpafigur < 2)
                        {
                            if(xvärde > kolumner)
                            {
                                xvärde = 1;
                                yvärde++;
                            }
                            Kort nyttkort = new Kort(xvärde, yvärde, figuren);
                            redokort++;

                        }

                        /*Tittar så det inte redan finns ett kort med samma x och värde. Kom direkt på att jag kan gå 1,1 1,2 1,3 istället för detta onödiga systemet. Har kvar det för visa mitt mistag
                        if (slumpax != allakort[i].xposition && slumpay != allakort[i].yposition){}*/
                        
                    }
                   
                }
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgwtabell.Rows.Add();
            dgwtabell.Columns.Add();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            dgwtabell.Rows.Remove(dgwtabell.Rows.Count);
        }

        private void btnValj_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
