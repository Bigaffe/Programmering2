namespace slutprogrammering
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnlaggTillRad = new System.Windows.Forms.Button();
            this.btntaBortRad = new System.Windows.Forms.Button();
            this.dgwtabell = new System.Windows.Forms.DataGridView();
            this.btnlaggTillKolumn = new System.Windows.Forms.Button();
            this.btntaBortKolumn = new System.Windows.Forms.Button();
            this.btnSpara = new System.Windows.Forms.Button();
            this.btnLaddaupp = new System.Windows.Forms.Button();
            this.lblnuvarandeSpelare = new System.Windows.Forms.Label();
            this.lblspelare1Poäng = new System.Windows.Forms.Label();
            this.lblspelare2Poäng = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwtabell)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlaggTillRad
            // 
            this.btnlaggTillRad.Location = new System.Drawing.Point(12, 12);
            this.btnlaggTillRad.Name = "btnlaggTillRad";
            this.btnlaggTillRad.Size = new System.Drawing.Size(88, 23);
            this.btnlaggTillRad.TabIndex = 2;
            this.btnlaggTillRad.Text = "Lägg till rad";
            this.btnlaggTillRad.UseVisualStyleBackColor = true;
            this.btnlaggTillRad.Click += new System.EventHandler(this.btnlaggTillRad_Click);
            // 
            // btntaBortRad
            // 
            this.btntaBortRad.Enabled = false;
            this.btntaBortRad.Location = new System.Drawing.Point(106, 12);
            this.btntaBortRad.Name = "btntaBortRad";
            this.btntaBortRad.Size = new System.Drawing.Size(87, 23);
            this.btntaBortRad.TabIndex = 3;
            this.btntaBortRad.Text = "Ta bort rad";
            this.btntaBortRad.UseVisualStyleBackColor = true;
            this.btntaBortRad.Click += new System.EventHandler(this.btntaBortRad_Click);
            // 
            // dgwtabell
            // 
            this.dgwtabell.AllowUserToDeleteRows = false;
            this.dgwtabell.AllowUserToResizeColumns = false;
            this.dgwtabell.AllowUserToResizeRows = false;
            this.dgwtabell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwtabell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwtabell.ColumnHeadersVisible = false;
            this.dgwtabell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgwtabell.Location = new System.Drawing.Point(12, 70);
            this.dgwtabell.MultiSelect = false;
            this.dgwtabell.Name = "dgwtabell";
            this.dgwtabell.RowHeadersVisible = false;
            this.dgwtabell.Size = new System.Drawing.Size(776, 368);
            this.dgwtabell.TabIndex = 5;
            this.dgwtabell.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwtabell_CellClick);
            this.dgwtabell.DoubleClick += new System.EventHandler(this.dgwtabell_DoubleClick);
            // 
            // btnlaggTillKolumn
            // 
            this.btnlaggTillKolumn.Location = new System.Drawing.Point(12, 41);
            this.btnlaggTillKolumn.Name = "btnlaggTillKolumn";
            this.btnlaggTillKolumn.Size = new System.Drawing.Size(88, 23);
            this.btnlaggTillKolumn.TabIndex = 6;
            this.btnlaggTillKolumn.Text = "Lägg till kolumn";
            this.btnlaggTillKolumn.UseVisualStyleBackColor = true;
            this.btnlaggTillKolumn.Click += new System.EventHandler(this.btnlaggTillKolumn_Click);
            // 
            // btntaBortKolumn
            // 
            this.btntaBortKolumn.Enabled = false;
            this.btntaBortKolumn.Location = new System.Drawing.Point(106, 41);
            this.btntaBortKolumn.Name = "btntaBortKolumn";
            this.btntaBortKolumn.Size = new System.Drawing.Size(87, 23);
            this.btntaBortKolumn.TabIndex = 7;
            this.btntaBortKolumn.Text = "Ta bort kolumn";
            this.btntaBortKolumn.UseVisualStyleBackColor = true;
            this.btntaBortKolumn.Click += new System.EventHandler(this.btntaBortKolumn_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(713, 13);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(75, 23);
            this.btnSpara.TabIndex = 8;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // btnLaddaupp
            // 
            this.btnLaddaupp.Location = new System.Drawing.Point(713, 41);
            this.btnLaddaupp.Name = "btnLaddaupp";
            this.btnLaddaupp.Size = new System.Drawing.Size(75, 23);
            this.btnLaddaupp.TabIndex = 9;
            this.btnLaddaupp.Text = "Ladda";
            this.btnLaddaupp.UseVisualStyleBackColor = true;
            this.btnLaddaupp.Click += new System.EventHandler(this.btnLaddaupp_Click);
            // 
            // lblnuvarandeSpelare
            // 
            this.lblnuvarandeSpelare.AutoSize = true;
            this.lblnuvarandeSpelare.Location = new System.Drawing.Point(280, 12);
            this.lblnuvarandeSpelare.Name = "lblnuvarandeSpelare";
            this.lblnuvarandeSpelare.Size = new System.Drawing.Size(43, 13);
            this.lblnuvarandeSpelare.TabIndex = 10;
            this.lblnuvarandeSpelare.Text = "Spelare";
            // 
            // lblspelare1Poäng
            // 
            this.lblspelare1Poäng.AutoSize = true;
            this.lblspelare1Poäng.Location = new System.Drawing.Point(401, 13);
            this.lblspelare1Poäng.Name = "lblspelare1Poäng";
            this.lblspelare1Poäng.Size = new System.Drawing.Size(64, 13);
            this.lblspelare1Poäng.TabIndex = 11;
            this.lblspelare1Poäng.Text = "Spelare 1: 0";
            // 
            // lblspelare2Poäng
            // 
            this.lblspelare2Poäng.AutoSize = true;
            this.lblspelare2Poäng.Location = new System.Drawing.Point(474, 13);
            this.lblspelare2Poäng.Name = "lblspelare2Poäng";
            this.lblspelare2Poäng.Size = new System.Drawing.Size(64, 13);
            this.lblspelare2Poäng.TabIndex = 12;
            this.lblspelare2Poäng.Text = "Spelare 2: 0";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblspelare2Poäng);
            this.Controls.Add(this.lblspelare1Poäng);
            this.Controls.Add(this.lblnuvarandeSpelare);
            this.Controls.Add(this.btnLaddaupp);
            this.Controls.Add(this.btnSpara);
            this.Controls.Add(this.btntaBortKolumn);
            this.Controls.Add(this.btnlaggTillKolumn);
            this.Controls.Add(this.dgwtabell);
            this.Controls.Add(this.btntaBortRad);
            this.Controls.Add(this.btnlaggTillRad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwtabell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnlaggTillRad;
        private System.Windows.Forms.Button btntaBortRad;
        private System.Windows.Forms.DataGridView dgwtabell;
        private System.Windows.Forms.Button btnlaggTillKolumn;
        private System.Windows.Forms.Button btntaBortKolumn;
        private System.Windows.Forms.Button btnSpara;
        private System.Windows.Forms.Button btnLaddaupp;
        private System.Windows.Forms.Label lblnuvarandeSpelare;
        private System.Windows.Forms.Label lblspelare1Poäng;
        private System.Windows.Forms.Label lblspelare2Poäng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

