namespace klientbild
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
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.btnAnslut = new System.Windows.Forms.Button();
            this.btnUpp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnNer = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(13, 13);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(100, 20);
            this.tbxPort.TabIndex = 0;
            // 
            // btnAnslut
            // 
            this.btnAnslut.Location = new System.Drawing.Point(119, 10);
            this.btnAnslut.Name = "btnAnslut";
            this.btnAnslut.Size = new System.Drawing.Size(75, 23);
            this.btnAnslut.TabIndex = 1;
            this.btnAnslut.Text = "Anslut";
            this.btnAnslut.UseVisualStyleBackColor = true;
            this.btnAnslut.Click += new System.EventHandler(this.BtnAnslut_Click);
            // 
            // btnUpp
            // 
            this.btnUpp.Enabled = false;
            this.btnUpp.Location = new System.Drawing.Point(125, 76);
            this.btnUpp.Name = "btnUpp";
            this.btnUpp.Size = new System.Drawing.Size(127, 60);
            this.btnUpp.TabIndex = 2;
            this.btnUpp.Text = "Upp";
            this.btnUpp.UseVisualStyleBackColor = true;
            this.btnUpp.Click += new System.EventHandler(this.BtnUpp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(1, 142);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(127, 60);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Vänster";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // btnNer
            // 
            this.btnNer.Enabled = false;
            this.btnNer.Location = new System.Drawing.Point(125, 208);
            this.btnNer.Name = "btnNer";
            this.btnNer.Size = new System.Drawing.Size(127, 60);
            this.btnNer.TabIndex = 4;
            this.btnNer.Text = "Ner";
            this.btnNer.UseVisualStyleBackColor = true;
            this.btnNer.Click += new System.EventHandler(this.BtnNer_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(250, 142);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(127, 60);
            this.btnRight.TabIndex = 5;
            this.btnRight.Text = "Höger";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnNer);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUpp);
            this.Controls.Add(this.btnAnslut);
            this.Controls.Add(this.tbxPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Button btnAnslut;
        private System.Windows.Forms.Button btnUpp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnNer;
        private System.Windows.Forms.Button btnRight;
    }
}

