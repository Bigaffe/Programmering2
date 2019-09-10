namespace onving1_14
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
            this.tbxtext = new System.Windows.Forms.TextBox();
            this.lbltecken = new System.Windows.Forms.Label();
            this.cbxFet = new System.Windows.Forms.CheckBox();
            this.cbxkursiv = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbxtecken = new System.Windows.Forms.ComboBox();
            this.mupstorlek = new System.Windows.Forms.NumericUpDown();
            this.cbxcolor = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mupstorlek)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxtext
            // 
            this.tbxtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxtext.Location = new System.Drawing.Point(12, 22);
            this.tbxtext.Multiline = true;
            this.tbxtext.Name = "tbxtext";
            this.tbxtext.Size = new System.Drawing.Size(242, 134);
            this.tbxtext.TabIndex = 0;
            // 
            // lbltecken
            // 
            this.lbltecken.AutoSize = true;
            this.lbltecken.Location = new System.Drawing.Point(13, 163);
            this.lbltecken.Name = "lbltecken";
            this.lbltecken.Size = new System.Drawing.Size(63, 13);
            this.lbltecken.TabIndex = 1;
            this.lbltecken.Text = "Teckensnitt";
            // 
            // cbxFet
            // 
            this.cbxFet.AutoSize = true;
            this.cbxFet.Location = new System.Drawing.Point(16, 215);
            this.cbxFet.Name = "cbxFet";
            this.cbxFet.Size = new System.Drawing.Size(41, 17);
            this.cbxFet.TabIndex = 2;
            this.cbxFet.Text = "Fet";
            this.cbxFet.UseVisualStyleBackColor = true;
            // 
            // cbxkursiv
            // 
            this.cbxkursiv.AutoSize = true;
            this.cbxkursiv.Location = new System.Drawing.Point(13, 239);
            this.cbxkursiv.Name = "cbxkursiv";
            this.cbxkursiv.Size = new System.Drawing.Size(55, 17);
            this.cbxkursiv.TabIndex = 3;
            this.cbxkursiv.Text = "Kursiv";
            this.cbxkursiv.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(252, 239);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // cbxtecken
            // 
            this.cbxtecken.FormattingEnabled = true;
            this.cbxtecken.Items.AddRange(new object[] {
            "Arial"});
            this.cbxtecken.Location = new System.Drawing.Point(16, 179);
            this.cbxtecken.Name = "cbxtecken";
            this.cbxtecken.Size = new System.Drawing.Size(79, 21);
            this.cbxtecken.TabIndex = 6;
            // 
            // mupstorlek
            // 
            this.mupstorlek.Location = new System.Drawing.Point(141, 180);
            this.mupstorlek.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mupstorlek.Name = "mupstorlek";
            this.mupstorlek.Size = new System.Drawing.Size(79, 20);
            this.mupstorlek.TabIndex = 7;
            this.mupstorlek.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // cbxcolor
            // 
            this.cbxcolor.AllowDrop = true;
            this.cbxcolor.FormattingEnabled = true;
            this.cbxcolor.Location = new System.Drawing.Point(141, 241);
            this.cbxcolor.Name = "cbxcolor";
            this.cbxcolor.Size = new System.Drawing.Size(79, 21);
            this.cbxcolor.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 9;
            this.button1.Text = "Font";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxcolor);
            this.Controls.Add(this.mupstorlek);
            this.Controls.Add(this.cbxtecken);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbxkursiv);
            this.Controls.Add(this.cbxFet);
            this.Controls.Add(this.lbltecken);
            this.Controls.Add(this.tbxtext);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mupstorlek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxtext;
        private System.Windows.Forms.Label lbltecken;
        private System.Windows.Forms.CheckBox cbxFet;
        private System.Windows.Forms.CheckBox cbxkursiv;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox cbxtecken;
        private System.Windows.Forms.NumericUpDown mupstorlek;
        private System.Windows.Forms.ComboBox cbxcolor;
        private System.Windows.Forms.Button button1;
    }
}

