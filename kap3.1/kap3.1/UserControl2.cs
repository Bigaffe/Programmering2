using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kap3._1
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void Tbxtextlangd_TextChanged(object sender, EventArgs e)
        {
            int maxlangd = 140;
            int langd = tbxtextlangd.TextLength;
            for (int i = 0; i < langd; i++)
            {
                maxlangd = maxlangd - 1;
            }
            lbltextchanged.Text = maxlangd.ToString();
        }
    }
}
