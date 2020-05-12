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






        //Lägg till och ta bort rader från spelbräddet
        private void btntaBortRad_Click(object sender, EventArgs e)
        {
            dgwtabell.Rows.Remove(dgwtabell.Rows[0]);
            if(dgwtabell.Rows.Count == 2)
            {
                btntaBortRad.Enabled = false;
            }
            slumpa();
        }
        private void btntaBortKolumn_Click(object sender, EventArgs e)
        {
                dgwtabell.Columns.Remove(dgwtabell.Columns[0]);
                if(dgwtabell.Columns.Count == 2)
                {
                    btntaBortKolumn.Enabled = false;
                }
            slumpa();
        }
        private void btnlaggTillRad_Click(object sender, EventArgs e)
        {
            dgwtabell.Rows.Add("");
            btntaBortRad.Enabled = true;
            slumpa();
        }
        private void btnlaggTillKolumn_Click(object sender, EventArgs e)
        {
            dgwtabell.Columns.Add("","");
            btntaBortKolumn.Enabled = true;
            slumpa();
        }
        // Ignonera detta ---------------------------------------------------------------------------
        private void dgwtabell_DoubleClick(object sender, EventArgs e){}
        //----------------------------------------------------------------------------------------------

        private void dgwtabell_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rad = e.RowIndex;
            int kolumn = e.ColumnIndex;
            //MessageBox.Show(kolumn.ToString() + " " + rad.ToString());

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
            checkDou();
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

                figur1 = -1;figur2 = -1;

                MessageBox.Show("Spelare bytad till " + spelare);



            }

            
        }
        ///<summary>
        /// Denna metoden tittar ifall de två valda korten är samma eller inte
        /// 
        /// </summary>
        private void checkDou()
        {
            //Kan antingen gå igenom de som har den figuren och sedan "märka" den som tagen, eller kan jag skicka med det via metoden, dock är x/y positionerna inlåsta i en loop.
            if(figur1 == figur2)
            {
                if (spelare == 1)
                {
                    poangspelare1++;
                    lblspelare1Poäng.Text = "Spelare 1: " + poangspelare1;
                    val = 0;
                }
                else
                {
                    poangspelare2++;
                    lblspelare2Poäng.Text = "Spelare 2: " + poangspelare2;
                    val = 0;
                }
                
                  foreach(Kort symbol in allakort)
                  {
                    if(symbol.figuren == figur1)
                    {
                        int xpos = symbol.xposition;
                        int ypos = symbol.yposition;
                        dgwtabell.Rows[ypos].Cells[xpos].Style.BackColor = Color.Red;
                        allakort[symbol].figuren = -1;
                    }

                  }
            }
            else
            {
                
            }
            //---------------------------------------

        }
        ///<summary>
        ///  Slumpa alla kort.
        ///  Denna metoden slumpar fram alla kort ifall det är ett jämt antal kort
        /// </summary>
        private void slumpa()
        {
            int kolumner = dgwtabell.ColumnCount;
            int rader = dgwtabell.RowCount;
            int antalkort = rader * kolumner;
            if (antalkort % 2 != 0)
            {
                MessageBox.Show("Ha ett jämnt antal kort");
            }
            else
            {
                allakort.Clear();
                List<int> intevald = new List<int>();
                for (int j = 0; j < antalkort; j++)
                {
                    intevald.Add(j);
                    allakort.Add(new Kort(-1, -1, -1));
                }
                Debug.WriteLine(allakort.Count);
                for (int i = 0; i < antalkort / 2; i++)
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

                            if (i1 < i2)
                            {
                                intevald.RemoveAt(i1);
                                intevald.RemoveAt(i2 - 1);
                            }
                            else
                            {
                                intevald.RemoveAt(i2);
                                intevald.RemoveAt(i1 - 1);
                            }
                            int n = intevald.Count;
                            while (n > 1)
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
                    Debug.WriteLine("x:" + allakort[j].xposition + "   y:" + allakort[j].yposition + " || " + allakort[j].figuren);
                }

            }

        }
    


        //Vem är det som ska ta nästa drag, är det hens andra eller första?
        //Vilka kort är borta
        //Vilka kort är kvar
        //Hur många poäng varje spelare har.

        //Kort som redan är tagna ska inte kunna bli tagna igen, ifall ma klickar på ett kort som redan är taget så ska sitt drag inte tas bort.

        private void btnSpara_Click(object sender, EventArgs e)
        {

        }
        
        private void btnLaddaupp_Click(object sender, EventArgs e)
        {

        }







        private void Form1_Load(object sender, EventArgs e)
        {
            //Kunde inte hitta vart man la till en rad manuellt så den får läggas till automatiskt när programmet startas istället. 
            //Sedan slumpas korten, 
            dgwtabell.Rows.Add("");
            slumpa();
        }
    }
}
