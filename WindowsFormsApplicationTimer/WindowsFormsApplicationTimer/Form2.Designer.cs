namespace WindowsFormsApplicationTimer
{
    partial class frmWMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWMP));
            this.WMP1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbxTrack = new System.Windows.Forms.ListBox();
            this.lblTrack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).BeginInit();
            this.SuspendLayout();
            // 
            // WMP1
            // 
            this.WMP1.Enabled = true;
            this.WMP1.Location = new System.Drawing.Point(32, 292);
            this.WMP1.Name = "WMP1";
            this.WMP1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP1.OcxState")));
            this.WMP1.Size = new System.Drawing.Size(380, 207);
            this.WMP1.TabIndex = 0;
            this.WMP1.Enter += new System.EventHandler(this.WMP1_Enter);
            // 
            // lbxTrack
            // 
            this.lbxTrack.BackColor = System.Drawing.Color.PaleGreen;
            this.lbxTrack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lbxTrack.FormattingEnabled = true;
            this.lbxTrack.ItemHeight = 16;
            this.lbxTrack.Items.AddRange(new object[] {
            "(none)",
            "DELIRIOUS",
            "INFINITY",
            "NOBODY\'S WIFE",
            "SUMMER MOVED ON"});
            this.lbxTrack.Location = new System.Drawing.Point(12, 64);
            this.lbxTrack.Name = "lbxTrack";
            this.lbxTrack.Size = new System.Drawing.Size(142, 80);
            this.lbxTrack.Sorted = true;
            this.lbxTrack.TabIndex = 1;
            this.lbxTrack.SelectedIndexChanged += new System.EventHandler(this.lbxTrack_SelectedIndexChanged);
            // 
            // lblTrack
            // 
            this.lblTrack.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTrack.Location = new System.Drawing.Point(32, 257);
            this.lblTrack.Name = "lblTrack";
            this.lblTrack.Size = new System.Drawing.Size(380, 23);
            this.lblTrack.TabIndex = 2;
            this.lblTrack.Text = "Selected track: ";
            this.lblTrack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmWMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplicationTimer.Properties.Resources.cave;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(448, 511);
            this.Controls.Add(this.lblTrack);
            this.Controls.Add(this.lbxTrack);
            this.Controls.Add(this.WMP1);
            this.Name = "frmWMP";
            this.Text = "Wake Up Call!!!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWMP_FormClosed);
            this.Load += new System.EventHandler(this.frmWMP_Load);
            this.Leave += new System.EventHandler(this.frmWMP_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.WMP1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WMP1;
        private System.Windows.Forms.ListBox lbxTrack;
        private System.Windows.Forms.Label lblTrack;
    }
}