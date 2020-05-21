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
using System.IO;

namespace slutprogrammering
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Första gången man väljer ett
        /// </summary>
        Kort figur1 = new Kort(-1,-1,-1);
        /// <summary>
        /// Andra kortet man väljer
        /// </summary>
        Kort figur2 = new Kort(-1,-1,-1);
        /// <summary>
        /// Håller reda på vilket drag det är.
        /// </summary>
        int val = 0;
        ///<summary> Håller reda på vilken spelare spelar just nu </summary>
        ushort spelare = 1;
        /// <summary>
        /// Hur många poäng spelare 1 har
        /// </summary>
        int poangspelare1 = 0;
        /// <summary>
        /// Hur många poäng spelare 2 har
        /// </summary>
        int poangspelare2 = 0;
        /// <summary>
        /// Lista med alla kort som innehåller position i x och y och sedan figuren.
        /// </summary>
        List<Kort> allakort =  new List<Kort>();
        
        public Form1()
        {
            InitializeComponent();
        }


        /* Råkade att dubbel klicka */
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
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
            MessageBox.Show((allakort[dgwtabell.ColumnCount * rad + kolumn].figuren == -1) +" "+(figur1.xposition == kolumn) + " " + (figur1.yposition == rad));
            if(allakort[dgwtabell.ColumnCount * rad + kolumn].figuren == -1 || (figur1.xposition == kolumn && figur1.yposition == rad)) 
            {
                MessageBox.Show("Vald ruta redan tagen");
                return;
            }
            //if (allakort[dgwtabell.ColumnCount * rad + kolumn])
            foreach (Kort k1 in allakort)
            {
                if (k1.xposition == kolumn && k1.yposition == rad)
                {
                    MessageBox.Show(k1.figuren.ToString());
                    if (val == 0)
                    {
                        figur1 = k1;
                    }
                    else
                    {
                        figur2 = k1;
                    }
                }
            }
            val++;
            checkDou();
            if (val > 1 )
            {
                dgwtabell.ClearSelection();
                val = 0;
                if (spelare == 1)
                {
                    spelare = 2;
                }  
                else
                {
                    spelare = 1;
                }
                figur1 = new Kort(-1, -1, -1); figur2 = new Kort(-1, -1, -1); 
                MessageBox.Show("Spelare bytad till " + spelare);
            }
        }
        ///<summary>
        /// Denna metoden tittar ifall de två valda korten är samma eller inte
        /// 
        /// </summary>
        private void checkDou()
        {
            if (figur1.figuren == figur2.figuren)
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
                    if(symbol.figuren == figur1.figuren || symbol.figuren == figur2.figuren)
                    {
                        int xpos = symbol.xposition;
                        int ypos = symbol.yposition;
                        dgwtabell.Rows[ypos].Cells[xpos].Style.BackColor = Color.Red;
                        allakort[dgwtabell.ColumnCount * ypos + xpos].figuren = -1;
                    }
                  }
            }
            else
            {
                
            }
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
        private void btnSpara_Click(object sender, EventArgs e)
        {
            DialogResult resultat = saveFileDialog1.ShowDialog();
            if(resultat == DialogResult.OK)
            {
                FileStream utström = new FileStream(saveFileDialog1.FileName,
                                                            FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter skrivare = new StreamWriter(utström);
                skrivare.WriteLine(spelare + " " + poangspelare1 + " " + poangspelare2 + " " + val);
                skrivare.WriteLine(dgwtabell.Columns.Count + " " + dgwtabell.Rows.Count);
                skrivare.WriteLine(figur1.xposition + " " + figur1.yposition + " " + figur1.figuren);
                foreach (Kort antal in allakort)
                {
                    skrivare.WriteLine(antal.xposition + " " + antal.yposition + " " + antal.figuren);
                    //skrivare.Write(antal.yposition + " ");
                    //skrivare.WriteLine(antal.figuren);
                }
                skrivare.Dispose();
            }
        }
        private void btnLaddaupp_Click(object sender, EventArgs e)
        {
            dgwtabell.ClearSelection();
            DialogResult resultat = openFileDialog1.ShowDialog();
            if(resultat == DialogResult.OK)
            {
                FileStream inStröm = new FileStream(openFileDialog1.FileName, FileMode.Open,
                                                    FileAccess.Read);
                StreamReader läsare = new StreamReader(inStröm);


                string rad = läsare.ReadLine();
                string[] variabel = rad.Split(' ');
                spelare = ushort.Parse(variabel[0]);
                poangspelare1 = int.Parse(variabel[1]);
                poangspelare2 = int.Parse(variabel[2]);
                val = int.Parse(variabel[3]);

                rad = läsare.ReadLine();
                variabel = rad.Split(' ');
                int kolumner = int.Parse(variabel[0]);
                int rader = int.Parse(variabel[1]);

                rad = läsare.ReadLine();
                variabel = rad.Split(' ');
                figur1 = new Kort(int.Parse(variabel[0]),int.Parse(variabel[1]),int.Parse(variabel[2]));

                //Först tas alla nuvarande kort bort sedan läggs alla kort från filen inmattade i listan.
                allakort.Clear();
                for(int i = 0; i < (kolumner * rader); i++)
                {
                    rad = läsare.ReadLine();
                    variabel = rad.Split(' ');
                    Kort kort = new Kort(int.Parse(variabel[0]), int.Parse(variabel[1]), int.Parse(variabel[2]));
                    allakort.Add(kort);
                }
                //Ser till att det blir rätt antal rader
                while(dgwtabell.Rows.Count != rader )
                {
                    if(dgwtabell.Rows.Count < rader)
                    {
                        dgwtabell.Rows.Add("");
                    }
                    else
                    {
                        dgwtabell.Rows.Remove(dgwtabell.Rows[0]);
                    }
                }
                //Ser till att det blir rätt antal kolumner
                while (dgwtabell.Columns.Count != kolumner)
                {
                    if (dgwtabell.Columns.Count < kolumner)
                    {
                        dgwtabell.Columns.Add("", "");
                    }
                    else
                    {
                        dgwtabell.Columns.Remove(dgwtabell.Columns[0]);
                    }
                }
                //Alla kort som har blivit tagna innan man sparade blir röda, så man kan ha koll.
                foreach(Kort rödakort in allakort)
                {
                    if(rödakort.figuren == -1)
                    {
                        dgwtabell.Rows[rödakort.yposition].Cells[rödakort.xposition].Style.BackColor = Color.Red;
                    }
                }

                lblnuvarandeSpelare.Text = "Spelare : " + spelare;
                lblspelare1Poäng.Text = "Spelare 1: " + poangspelare1;
                lblspelare2Poäng.Text = "Spelare 2: " + poangspelare2;

                string filText = läsare.ReadToEnd();
                Debug.WriteLine(filText);
                läsare.Dispose();
            }
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
