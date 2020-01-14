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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDataGrid_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox2.Text, textBox3.Text, textBox4.Text);
        }

        private void BtnFotboll_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("HBK", "AIK", 4, 3);
            dataGridView2.Rows.Add("GIF", "Halmstad H", 0, 7);
            dataGridView2.Rows.Add("Cabbeh", "Rasse", 0, 0);
            dataGridView2.Rows.Add("Xbox", "PS", -4, -3);
        }

        private void Btnmal_Click(object sender, EventArgs e)
        {
            int biggestgoalie = 0;
            int goalie;
            for (int i = 0; i <= 3; i++)
            {
                string lagHemma = (string) dataGridView2.Rows[i].Cells[0].Value;
                string lagBorta = (string) dataGridView2.Rows[i].Cells[1].Value;

                int lagH = (int) dataGridView2.Rows[i].Cells[2].Value;
                int lagB = (int) dataGridView2.Rows[i].Cells[3].Value;
                if( lagH > lagB)
                {
                    goalie = lagH - lagB;
                    if (goalie > biggestgoalie) { biggestgoalie = goalie; }
                    MessageBox.Show(lagHemma + " vann med " + goalie + " mål");
                }
                else if ( lagB > lagH)
                {
                    goalie = lagB - lagH;
                    if (goalie > biggestgoalie) { biggestgoalie = goalie; }
                    MessageBox.Show(lagBorta + " vann med " + goalie + " mål");
                }
                else
                {
                    MessageBox.Show("Det blev lika mellan " + lagHemma + " och " + lagBorta);
                }
                
            }
            MessageBox.Show("Största målskillnaden var " + biggestgoalie);
        }

        private void BtnUpp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView2.SelectedRows.Count.ToString());
            if (dataGridView2.SelectedRows.Count == 1)
            {
                /*if (dataGridView2.SelectedRows.Cast<DataGridViewCell>().Select(c => c.RowIndex).Distinct().Count() > 1)
                {
                    MessageBox.Show("Vänligen välj från samma rad");
                    btnNer.Text = "Test1";
                }*/

                int rader = 0;
                DataGridViewRow rad = dataGridView2.SelectedRows[0];
                int raden = rad.Index;
                int kolumner = dataGridView2.SelectedCells.Count;
                string ord = "";
                for (int i = 0; i < kolumner; i++)
                {
                    if (dataGridView2.Rows[raden - 1].Cells[i].Value.ToString() != null || dataGridView2.Rows[raden].Cells[i].Value.ToString() != null)
                    {
                        ord = dataGridView2.Rows[raden - 1].Cells[i].Value.ToString();
                        btnadd.Text = ord;
                        dataGridView2.Rows[raden - 1].Cells[i].Value = dataGridView2.Rows[raden].Cells[i].Value;
                        dataGridView2.Rows[raden].Cells[i].Value = ord;
                    }
                    else { MessageBox.Show("någon av raderna har en tom ruta"); }
                }

                /*
                    int raden = rad.Index;
                    for ( int i = 0; i < 2; i--){
                    if ( dataGridView2.SelectedCells[i].Value != null)
                    {

                    }
                    else { i = 10; }
                    rader++;
                    
                }
                string ord = "";
                    for (int i = 0; i < rader; i++)
                {
                    ord = rad.Cells[i].Value.ToString();
                    dataGridView2.Rows[raden - 1].Cells[i].Value = dataGridView2.Rows[raden].Cells[i].Value;
                    dataGridView2.Rows[raden].Cells[i].Value = ord;
                    
                }
                        */
                btnNer.Text = "Test2";

            }
            else  /*(dataGridView2.SelectedRows.Count >= 1)*/
            {
                MessageBox.Show("Vänligen välj bara en rad!");
                btnNer.Text = "Test3";
            }

            /*else if (dataGridView2.SelectedRows.Cast<DataGridViewCell>().Select(c => c.RowIndex).Distinct().Count() > 1)
            {
                MessageBox.Show("Vänligen välj från samma rad");
            }*/
        }
    

        private void BtnNer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataGridView2.SelectedRows.Count.ToString());
            if (dataGridView2.SelectedRows.Count == 1)
            {
                /*if (dataGridView2.SelectedRows.Cast<DataGridViewCell>().Select(c => c.RowIndex).Distinct().Count() > 1)
                {
                    MessageBox.Show("Vänligen välj från samma rad");
                    btnNer.Text = "Test1";
                }*/

                    int rader = 0;
                    DataGridViewRow rad = dataGridView2.SelectedRows[0];
                    int raden = rad.Index;
                int kolumner = dataGridView2.SelectedCells.Count;
                string ord = "";
                for ( int i = 0; i < kolumner; i++)
                {
                    if (dataGridView2.Rows[raden + 1].Cells[i].Value.ToString() != null || dataGridView2.Rows[raden].Cells[i].Value.ToString() != null)
                    {
                        ord = dataGridView2.Rows[raden + 1].Cells[i].Value.ToString();
                        btnadd.Text = ord;
                        dataGridView2.Rows[raden + 1].Cells[i].Value = dataGridView2.Rows[raden].Cells[i].Value;
                        dataGridView2.Rows[raden].Cells[i].Value = ord;
                    }
                    else { MessageBox.Show("någon av raderna har en tom ruta"); }
                }

                /*
                    int raden = rad.Index;
                    for ( int i = 0; i < 2; i--){
                    if ( dataGridView2.SelectedCells[i].Value != null)
                    {

                    }
                    else { i = 10; }
                    rader++;
                    
                }
                string ord = "";
                    for (int i = 0; i < rader; i++)
                {
                    ord = rad.Cells[i].Value.ToString();
                    dataGridView2.Rows[raden - 1].Cells[i].Value = dataGridView2.Rows[raden].Cells[i].Value;
                    dataGridView2.Rows[raden].Cells[i].Value = ord;
                    
                }
                        */
                    btnNer.Text = "Test2";
                
            }
            else  /*(dataGridView2.SelectedRows.Count >= 1)*/
            {
                MessageBox.Show("Vänligen välj bara en rad!");
                btnNer.Text = "Test3";
            }
            
            /*else if (dataGridView2.SelectedRows.Cast<DataGridViewCell>().Select(c => c.RowIndex).Distinct().Count() > 1)
            {
                MessageBox.Show("Vänligen välj från samma rad");
            }*/
        }
    }
}
