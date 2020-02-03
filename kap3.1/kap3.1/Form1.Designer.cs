namespace kap3._1
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
            this.musMenu = new System.Windows.Forms.MenuStrip();
            this.väljFärgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljFärgToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.väljMappToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.väljTeckensnittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgcolor = new System.Windows.Forms.ColorDialog();
            this.fontdialog = new System.Windows.Forms.FontDialog();
            this.folderdialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabcontrolen = new System.Windows.Forms.TabControl();
            this.tpgmusik = new System.Windows.Forms.TabPage();
            this.tbgfilm = new System.Windows.Forms.TabPage();
            this.tbpljudbok = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbppodradio = new System.Windows.Forms.TabPage();
            this.tbpappar = new System.Windows.Forms.TabPage();
            this.btnadd = new System.Windows.Forms.Button();
            this.tbxtext = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colfornamn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDataGrid = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFotboll = new System.Windows.Forms.Button();
            this.btnmal = new System.Windows.Forms.Button();
            this.btnUpp = new System.Windows.Forms.Button();
            this.btnNer = new System.Windows.Forms.Button();
            this.tbxvara = new System.Windows.Forms.TextBox();
            this.tbxpris = new System.Windows.Forms.TextBox();
            this.btnkund = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.musMenu.SuspendLayout();
            this.tabcontrolen.SuspendLayout();
            this.tbpljudbok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // musMenu
            // 
            this.musMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljFärgToolStripMenuItem});
            this.musMenu.Location = new System.Drawing.Point(0, 0);
            this.musMenu.Name = "musMenu";
            this.musMenu.Size = new System.Drawing.Size(822, 24);
            this.musMenu.TabIndex = 0;
            this.musMenu.Text = "Menu";
            // 
            // väljFärgToolStripMenuItem
            // 
            this.väljFärgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljFärgToolStripMenuItem1,
            this.väljMappToolStripMenuItem,
            this.väljTeckensnittToolStripMenuItem});
            this.väljFärgToolStripMenuItem.Name = "väljFärgToolStripMenuItem";
            this.väljFärgToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.väljFärgToolStripMenuItem.Text = "Redigera";
            // 
            // väljFärgToolStripMenuItem1
            // 
            this.väljFärgToolStripMenuItem1.Name = "väljFärgToolStripMenuItem1";
            this.väljFärgToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.väljFärgToolStripMenuItem1.Text = "Välj färg";
            this.väljFärgToolStripMenuItem1.ToolTipText = "Öppnar en dialogruta där du kan välja en bakrundsfärg";
            this.väljFärgToolStripMenuItem1.Click += new System.EventHandler(this.VäljFärgToolStripMenuItem1_Click);
            // 
            // väljMappToolStripMenuItem
            // 
            this.väljMappToolStripMenuItem.Name = "väljMappToolStripMenuItem";
            this.väljMappToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.väljMappToolStripMenuItem.Text = "Välj mapp";
            this.väljMappToolStripMenuItem.ToolTipText = "Öppnar en dialogruta där du kan välja en sökväg";
            this.väljMappToolStripMenuItem.Click += new System.EventHandler(this.VäljMappToolStripMenuItem_Click);
            // 
            // väljTeckensnittToolStripMenuItem
            // 
            this.väljTeckensnittToolStripMenuItem.Name = "väljTeckensnittToolStripMenuItem";
            this.väljTeckensnittToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.väljTeckensnittToolStripMenuItem.Text = "Välj teckensnitt";
            this.väljTeckensnittToolStripMenuItem.ToolTipText = "Öppnar en dialogaruta där du kan välja teckensnitt";
            this.väljTeckensnittToolStripMenuItem.Click += new System.EventHandler(this.VäljTeckensnittToolStripMenuItem_Click);
            // 
            // tabcontrolen
            // 
            this.tabcontrolen.Controls.Add(this.tpgmusik);
            this.tabcontrolen.Controls.Add(this.tbgfilm);
            this.tabcontrolen.Controls.Add(this.tbpljudbok);
            this.tabcontrolen.Controls.Add(this.tbppodradio);
            this.tabcontrolen.Controls.Add(this.tbpappar);
            this.tabcontrolen.Location = new System.Drawing.Point(12, 27);
            this.tabcontrolen.Name = "tabcontrolen";
            this.tabcontrolen.SelectedIndex = 0;
            this.tabcontrolen.Size = new System.Drawing.Size(166, 76);
            this.tabcontrolen.TabIndex = 1;
            // 
            // tpgmusik
            // 
            this.tpgmusik.Location = new System.Drawing.Point(4, 22);
            this.tpgmusik.Name = "tpgmusik";
            this.tpgmusik.Padding = new System.Windows.Forms.Padding(3);
            this.tpgmusik.Size = new System.Drawing.Size(158, 50);
            this.tpgmusik.TabIndex = 0;
            this.tpgmusik.Text = "Musik";
            this.tpgmusik.UseVisualStyleBackColor = true;
            // 
            // tbgfilm
            // 
            this.tbgfilm.Location = new System.Drawing.Point(4, 22);
            this.tbgfilm.Name = "tbgfilm";
            this.tbgfilm.Padding = new System.Windows.Forms.Padding(3);
            this.tbgfilm.Size = new System.Drawing.Size(158, 50);
            this.tbgfilm.TabIndex = 1;
            this.tbgfilm.Text = "Film";
            this.tbgfilm.UseVisualStyleBackColor = true;
            // 
            // tbpljudbok
            // 
            this.tbpljudbok.Controls.Add(this.textBox1);
            this.tbpljudbok.Location = new System.Drawing.Point(4, 22);
            this.tbpljudbok.Name = "tbpljudbok";
            this.tbpljudbok.Padding = new System.Windows.Forms.Padding(3);
            this.tbpljudbok.Size = new System.Drawing.Size(158, 50);
            this.tbpljudbok.TabIndex = 2;
            this.tbpljudbok.Text = "Ljudböcker";
            this.tbpljudbok.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tbppodradio
            // 
            this.tbppodradio.Location = new System.Drawing.Point(4, 22);
            this.tbppodradio.Name = "tbppodradio";
            this.tbppodradio.Padding = new System.Windows.Forms.Padding(3);
            this.tbppodradio.Size = new System.Drawing.Size(158, 50);
            this.tbppodradio.TabIndex = 3;
            this.tbppodradio.Text = "Podradio";
            this.tbppodradio.UseVisualStyleBackColor = true;
            // 
            // tbpappar
            // 
            this.tbpappar.Location = new System.Drawing.Point(4, 22);
            this.tbpappar.Name = "tbpappar";
            this.tbpappar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpappar.Size = new System.Drawing.Size(158, 50);
            this.tbpappar.TabIndex = 4;
            this.tbpappar.Text = "Appar";
            this.tbpappar.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 105);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // tbxtext
            // 
            this.tbxtext.Location = new System.Drawing.Point(93, 107);
            this.tbxtext.Name = "tbxtext";
            this.tbxtext.Size = new System.Drawing.Size(81, 20);
            this.tbxtext.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colfornamn,
            this.col2,
            this.col3});
            this.dataGridView1.Location = new System.Drawing.Point(184, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(281, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // colfornamn
            // 
            this.colfornamn.FillWeight = 88.92634F;
            this.colfornamn.HeaderText = "Förnamn";
            this.colfornamn.Name = "colfornamn";
            this.colfornamn.Width = 80;
            // 
            // col2
            // 
            this.col2.FillWeight = 98.98477F;
            this.col2.HeaderText = "Efternamn";
            this.col2.Name = "col2";
            this.col2.Width = 80;
            // 
            // col3
            // 
            this.col3.FillWeight = 112.0889F;
            this.col3.HeaderText = "Telefonnummer";
            this.col3.Name = "col3";
            this.col3.Width = 80;
            // 
            // btnDataGrid
            // 
            this.btnDataGrid.Location = new System.Drawing.Point(471, 90);
            this.btnDataGrid.Name = "btnDataGrid";
            this.btnDataGrid.Size = new System.Drawing.Size(88, 23);
            this.btnDataGrid.TabIndex = 5;
            this.btnDataGrid.Text = "DataGridView";
            this.btnDataGrid.UseVisualStyleBackColor = true;
            this.btnDataGrid.Click += new System.EventHandler(this.BtnDataGrid_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(471, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(471, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(471, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(12, 168);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(453, 142);
            this.dataGridView2.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Hemmalag";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Bortalag";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mål (H)";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mål (B)";
            this.Column4.Name = "Column4";
            // 
            // btnFotboll
            // 
            this.btnFotboll.Location = new System.Drawing.Point(471, 226);
            this.btnFotboll.Name = "btnFotboll";
            this.btnFotboll.Size = new System.Drawing.Size(75, 23);
            this.btnFotboll.TabIndex = 10;
            this.btnFotboll.Text = "H O C K E Y HOCKEY!";
            this.btnFotboll.UseVisualStyleBackColor = true;
            this.btnFotboll.Click += new System.EventHandler(this.BtnFotboll_Click);
            // 
            // btnmal
            // 
            this.btnmal.Location = new System.Drawing.Point(471, 255);
            this.btnmal.Name = "btnmal";
            this.btnmal.Size = new System.Drawing.Size(75, 23);
            this.btnmal.TabIndex = 11;
            this.btnmal.Text = "GOAL!";
            this.btnmal.UseVisualStyleBackColor = true;
            this.btnmal.Click += new System.EventHandler(this.Btnmal_Click);
            // 
            // btnUpp
            // 
            this.btnUpp.Location = new System.Drawing.Point(471, 168);
            this.btnUpp.Name = "btnUpp";
            this.btnUpp.Size = new System.Drawing.Size(75, 23);
            this.btnUpp.TabIndex = 12;
            this.btnUpp.Text = "Upp";
            this.btnUpp.UseVisualStyleBackColor = true;
            this.btnUpp.Click += new System.EventHandler(this.BtnUpp_Click);
            // 
            // btnNer
            // 
            this.btnNer.Location = new System.Drawing.Point(471, 197);
            this.btnNer.Name = "btnNer";
            this.btnNer.Size = new System.Drawing.Size(75, 23);
            this.btnNer.TabIndex = 13;
            this.btnNer.Text = "Ner";
            this.btnNer.UseVisualStyleBackColor = true;
            this.btnNer.Click += new System.EventHandler(this.BtnNer_Click);
            // 
            // tbxvara
            // 
            this.tbxvara.Location = new System.Drawing.Point(16, 335);
            this.tbxvara.Name = "tbxvara";
            this.tbxvara.Size = new System.Drawing.Size(100, 20);
            this.tbxvara.TabIndex = 14;
            // 
            // tbxpris
            // 
            this.tbxpris.Location = new System.Drawing.Point(122, 335);
            this.tbxpris.Name = "tbxpris";
            this.tbxpris.Size = new System.Drawing.Size(100, 20);
            this.tbxpris.TabIndex = 15;
            // 
            // btnkund
            // 
            this.btnkund.Location = new System.Drawing.Point(240, 335);
            this.btnkund.Name = "btnkund";
            this.btnkund.Size = new System.Drawing.Size(20, 23);
            this.btnkund.TabIndex = 16;
            this.btnkund.Text = "+";
            this.btnkund.UseVisualStyleBackColor = true;
            this.btnkund.Click += new System.EventHandler(this.Btnkund_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(324, 335);
            this.textBox5.MaxLength = 140;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 581);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnkund);
            this.Controls.Add(this.tbxpris);
            this.Controls.Add(this.tbxvara);
            this.Controls.Add(this.btnNer);
            this.Controls.Add(this.btnUpp);
            this.Controls.Add(this.btnmal);
            this.Controls.Add(this.btnFotboll);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnDataGrid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbxtext);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.tabcontrolen);
            this.Controls.Add(this.musMenu);
            this.MainMenuStrip = this.musMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.musMenu.ResumeLayout(false);
            this.musMenu.PerformLayout();
            this.tabcontrolen.ResumeLayout(false);
            this.tbpljudbok.ResumeLayout(false);
            this.tbpljudbok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip musMenu;
        private System.Windows.Forms.ToolStripMenuItem väljFärgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljFärgToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem väljMappToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem väljTeckensnittToolStripMenuItem;
        private System.Windows.Forms.ColorDialog dlgcolor;
        private System.Windows.Forms.FontDialog fontdialog;
        private System.Windows.Forms.FolderBrowserDialog folderdialog;
        private System.Windows.Forms.TabControl tabcontrolen;
        private System.Windows.Forms.TabPage tpgmusik;
        private System.Windows.Forms.TabPage tbgfilm;
        private System.Windows.Forms.TabPage tbpljudbok;
        private System.Windows.Forms.TabPage tbppodradio;
        private System.Windows.Forms.TabPage tbpappar;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox tbxtext;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfornamn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.Button btnDataGrid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnFotboll;
        private System.Windows.Forms.Button btnmal;
        private System.Windows.Forms.Button btnUpp;
        private System.Windows.Forms.Button btnNer;
        private System.Windows.Forms.TextBox tbxvara;
        private System.Windows.Forms.TextBox tbxpris;
        private System.Windows.Forms.Button btnkund;
        private System.Windows.Forms.TextBox textBox5;
    }
}

