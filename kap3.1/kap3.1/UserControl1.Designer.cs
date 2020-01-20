namespace kap3._1
{
    partial class LimitedTextBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxtextlangd = new System.Windows.Forms.TextBox();
            this.lbltextchanged = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // tbxtextlangd
            // 
            this.tbxtextlangd.Location = new System.Drawing.Point(60, 53);
            this.tbxtextlangd.Name = "tbxtextlangd";
            this.tbxtextlangd.Size = new System.Drawing.Size(100, 20);
            this.tbxtextlangd.TabIndex = 0;
            this.tbxtextlangd.TextChanged += new System.EventHandler(this.Tbxtextlangd_TextChanged);
            // 
            // lbltextchanged
            // 
            this.lbltextchanged.AutoSize = true;
            this.lbltextchanged.Location = new System.Drawing.Point(167, 59);
            this.lbltextchanged.Name = "lbltextchanged";
            this.lbltextchanged.Size = new System.Drawing.Size(31, 13);
            this.lbltextchanged.TabIndex = 1;
            this.lbltextchanged.Text = "(140)";
            // 
            // LimitedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbltextchanged);
            this.Controls.Add(this.tbxtextlangd);
            this.Name = "LimitedTextBox";
            this.Size = new System.Drawing.Size(237, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxtextlangd;
        private System.Windows.Forms.Label lbltextchanged;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
