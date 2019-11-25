namespace inkopslista
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
            this.tbxVara = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.tbxMangd = new System.Windows.Forms.TextBox();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxSumma = new System.Windows.Forms.TextBox();
            this.rbnlosvikt = new System.Windows.Forms.RadioButton();
            this.rbnStycksak = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxVara
            // 
            this.tbxVara.Location = new System.Drawing.Point(105, 38);
            this.tbxVara.Name = "tbxVara";
            this.tbxVara.Size = new System.Drawing.Size(100, 20);
            this.tbxVara.TabIndex = 0;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(105, 82);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 20);
            this.tbxPris.TabIndex = 1;
            // 
            // tbxMangd
            // 
            this.tbxMangd.Location = new System.Drawing.Point(105, 123);
            this.tbxMangd.Name = "tbxMangd";
            this.tbxMangd.Size = new System.Drawing.Size(100, 20);
            this.tbxMangd.TabIndex = 2;
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.Location = new System.Drawing.Point(238, 38);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(173, 329);
            this.lbxLista.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 380);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbxSumma
            // 
            this.tbxSumma.Location = new System.Drawing.Point(311, 382);
            this.tbxSumma.Name = "tbxSumma";
            this.tbxSumma.Size = new System.Drawing.Size(100, 20);
            this.tbxSumma.TabIndex = 5;
            // 
            // rbnlosvikt
            // 
            this.rbnlosvikt.AutoSize = true;
            this.rbnlosvikt.Location = new System.Drawing.Point(105, 166);
            this.rbnlosvikt.Name = "rbnlosvikt";
            this.rbnlosvikt.Size = new System.Drawing.Size(59, 17);
            this.rbnlosvikt.TabIndex = 6;
            this.rbnlosvikt.Text = "Lösvikt";
            this.rbnlosvikt.UseVisualStyleBackColor = true;
            // 
            // rbnStycksak
            // 
            this.rbnStycksak.AutoSize = true;
            this.rbnStycksak.Location = new System.Drawing.Point(105, 189);
            this.rbnStycksak.Name = "rbnStycksak";
            this.rbnStycksak.Size = new System.Drawing.Size(69, 17);
            this.rbnStycksak.TabIndex = 7;
            this.rbnStycksak.Text = "Stycksak";
            this.rbnStycksak.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Summa (kr):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mängd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbnStycksak);
            this.Controls.Add(this.rbnlosvikt);
            this.Controls.Add(this.tbxSumma);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.tbxMangd);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.tbxVara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxVara;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.TextBox tbxMangd;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxSumma;
        private System.Windows.Forms.RadioButton rbnlosvikt;
        private System.Windows.Forms.RadioButton rbnStycksak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

