namespace klasupg3
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
            this.tbxs = new System.Windows.Forms.TextBox();
            this.tbxt = new System.Windows.Forms.TextBox();
            this.btnRegistrera = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbxsearch = new System.Windows.Forms.TextBox();
            this.lbxlista = new System.Windows.Forms.ListBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lbltid = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxs
            // 
            this.tbxs.Location = new System.Drawing.Point(71, 33);
            this.tbxs.Name = "tbxs";
            this.tbxs.Size = new System.Drawing.Size(100, 20);
            this.tbxs.TabIndex = 0;
            // 
            // tbxt
            // 
            this.tbxt.Location = new System.Drawing.Point(71, 59);
            this.tbxt.Name = "tbxt";
            this.tbxt.Size = new System.Drawing.Size(100, 20);
            this.tbxt.TabIndex = 1;
            // 
            // btnRegistrera
            // 
            this.btnRegistrera.Location = new System.Drawing.Point(179, 100);
            this.btnRegistrera.Name = "btnRegistrera";
            this.btnRegistrera.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrera.TabIndex = 2;
            this.btnRegistrera.Text = "Registrera";
            this.btnRegistrera.UseVisualStyleBackColor = true;
            this.btnRegistrera.Click += new System.EventHandler(this.BtnRegistrera_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Visa alla tider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "visa alla hastigheter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // tbxsearch
            // 
            this.tbxsearch.Location = new System.Drawing.Point(71, 181);
            this.tbxsearch.Name = "tbxsearch";
            this.tbxsearch.Size = new System.Drawing.Size(100, 20);
            this.tbxsearch.TabIndex = 5;
            // 
            // lbxlista
            // 
            this.lbxlista.FormattingEnabled = true;
            this.lbxlista.Location = new System.Drawing.Point(71, 268);
            this.lbxlista.Name = "lbxlista";
            this.lbxlista.Size = new System.Drawing.Size(219, 173);
            this.lbxlista.TabIndex = 6;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(179, 39);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(22, 13);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Km";
            // 
            // lbltid
            // 
            this.lbltid.AutoSize = true;
            this.lbltid.Location = new System.Drawing.Point(179, 62);
            this.lbltid.Name = "lbltid";
            this.lbltid.Size = new System.Drawing.Size(22, 13);
            this.lbltid.TabIndex = 8;
            this.lbltid.Text = "Tid";
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(182, 185);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(43, 13);
            this.lblsearch.TabIndex = 9;
            this.lblsearch.Text = "Sök km";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 489);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lbltid);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lbxlista);
            this.Controls.Add(this.tbxsearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRegistrera);
            this.Controls.Add(this.tbxt);
            this.Controls.Add(this.tbxs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxs;
        private System.Windows.Forms.TextBox tbxt;
        private System.Windows.Forms.Button btnRegistrera;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbxsearch;
        private System.Windows.Forms.ListBox lbxlista;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbltid;
        private System.Windows.Forms.Label lblsearch;
    }
}

