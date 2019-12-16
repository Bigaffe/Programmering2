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
            this.tbppodradio = new System.Windows.Forms.TabPage();
            this.tbpappar = new System.Windows.Forms.TabPage();
            this.btnadd = new System.Windows.Forms.Button();
            this.tbxtext = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.musMenu.SuspendLayout();
            this.tabcontrolen.SuspendLayout();
            this.tbpljudbok.SuspendLayout();
            this.SuspendLayout();
            // 
            // musMenu
            // 
            this.musMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.väljFärgToolStripMenuItem});
            this.musMenu.Location = new System.Drawing.Point(0, 0);
            this.musMenu.Name = "musMenu";
            this.musMenu.Size = new System.Drawing.Size(610, 24);
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
            this.väljFärgToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.väljFärgToolStripMenuItem1.Text = "Välj färg";
            this.väljFärgToolStripMenuItem1.ToolTipText = "Öppnar en dialogruta där du kan välja en bakrundsfärg";
            this.väljFärgToolStripMenuItem1.Click += new System.EventHandler(this.VäljFärgToolStripMenuItem1_Click);
            // 
            // väljMappToolStripMenuItem
            // 
            this.väljMappToolStripMenuItem.Name = "väljMappToolStripMenuItem";
            this.väljMappToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.väljMappToolStripMenuItem.Text = "Välj mapp";
            this.väljMappToolStripMenuItem.ToolTipText = "Öppnar en dialogruta där du kan välja en sökväg";
            this.väljMappToolStripMenuItem.Click += new System.EventHandler(this.VäljMappToolStripMenuItem_Click);
            // 
            // väljTeckensnittToolStripMenuItem
            // 
            this.väljTeckensnittToolStripMenuItem.Name = "väljTeckensnittToolStripMenuItem";
            this.väljTeckensnittToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.tabcontrolen.Size = new System.Drawing.Size(248, 176);
            this.tabcontrolen.TabIndex = 1;
            // 
            // tpgmusik
            // 
            this.tpgmusik.Location = new System.Drawing.Point(4, 22);
            this.tpgmusik.Name = "tpgmusik";
            this.tpgmusik.Padding = new System.Windows.Forms.Padding(3);
            this.tpgmusik.Size = new System.Drawing.Size(240, 150);
            this.tpgmusik.TabIndex = 0;
            this.tpgmusik.Text = "Musik";
            this.tpgmusik.UseVisualStyleBackColor = true;
            // 
            // tbgfilm
            // 
            this.tbgfilm.Location = new System.Drawing.Point(4, 22);
            this.tbgfilm.Name = "tbgfilm";
            this.tbgfilm.Padding = new System.Windows.Forms.Padding(3);
            this.tbgfilm.Size = new System.Drawing.Size(240, 150);
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
            this.tbpljudbok.Size = new System.Drawing.Size(240, 150);
            this.tbpljudbok.TabIndex = 2;
            this.tbpljudbok.Text = "Ljudböcker";
            this.tbpljudbok.UseVisualStyleBackColor = true;
            // 
            // tbppodradio
            // 
            this.tbppodradio.Location = new System.Drawing.Point(4, 22);
            this.tbppodradio.Name = "tbppodradio";
            this.tbppodradio.Padding = new System.Windows.Forms.Padding(3);
            this.tbppodradio.Size = new System.Drawing.Size(285, 150);
            this.tbppodradio.TabIndex = 3;
            this.tbppodradio.Text = "Podradio";
            this.tbppodradio.UseVisualStyleBackColor = true;
            // 
            // tbpappar
            // 
            this.tbpappar.Location = new System.Drawing.Point(4, 22);
            this.tbpappar.Name = "tbpappar";
            this.tbpappar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpappar.Size = new System.Drawing.Size(285, 150);
            this.tbpappar.TabIndex = 4;
            this.tbpappar.Text = "Appar";
            this.tbpappar.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(16, 210);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // tbxtext
            // 
            this.tbxtext.Location = new System.Drawing.Point(98, 210);
            this.tbxtext.Name = "tbxtext";
            this.tbxtext.Size = new System.Drawing.Size(100, 20);
            this.tbxtext.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 427);
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
    }
}

