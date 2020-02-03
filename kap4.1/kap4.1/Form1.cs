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

namespace kap4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string fornamn = textBox1.Text;
            string efternamn = textBox2.Text;
            string telefon = textBox3.Text;

            DialogResult resultat = saveFileDialog1.ShowDialog();

            if (resultat == DialogResult.OK)
            {
                FileStream utstrom = new FileStream(saveFileDialog1.FileName,
                                                    FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter skrivare = new StreamWriter(utstrom);
                skrivare.WriteLine(textBox1.Text);
                skrivare.WriteLine(textBox2.Text);
                skrivare.WriteLine(textBox3.Text);
                skrivare.Dispose();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult resulat = openFileDialog1.ShowDialog();
            if (resulat == DialogResult.OK) {
                FileStream instrom = new FileStream(openFileDialog1.FileName, FileMode.Open,
                                                    FileAccess.Read);
                StreamReader lasare = new StreamReader(instrom);
                string fornamn = lasare.ReadLine();
                string efternamn = lasare.ReadLine();
                string telefon = lasare.ReadLine();
                textBox1.Text = fornamn;
                textBox2.Text = efternamn;
                textBox3.Text = telefon;

                lasare.Dispose();
            }
       }
    }
}
