namespace ovn1._5
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
            this.tbxregnr = new System.Windows.Forms.TextBox();
            this.tbxmarke = new System.Windows.Forms.TextBox();
            this.tbxmodell = new System.Windows.Forms.TextBox();
            this.cbxtyp = new System.Windows.Forms.ComboBox();
            this.lbxlista = new System.Windows.Forms.ListBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.lblreg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblvisa = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbnAlla = new System.Windows.Forms.RadioButton();
            this.rbnBilar = new System.Windows.Forms.RadioButton();
            this.rbnMC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbxregnr
            // 
            this.tbxregnr.Location = new System.Drawing.Point(84, 141);
            this.tbxregnr.Name = "tbxregnr";
            this.tbxregnr.Size = new System.Drawing.Size(100, 20);
            this.tbxregnr.TabIndex = 0;
            // 
            // tbxmarke
            // 
            this.tbxmarke.Location = new System.Drawing.Point(84, 186);
            this.tbxmarke.Name = "tbxmarke";
            this.tbxmarke.Size = new System.Drawing.Size(100, 20);
            this.tbxmarke.TabIndex = 1;
            // 
            // tbxmodell
            // 
            this.tbxmodell.Location = new System.Drawing.Point(84, 229);
            this.tbxmodell.Name = "tbxmodell";
            this.tbxmodell.Size = new System.Drawing.Size(100, 20);
            this.tbxmodell.TabIndex = 2;
            // 
            // cbxtyp
            // 
            this.cbxtyp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtyp.FormattingEnabled = true;
            this.cbxtyp.Items.AddRange(new object[] {
            "Bil",
            "MC"});
            this.cbxtyp.Location = new System.Drawing.Point(84, 275);
            this.cbxtyp.Name = "cbxtyp";
            this.cbxtyp.Size = new System.Drawing.Size(100, 21);
            this.cbxtyp.TabIndex = 3;
            // 
            // lbxlista
            // 
            this.lbxlista.FormattingEnabled = true;
            this.lbxlista.Location = new System.Drawing.Point(227, 37);
            this.lbxlista.Name = "lbxlista";
            this.lbxlista.Size = new System.Drawing.Size(249, 264);
            this.lbxlista.TabIndex = 4;
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(84, 351);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(100, 23);
            this.btnreg.TabIndex = 8;
            this.btnreg.Text = "Registrera";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.Btnreg_Click);
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Location = new System.Drawing.Point(12, 148);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(39, 13);
            this.lblreg.TabIndex = 9;
            this.lblreg.Text = "Reg-nr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Märke";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Modell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Typ";
            // 
            // lblvisa
            // 
            this.lblvisa.AutoSize = true;
            this.lblvisa.Location = new System.Drawing.Point(224, 335);
            this.lblvisa.Name = "lblvisa";
            this.lblvisa.Size = new System.Drawing.Size(27, 13);
            this.lblvisa.TabIndex = 13;
            this.lblvisa.Text = "Visa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Register";
            // 
            // rbnAlla
            // 
            this.rbnAlla.AutoSize = true;
            this.rbnAlla.Location = new System.Drawing.Point(227, 352);
            this.rbnAlla.Name = "rbnAlla";
            this.rbnAlla.Size = new System.Drawing.Size(42, 17);
            this.rbnAlla.TabIndex = 15;
            this.rbnAlla.TabStop = true;
            this.rbnAlla.Text = "Alla";
            this.rbnAlla.UseVisualStyleBackColor = true;
            this.rbnAlla.Click += new System.EventHandler(this.RbnAlla_Click);
            // 
            // rbnBilar
            // 
            this.rbnBilar.AutoSize = true;
            this.rbnBilar.Location = new System.Drawing.Point(275, 351);
            this.rbnBilar.Name = "rbnBilar";
            this.rbnBilar.Size = new System.Drawing.Size(45, 17);
            this.rbnBilar.TabIndex = 16;
            this.rbnBilar.TabStop = true;
            this.rbnBilar.Text = "Bilar";
            this.rbnBilar.UseVisualStyleBackColor = true;
            this.rbnBilar.Click += new System.EventHandler(this.RbnBilar_Click);
            // 
            // rbnMC
            // 
            this.rbnMC.AutoSize = true;
            this.rbnMC.Location = new System.Drawing.Point(326, 351);
            this.rbnMC.Name = "rbnMC";
            this.rbnMC.Size = new System.Drawing.Size(41, 17);
            this.rbnMC.TabIndex = 17;
            this.rbnMC.TabStop = true;
            this.rbnMC.Text = "MC";
            this.rbnMC.UseVisualStyleBackColor = true;
            this.rbnMC.Click += new System.EventHandler(this.RbnMC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 397);
            this.Controls.Add(this.rbnMC);
            this.Controls.Add(this.rbnBilar);
            this.Controls.Add(this.rbnAlla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblvisa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblreg);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.lbxlista);
            this.Controls.Add(this.cbxtyp);
            this.Controls.Add(this.tbxmodell);
            this.Controls.Add(this.tbxmarke);
            this.Controls.Add(this.tbxregnr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxregnr;
        private System.Windows.Forms.TextBox tbxmarke;
        private System.Windows.Forms.TextBox tbxmodell;
        private System.Windows.Forms.ComboBox cbxtyp;
        private System.Windows.Forms.ListBox lbxlista;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblvisa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbnAlla;
        private System.Windows.Forms.RadioButton rbnBilar;
        private System.Windows.Forms.RadioButton rbnMC;
    }
}

