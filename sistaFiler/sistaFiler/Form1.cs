using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sistaFiler
{
    public partial class Form1 : Form
    {

        List<Inne> innehall = new List<Inne>();
        public Form1()
        {
            InitializeComponent();
        }

        //Lägg till ny ingrediens till receptet
        private void Button1_Click(object sender, EventArgs e)
        {
            string ingrediens = tbxIngrediens.Text;
            double mangd = double.Parse(tbxMangd.Text);
            string matt = tbxMatt.Text;
            Inne nyingrediens = new Inne(ingrediens, mangd, matt);
            string mängd = mangd.ToString();
            dataGridView1.Rows.Add(ingrediens, mängd, matt);
            innehall.Add(nyingrediens);
        }


        //Öppna upp en fil
        private void ÖppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult resulat = openfile.ShowDialog();
            if (resulat == DialogResult.OK)
            {
                FileStream instrom = new FileStream(openfile.FileName, FileMode.Open,
                                                    FileAccess.Read);
                StreamReader lasare = new StreamReader(instrom);
                string fornamn = lasare.ReadLine();
                string efternamn = lasare.ReadLine();
                string telefon = lasare.ReadLine();
                /*textBox1.Text = fornamn;
                textBox2.Text = efternamn;
                textBox3.Text = telefon;*/

                lasare.Dispose();
                
            }
        }
        //Spara din fil
        private void SparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultat = sparafil.ShowDialog();
            string mangd;
            string ingrediens;
            string matt;
            if (resultat == DialogResult.OK)
            {
                FileStream utstrom = new FileStream(sparafil.FileName,
                                                    FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter skrivare = new StreamWriter(utstrom);
                int antal = dataGridView1.Rows.Count;
                for (int i = 1; i < antal; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value != null)
                    {
                        ingrediens = (string)dataGridView1.Rows[i].Cells[0].Value;
                    }
                    if (dataGridView1.Rows[i].Cells[1].Value != null)
                    {
                        mangd = (string)dataGridView1.Rows[i].Cells[1].Value;
                    }
                    if (dataGridView1.Rows[i].Cells[2].Value != null)
                    {
                         matt = (string)dataGridView1.Rows[i].Cells[2].Value;
                    }
                    skrivare.WriteLine(ingrediens, mangd, matt);

                }
                /*skrivare.WriteLine(textBox1.Text);
                skrivare.WriteLine(textBox2.Text);
                skrivare.WriteLine(textBox3.Text);*/
                skrivare.Dispose();
            }
        }
    }
}
