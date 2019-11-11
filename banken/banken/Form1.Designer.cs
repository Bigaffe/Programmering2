namespace banken
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
            this.tbxbelopp = new System.Windows.Forms.TextBox();
            this.tbxpersonnr = new System.Windows.Forms.TextBox();
            this.tbxrantesats = new System.Windows.Forms.TextBox();
            this.tbxkredit = new System.Windows.Forms.TextBox();
            this.lbxlista = new System.Windows.Forms.ListBox();
            this.btnInsats = new System.Windows.Forms.Button();
            this.btnUttag = new System.Windows.Forms.Button();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.btnUppdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxbelopp
            // 
            this.tbxbelopp.Location = new System.Drawing.Point(61, 47);
            this.tbxbelopp.Name = "tbxbelopp";
            this.tbxbelopp.Size = new System.Drawing.Size(100, 20);
            this.tbxbelopp.TabIndex = 0;
            // 
            // tbxpersonnr
            // 
            this.tbxpersonnr.Location = new System.Drawing.Point(260, 47);
            this.tbxpersonnr.Name = "tbxpersonnr";
            this.tbxpersonnr.Size = new System.Drawing.Size(100, 20);
            this.tbxpersonnr.TabIndex = 1;
            // 
            // tbxrantesats
            // 
            this.tbxrantesats.Location = new System.Drawing.Point(260, 73);
            this.tbxrantesats.Name = "tbxrantesats";
            this.tbxrantesats.Size = new System.Drawing.Size(100, 20);
            this.tbxrantesats.TabIndex = 2;
            // 
            // tbxkredit
            // 
            this.tbxkredit.Location = new System.Drawing.Point(260, 102);
            this.tbxkredit.Name = "tbxkredit";
            this.tbxkredit.Size = new System.Drawing.Size(100, 20);
            this.tbxkredit.TabIndex = 3;
            // 
            // lbxlista
            // 
            this.lbxlista.FormattingEnabled = true;
            this.lbxlista.Location = new System.Drawing.Point(388, 47);
            this.lbxlista.Name = "lbxlista";
            this.lbxlista.Size = new System.Drawing.Size(170, 134);
            this.lbxlista.TabIndex = 4;
            // 
            // btnInsats
            // 
            this.btnInsats.Location = new System.Drawing.Point(86, 73);
            this.btnInsats.Name = "btnInsats";
            this.btnInsats.Size = new System.Drawing.Size(75, 23);
            this.btnInsats.TabIndex = 5;
            this.btnInsats.Text = "Insättning";
            this.btnInsats.UseVisualStyleBackColor = true;
            this.btnInsats.Click += new System.EventHandler(this.BtnInsats_Click);
            // 
            // btnUttag
            // 
            this.btnUttag.Location = new System.Drawing.Point(86, 102);
            this.btnUttag.Name = "btnUttag";
            this.btnUttag.Size = new System.Drawing.Size(75, 23);
            this.btnUttag.TabIndex = 6;
            this.btnUttag.Text = "Uttag";
            this.btnUttag.UseVisualStyleBackColor = true;
            this.btnUttag.Click += new System.EventHandler(this.BtnUttag_Click);
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(285, 128);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrera.TabIndex = 7;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.BtnRegistrera_Click);
            // 
            // btnUppdate
            // 
            this.btnUppdate.Location = new System.Drawing.Point(388, 200);
            this.btnUppdate.Name = "btnUppdate";
            this.btnUppdate.Size = new System.Drawing.Size(170, 23);
            this.btnUppdate.TabIndex = 8;
            this.btnUppdate.Text = "Uppdatera med årsränta";
            this.btnUppdate.UseVisualStyleBackColor = true;
            this.btnUppdate.Click += new System.EventHandler(this.BtnUppdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Belopp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "PersonNr";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Räntesats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kredit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUppdate);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.btnUttag);
            this.Controls.Add(this.btnInsats);
            this.Controls.Add(this.lbxlista);
            this.Controls.Add(this.tbxkredit);
            this.Controls.Add(this.tbxrantesats);
            this.Controls.Add(this.tbxpersonnr);
            this.Controls.Add(this.tbxbelopp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxbelopp;
        private System.Windows.Forms.TextBox tbxpersonnr;
        private System.Windows.Forms.TextBox tbxrantesats;
        private System.Windows.Forms.TextBox tbxkredit;
        private System.Windows.Forms.ListBox lbxlista;
        private System.Windows.Forms.Button btnInsats;
        private System.Windows.Forms.Button btnUttag;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.Button btnUppdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

