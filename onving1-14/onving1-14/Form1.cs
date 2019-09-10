using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onving1_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            int storlek = int.Parse(mupstorlek.Text);

            FontStyle stil = FontStyle.Regular;

            if (cbxFet.Checked)
            {
                stil = stil | FontStyle.Bold;
            }
            if (cbxkursiv.Checked)
            {
                stil = stil | FontStyle.Italic;
            }
            


            Font font = new Font(tbxtext.Text, storlek , stil);
            tbxtext.Font = font;




        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
