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
        int figur1 = -1;
        int figur2 = -1;
        int val = 0;
        ushort spelare = 1;
        int poangspelare1 = 0;
        int poangspelare2 = 0;
        List<Kort> allakort =  new List<Kort>();
        
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

            }
            
        }




        private void btnValj_Click(object sender, EventArgs e)
        {
            
        }



        //Lägg till och ta bort rader från spelbräddet
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
        // Ignonera detta ---------------------------------------------------------------------------
        private void dgwtabell_DoubleClick(object sender, EventArgs e){}
        //----------------------------------------------------------------------------------------------








        private void dgwtabell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rad = e.RowIndex;
            int kolumn = e.ColumnIndex;
            MessageBox.Show(kolumn.ToString() + " " + rad.ToString());

            foreach (Kort k1 in allakort)
            {
                if (k1.xposition == kolumn && k1.yposition == rad)
                {
                    MessageBox.Show(k1.figuren.ToString());
                    if (figur1 == -1)
                    {
                        figur1 = k1.figuren;

                    }
                    else
                    {
                        figur2 = k1.figuren;
                    }
                }
            }
            val++;
            if (val > 1 )
            {
                val = 0;
                if (spelare == 1)
                {
                    spelare = 2;
                }
                    
                else
                {
                    spelare = 1;
                }
                    

                MessageBox.Show("Spelare bytad till " + spelare);



            }

            
        }

        private void checkDou()
        {
            if(figur1 == figur2)
            {
                if (spelare == 1)
                    poangspelare1++;
                else
                    poangspelare2++;
            }
            else
            {
                
            }
        }


        private void btnSpara_Click(object sender, EventArgs e)
        {

        }

        private void btnLaddaupp_Click(object sender, EventArgs e)
        {

        }
    }
}
