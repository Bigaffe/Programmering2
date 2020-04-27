using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace slutprogrammering
{
    public partial class Form1 : Form
    {
        string forregaendekort = "";
        int val = 0;
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
                MessageBox.Show("Ha ett jämnt antal kort");
            }
            else
            {
                Random random = new Random();
                while (redokort < kort)
                {
                    int slumpafigur = random.Next(1, kort/2);
                    if()

                    /*int slumpax = random.Next(1, kolumner - 1);
                    int slumpay = random.Next(1, rader - 1);*/

                    int xvärde = 0;
                    int yvärde = 0;
                    string figuren = "";
                    for(int i = 0; kort > i; i++)
                    {
                        if( < 2)
                        {
                            xvärde++;
                            if(xvärde > kolumner)
                            {
                                xvärde = 0;
                                yvärde++;
                            }
                            
                            Kort nyttkort = new Kort(xvärde, yvärde, figuren);
                            allakort.Add(nyttkort);
                            redokort++;


                            Debug.WriteLine(figuren + "figur " );
                        }
                        else
                        {
                            MessageBox.Show("Du tänkte fel mupp");
                        }

                        /*Tittar så det inte redan finns ett kort med samma x och värde. Kom direkt på att jag kan gå 1,1 1,2 1,3 istället för detta onödiga systemet. Har kvar det för visa mitt mistag
                        if (slumpax != allakort[i].xposition && slumpay != allakort[i].yposition){}*/

                    }

                   
                }
            }
            
        }
        private void btnValj_Click(object sender, EventArgs e)
        {
            
        }

       
        private void btntaBortRad_Click(object sender, EventArgs e)
        {
            dgwtabell.Rows.Remove(dgwtabell.Rows[0]);
            if(dgwtabell.Rows.Count == 0)
            {
                btntaBortRad.Enabled = false;
            }
        }

        private void btntaBortKolumn_Click(object sender, EventArgs e)
        {
                dgwtabell.Columns.Remove(dgwtabell.Columns[0]);
                if(dgwtabell.Columns.Count == 0)
                {
                    btntaBortKolumn.Enabled = false;
                }
        }

        private void btnlaggTillRad_Click(object sender, EventArgs e)
        {
            dgwtabell.Rows.Add("");
            btntaBortRad.Enabled = true;

           

        }

        private void btnlaggTillKolumn_Click(object sender, EventArgs e)
        {
            dgwtabell.Columns.Add("","");
            btntaBortKolumn.Enabled = true;
            
        }

        private void dgwtabell_DoubleClick(object sender, EventArgs e)
        {
            

            //int tempo = int.Parse(dgwtabell.SelectedCells[0].Value.ToString());
            //MessageBox.Show(tempo.ToString());
            /*int temp = int.Parse(dgwtabell.SelectedCells[0].Value.ToString());
            MessageBox.Show(temp.ToString());*/

            /*DataGridViewCell cell = dgwtabell.SelectedCells[0] as DataGridViewCell;
            string value = cell.Value.ToString();
            MessageBox.Show(value);*/


            /*if(dgwtabell.SelectedCells[0] != null && dgwtabell.SelectedCells[0] != null)
            {
                MessageBox.Show("Testing");   
            }*/

        }

        private void dgwtabell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rad = e.RowIndex;
            int kolumn = e.ColumnIndex;
            MessageBox.Show(rad.ToString() + " " + kolumn.ToString());
            if(val == 0)
            {
                
                //allakort[kolumn + rad * dgwtabell.Columns.Count].xposition 
                
                //val++;
            }
            else
            {
                
            }
            
        }
    }
}
