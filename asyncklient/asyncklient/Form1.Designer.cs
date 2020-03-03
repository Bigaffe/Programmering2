namespace asyncklient
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnanslut = new System.Windows.Forms.Button();
            this.Btnsend = new System.Windows.Forms.Button();
            this.tbxmessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnanslut
            // 
            this.btnanslut.Location = new System.Drawing.Point(119, 10);
            this.btnanslut.Name = "btnanslut";
            this.btnanslut.Size = new System.Drawing.Size(75, 23);
            this.btnanslut.TabIndex = 1;
            this.btnanslut.Text = "Anslut";
            this.btnanslut.UseVisualStyleBackColor = true;
            this.btnanslut.Click += new System.EventHandler(this.Btnanslut_Click_1);
            // 
            // Btnsend
            // 
            this.Btnsend.Location = new System.Drawing.Point(119, 35);
            this.Btnsend.Name = "Btnsend";
            this.Btnsend.Size = new System.Drawing.Size(75, 23);
            this.Btnsend.TabIndex = 2;
            this.Btnsend.Text = "Skicka";
            this.Btnsend.UseVisualStyleBackColor = true;
            this.Btnsend.Click += new System.EventHandler(this.Btnsend_Click);
            // 
            // tbxmessage
            // 
            this.tbxmessage.Location = new System.Drawing.Point(13, 64);
            this.tbxmessage.Multiline = true;
            this.tbxmessage.Name = "tbxmessage";
            this.tbxmessage.Size = new System.Drawing.Size(181, 97);
            this.tbxmessage.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 172);
            this.Controls.Add(this.tbxmessage);
            this.Controls.Add(this.Btnsend);
            this.Controls.Add(this.btnanslut);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnanslut;
        private System.Windows.Forms.Button Btnsend;
        private System.Windows.Forms.TextBox tbxmessage;
    }
}

