namespace kap3._1
{
    partial class UserControl2
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
            this.lbltextchanged = new System.Windows.Forms.Label();
            this.tbxtextlangd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbltextchanged
            // 
            this.lbltextchanged.AutoSize = true;
            this.lbltextchanged.Location = new System.Drawing.Point(130, 68);
            this.lbltextchanged.Name = "lbltextchanged";
            this.lbltextchanged.Size = new System.Drawing.Size(31, 13);
            this.lbltextchanged.TabIndex = 3;
            this.lbltextchanged.Text = "(140)";
            // 
            // tbxtextlangd
            // 
            this.tbxtextlangd.Location = new System.Drawing.Point(24, 65);
            this.tbxtextlangd.Name = "tbxtextlangd";
            this.tbxtextlangd.Size = new System.Drawing.Size(100, 20);
            this.tbxtextlangd.TabIndex = 2;
            this.tbxtextlangd.TextChanged += new System.EventHandler(this.Tbxtextlangd_TextChanged);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbltextchanged);
            this.Controls.Add(this.tbxtextlangd);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(233, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltextchanged;
        private System.Windows.Forms.TextBox tbxtextlangd;
    }
}
