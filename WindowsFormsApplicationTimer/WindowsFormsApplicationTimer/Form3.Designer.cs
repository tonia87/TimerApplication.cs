namespace WindowsFormsApplicationTimer
{
    partial class frmAbout
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
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblAboutClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAbout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAbout.Location = new System.Drawing.Point(39, 35);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(0, 16);
            this.lblAbout.TabIndex = 0;
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAboutClass
            // 
            this.lblAboutClass.AutoSize = true;
            this.lblAboutClass.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAboutClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAboutClass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAboutClass.Location = new System.Drawing.Point(68, 97);
            this.lblAboutClass.Name = "lblAboutClass";
            this.lblAboutClass.Size = new System.Drawing.Size(0, 15);
            this.lblAboutClass.TabIndex = 1;
            this.lblAboutClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplicationTimer.Properties.Resources.cave;
            this.ClientSize = new System.Drawing.Size(226, 142);
            this.Controls.Add(this.lblAboutClass);
            this.Controls.Add(this.lblAbout);
            this.Name = "frmAbout";
            this.Text = "About";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAbout_FormClosed);
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblAboutClass;
    }
}