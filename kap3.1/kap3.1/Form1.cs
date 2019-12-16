using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kap3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VäljFärgToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgcolor.ShowDialog();
            if ( r == DialogResult.OK){tabcontrolen.SelectedTab.BackColor = dlgcolor.Color;}
        }

        private void VäljMappToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult f = folderdialog.ShowDialog();
            //if ( f = DialogResult.OK){this.= folderdialog.SelectedPath }
        }

        private void VäljTeckensnittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult fd = fontdialog.ShowDialog();

            //FontDialog fd = fontdialog.Font();
            //if ( fd == FontDialog.OK) { }
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            //tabcontrolen.SelectedTab.Text = tbxtext.Text;
            //tabcontrolen.SelectedTab.
        }
    }
}
