namespace sistaFiler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxIngrediens = new System.Windows.Forms.TextBox();
            this.tbxMangd = new System.Windows.Forms.TextBox();
            this.tbxMatt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.sparafil = new System.Windows.Forms.SaveFileDialog();
            this.menustrip = new System.Windows.Forms.MenuStrip();
            this.akrivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öppnaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaSomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mangd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxIngrediens
            // 
            this.tbxIngrediens.Location = new System.Drawing.Point(62, 35);
            this.tbxIngrediens.Name = "tbxIngrediens";
            this.tbxIngrediens.Size = new System.Drawing.Size(100, 20);
            this.tbxIngrediens.TabIndex = 0;
            // 
            // tbxMangd
            // 
            this.tbxMangd.Location = new System.Drawing.Point(62, 62);
            this.tbxMangd.Name = "tbxMangd";
            this.tbxMangd.Size = new System.Drawing.Size(100, 20);
            this.tbxMangd.TabIndex = 1;
            // 
            // tbxMatt
            // 
            this.tbxMatt.Location = new System.Drawing.Point(62, 89);
            this.tbxMatt.Name = "tbxMatt";
            this.tbxMatt.Size = new System.Drawing.Size(100, 20);
            this.tbxMatt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrediens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mängd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mått";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lägg till";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.main,
            this.Mangd,
            this.matt});
            this.dataGridView1.Location = new System.Drawing.Point(62, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(317, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // openfile
            // 
            this.openfile.FileName = "openFileDialog1";
            // 
            // menustrip
            // 
            this.menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.akrivToolStripMenuItem});
            this.menustrip.Location = new System.Drawing.Point(0, 0);
            this.menustrip.Name = "menustrip";
            this.menustrip.Size = new System.Drawing.Size(392, 24);
            this.menustrip.TabIndex = 8;
            this.menustrip.Text = "menuStrip1";
            // 
            // akrivToolStripMenuItem
            // 
            this.akrivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öppnaToolStripMenuItem,
            this.sparaSomToolStripMenuItem});
            this.akrivToolStripMenuItem.Name = "akrivToolStripMenuItem";
            this.akrivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.akrivToolStripMenuItem.Text = "Akriv";
            // 
            // öppnaToolStripMenuItem
            // 
            this.öppnaToolStripMenuItem.Name = "öppnaToolStripMenuItem";
            this.öppnaToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.öppnaToolStripMenuItem.Text = "Öppna";
            this.öppnaToolStripMenuItem.Click += new System.EventHandler(this.ÖppnaToolStripMenuItem_Click);
            // 
            // sparaSomToolStripMenuItem
            // 
            this.sparaSomToolStripMenuItem.Name = "sparaSomToolStripMenuItem";
            this.sparaSomToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sparaSomToolStripMenuItem.Text = "Spara som...";
            this.sparaSomToolStripMenuItem.Click += new System.EventHandler(this.SparaSomToolStripMenuItem_Click);
            // 
            // main
            // 
            this.main.HeaderText = "Ingrediens";
            this.main.Name = "main";
            // 
            // Mangd
            // 
            this.Mangd.HeaderText = "Mängd";
            this.Mangd.Name = "Mangd";
            // 
            // matt
            // 
            this.matt.HeaderText = "Mått";
            this.matt.Name = "matt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxMatt);
            this.Controls.Add(this.tbxMangd);
            this.Controls.Add(this.tbxIngrediens);
            this.Controls.Add(this.menustrip);
            this.MainMenuStrip = this.menustrip;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menustrip.ResumeLayout(false);
            this.menustrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIngrediens;
        private System.Windows.Forms.TextBox tbxMangd;
        private System.Windows.Forms.TextBox tbxMatt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.SaveFileDialog sparafil;
        private System.Windows.Forms.MenuStrip menustrip;
        private System.Windows.Forms.ToolStripMenuItem akrivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öppnaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaSomToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn main;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mangd;
        private System.Windows.Forms.DataGridViewTextBoxColumn matt;
    }
}

