namespace klassupg2
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
            this.tbxnamn = new System.Windows.Forms.TextBox();
            this.tbxpoints = new System.Windows.Forms.TextBox();
            this.btnreg = new System.Windows.Forms.Button();
            this.tbxcheck = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbxlista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbxnamn
            // 
            this.tbxnamn.Location = new System.Drawing.Point(23, 24);
            this.tbxnamn.Name = "tbxnamn";
            this.tbxnamn.Size = new System.Drawing.Size(100, 20);
            this.tbxnamn.TabIndex = 0;
            // 
            // tbxpoints
            // 
            this.tbxpoints.Location = new System.Drawing.Point(23, 62);
            this.tbxpoints.Name = "tbxpoints";
            this.tbxpoints.Size = new System.Drawing.Size(100, 20);
            this.tbxpoints.TabIndex = 1;
            // 
            // btnreg
            // 
            this.btnreg.Location = new System.Drawing.Point(149, 58);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(75, 23);
            this.btnreg.TabIndex = 2;
            this.btnreg.Text = "Registrera";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.Btnreg_Click);
            // 
            // tbxcheck
            // 
            this.tbxcheck.Location = new System.Drawing.Point(23, 127);
            this.tbxcheck.Name = "tbxcheck";
            this.tbxcheck.Size = new System.Drawing.Size(100, 20);
            this.tbxcheck.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(149, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // lbxlista
            // 
            this.lbxlista.FormattingEnabled = true;
            this.lbxlista.Location = new System.Drawing.Point(23, 188);
            this.lbxlista.Name = "lbxlista";
            this.lbxlista.Size = new System.Drawing.Size(201, 212);
            this.lbxlista.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxlista);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxcheck);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.tbxpoints);
            this.Controls.Add(this.tbxnamn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxnamn;
        private System.Windows.Forms.TextBox tbxpoints;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.TextBox tbxcheck;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbxlista;
    }
}

