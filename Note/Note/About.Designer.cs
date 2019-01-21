namespace Note
{
    partial class About
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
            this.textAbout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textAbout
            // 
            this.textAbout.BackColor = System.Drawing.SystemColors.Window;
            this.textAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAbout.Enabled = false;
            this.textAbout.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textAbout.Location = new System.Drawing.Point(0, 0);
            this.textAbout.Multiline = true;
            this.textAbout.Name = "textAbout";
            this.textAbout.Size = new System.Drawing.Size(577, 331);
            this.textAbout.TabIndex = 0;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 331);
            this.Controls.Add(this.textAbout);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAbout;
    }
}