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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnlaggTillRad = new System.Windows.Forms.Button();
            this.btntaBortRad = new System.Windows.Forms.Button();
            this.btnValj = new System.Windows.Forms.Button();
            this.dgwtabell = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlaggTillKolumn = new System.Windows.Forms.Button();
            this.btntaBortKolumn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwtabell)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(504, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(187, 37);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnlaggTillRad
            // 
            this.btnlaggTillRad.Location = new System.Drawing.Point(12, 66);
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
            this.btntaBortRad.Location = new System.Drawing.Point(106, 66);
            this.btntaBortRad.Name = "btntaBortRad";
            this.btntaBortRad.Size = new System.Drawing.Size(75, 23);
            this.btntaBortRad.TabIndex = 3;
            this.btntaBortRad.Text = "Ta bort rad";
            this.btntaBortRad.UseVisualStyleBackColor = true;
            this.btntaBortRad.Click += new System.EventHandler(this.btntaBortRad_Click);
            // 
            // btnValj
            // 
            this.btnValj.Location = new System.Drawing.Point(187, 66);
            this.btnValj.Name = "btnValj";
            this.btnValj.Size = new System.Drawing.Size(75, 23);
            this.btnValj.TabIndex = 4;
            this.btnValj.Text = "Välj";
            this.btnValj.UseVisualStyleBackColor = true;
            this.btnValj.Click += new System.EventHandler(this.btnValj_Click);
            // 
            // dgwtabell
            // 
            this.dgwtabell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwtabell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgwtabell.Location = new System.Drawing.Point(90, 186);
            this.dgwtabell.Name = "dgwtabell";
            this.dgwtabell.Size = new System.Drawing.Size(672, 252);
            this.dgwtabell.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            // 
            // btnlaggTillKolumn
            // 
            this.btnlaggTillKolumn.Location = new System.Drawing.Point(12, 95);
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
            this.btntaBortKolumn.Location = new System.Drawing.Point(106, 95);
            this.btntaBortKolumn.Name = "btntaBortKolumn";
            this.btntaBortKolumn.Size = new System.Drawing.Size(75, 23);
            this.btntaBortKolumn.TabIndex = 7;
            this.btntaBortKolumn.Text = "Ta bort kolumn";
            this.btntaBortKolumn.UseVisualStyleBackColor = true;
            this.btntaBortKolumn.Click += new System.EventHandler(this.btntaBortKolumn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntaBortKolumn);
            this.Controls.Add(this.btnlaggTillKolumn);
            this.Controls.Add(this.dgwtabell);
            this.Controls.Add(this.btnValj);
            this.Controls.Add(this.btntaBortRad);
            this.Controls.Add(this.btnlaggTillRad);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwtabell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnlaggTillRad;
        private System.Windows.Forms.Button btntaBortRad;
        private System.Windows.Forms.Button btnValj;
        private System.Windows.Forms.DataGridView dgwtabell;
        private System.Windows.Forms.Button btnlaggTillKolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btntaBortKolumn;
    }
}

