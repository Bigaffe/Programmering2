using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inkopslista
{
    public partial class InputBox : Form
    {
        public static int tal;
        public InputBox()
        {
            InitializeComponent();
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tal = int.Parse(textBox1.Text);
            Form1.tal = tal;
            this.Close();
        }
    }
}
