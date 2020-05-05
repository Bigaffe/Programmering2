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
        List<Kort> allakort =  new List<Kort>();
        //List<int> kortnummer = new List<int>();
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
            int antalkort = rader * kolumner;
            if(antalkort%2 != 0)
            {
                MessageBox.Show("Ha ett jämnt antal kort");
            }
            else
            {
                allakort.Clear();
                List<int> intevald = new List<int>();
                for(int j = 0; j < antalkort; j++)
                {
                    intevald.Add(j);
                    allakort.Add(new Kort(-1,-1,-1));
                }
                Debug.WriteLine(allakort.Count);
                for(int i = 0; i < antalkort / 2; i++)
                {
                    while (true)
                    {
                        Random random = new Random();
                        int i1 = random.Next(0, antalkort - (i * 2));
                        int i2 = random.Next(0, antalkort - (i * 2));
                        int index1 = intevald[i1];
                        int index2 = intevald[i2];
                        Debug.WriteLine(index1 + " " + index2);
                        if (index1 != index2 && allakort[index1].figuren == -1 && allakort[index2].figuren == -1)
                        {
                            int x = index1 % kolumner;
                            int y = index1 / kolumner;
                            allakort[index1] = new Kort(x, y, i);
                            x = index2 % kolumner;
                            y = index2 / kolumner;
                            allakort[index2] = new Kort(x, y, i);

                            if(i1 < i2)
                            {
                                intevald.RemoveAt(i1);
                                intevald.RemoveAt(i2 -1);
                            }
                            else
                            {
                                intevald.RemoveAt(i2);
                                intevald.RemoveAt(i1 -1);
                            }
                            int n = intevald.Count;
                            while(n > 1)
                            {
                                n--;
                                int k = random.Next(n + 1);
                                int temp = intevald[k];
                                intevald[k] = intevald[n];
                                intevald[n] = temp;
                            }
                                
                            break;

                        }
                    }
                    Debug.WriteLine(i);
                }
                Debug.WriteLine("Klar");
                for (int j = 0; j < antalkort; j++)
                {
                    Debug.WriteLine( "x:" + allakort[j].xposition + "   y:" + allakort[j].yposition + " || " + allakort[j].figuren);
                }







                /*while (redokort < antalkort)
                {




                    int slumpafigur = random.Next(1, antalkort/2);

                    Kort a = new Kort(1, 1, 1);
                    /*foreach(Kort k in allakort)
                    {
                        kortnummer.Add(k._figur)
                    }*/

                /*int slumpax = random.Next(1, kolumner - 1);
                int slumpay = random.Next(1, rader - 1);

                int xvärde = 0;
                int yvärde = 0;
                int figuren = 0;
                for(int i = 0; antalkort > i; i++)
                {
                    if(  < 2)
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
                    if (slumpax != allakort[i].xposition && slumpay != allakort[i].yposition){}

                }


            }*/
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
