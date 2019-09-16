namespace klassupg1
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
            this.tbxKund = new System.Windows.Forms.TextBox();
            this.tbxdestination = new System.Windows.Forms.TextBox();
            this.tbxdagar = new System.Windows.Forms.TextBox();
            this.lblkund = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblDagar = new System.Windows.Forms.Label();
            this.btnboka = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblsearchname = new System.Windows.Forms.Label();
            this.tbxsearch = new System.Windows.Forms.TextBox();
            this.lbxlista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxKund
            // 
            this.tbxKund.Location = new System.Drawing.Point(74, 51);
            this.tbxKund.Name = "tbxKund";
            this.tbxKund.Size = new System.Drawing.Size(100, 20);
            this.tbxKund.TabIndex = 0;
            // 
            // tbxdestination
            // 
            this.tbxdestination.Location = new System.Drawing.Point(74, 93);
            this.tbxdestination.Name = "tbxdestination";
            this.tbxdestination.Size = new System.Drawing.Size(100, 20);
            this.tbxdestination.TabIndex = 1;
            // 
            // tbxdagar
            // 
            this.tbxdagar.Location = new System.Drawing.Point(74, 137);
            this.tbxdagar.Name = "tbxdagar";
            this.tbxdagar.Size = new System.Drawing.Size(100, 20);
            this.tbxdagar.TabIndex = 2;
            // 
            // lblkund
            // 
            this.lblkund.AutoSize = true;
            this.lblkund.Location = new System.Drawing.Point(13, 57);
            this.lblkund.Name = "lblkund";
            this.lblkund.Size = new System.Drawing.Size(32, 13);
            this.lblkund.TabIndex = 3;
            this.lblkund.Text = "Kund";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(8, 96);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination";
            // 
            // lblDagar
            // 
            this.lblDagar.AutoSize = true;
            this.lblDagar.Location = new System.Drawing.Point(11, 143);
            this.lblDagar.Name = "lblDagar";
            this.lblDagar.Size = new System.Drawing.Size(36, 13);
            this.lblDagar.TabIndex = 5;
            this.lblDagar.Text = "Dagar";
            // 
            // btnboka
            // 
            this.btnboka.Location = new System.Drawing.Point(180, 135);
            this.btnboka.Name = "btnboka";
            this.btnboka.Size = new System.Drawing.Size(75, 23);
            this.btnboka.TabIndex = 6;
            this.btnboka.Text = "Boka";
            this.btnboka.UseVisualStyleBackColor = true;
            this.btnboka.Click += new System.EventHandler(this.Btnboka_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(180, 228);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 7;
            this.btnsearch.Text = "Sök";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(16, 211);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(53, 13);
            this.lblsearch.TabIndex = 8;
            this.lblsearch.Text = "Sök kund";
            // 
            // lblsearchname
            // 
            this.lblsearchname.AutoSize = true;
            this.lblsearchname.Location = new System.Drawing.Point(25, 233);
            this.lblsearchname.Name = "lblsearchname";
            this.lblsearchname.Size = new System.Drawing.Size(33, 13);
            this.lblsearchname.TabIndex = 9;
            this.lblsearchname.Text = "namn";
            // 
            // tbxsearch
            // 
            this.tbxsearch.Location = new System.Drawing.Point(74, 233);
            this.tbxsearch.Name = "tbxsearch";
            this.tbxsearch.Size = new System.Drawing.Size(100, 20);
            this.tbxsearch.TabIndex = 10;
            // 
            // lbxlista
            // 
            this.lbxlista.FormattingEnabled = true;
            this.lbxlista.Location = new System.Drawing.Point(54, 269);
            this.lbxlista.Name = "lbxlista";
            this.lbxlista.Size = new System.Drawing.Size(120, 95);
            this.lbxlista.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxlista);
            this.Controls.Add(this.tbxsearch);
            this.Controls.Add(this.lblsearchname);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnboka);
            this.Controls.Add(this.lblDagar);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblkund);
            this.Controls.Add(this.tbxdagar);
            this.Controls.Add(this.tbxdestination);
            this.Controls.Add(this.tbxKund);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxKund;
        private System.Windows.Forms.TextBox tbxdestination;
        private System.Windows.Forms.TextBox tbxdagar;
        private System.Windows.Forms.Label lblkund;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblDagar;
        private System.Windows.Forms.Button btnboka;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblsearchname;
        private System.Windows.Forms.TextBox tbxsearch;
        private System.Windows.Forms.ListBox lbxlista;
    }
}

