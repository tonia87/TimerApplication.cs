namespace WindowsFormsApplicationTimer
{
    partial class frmTimer
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
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.btnOpenFormWMP = new System.Windows.Forms.Button();
            this.rdbSet = new System.Windows.Forms.RadioButton();
            this.rdbDisable = new System.Windows.Forms.RadioButton();
            this.mtxt = new System.Windows.Forms.MaskedTextBox();
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.lbllbl = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.PaleGreen;
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTime.Location = new System.Drawing.Point(103, 25);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(204, 39);
            this.lblTime.TabIndex = 0;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // tmr1
            // 
            this.tmr1.Enabled = true;
            this.tmr1.Interval = 1000;
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // btnOpenFormWMP
            // 
            this.btnOpenFormWMP.BackColor = System.Drawing.Color.PaleGreen;
            this.btnOpenFormWMP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenFormWMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnOpenFormWMP.Location = new System.Drawing.Point(144, 329);
            this.btnOpenFormWMP.Name = "btnOpenFormWMP";
            this.btnOpenFormWMP.Size = new System.Drawing.Size(146, 61);
            this.btnOpenFormWMP.TabIndex = 1;
            this.btnOpenFormWMP.Text = "Windows Media Player";
            this.btnOpenFormWMP.UseVisualStyleBackColor = false;
            this.btnOpenFormWMP.Click += new System.EventHandler(this.btnOpenFormWMP_Click);
            // 
            // rdbSet
            // 
            this.rdbSet.BackColor = System.Drawing.Color.PaleGreen;
            this.rdbSet.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rdbSet.Location = new System.Drawing.Point(53, 142);
            this.rdbSet.Name = "rdbSet";
            this.rdbSet.Size = new System.Drawing.Size(87, 29);
            this.rdbSet.TabIndex = 13;
            this.rdbSet.Text = "Alarm On";
            this.rdbSet.UseVisualStyleBackColor = false;
            this.rdbSet.CheckedChanged += new System.EventHandler(this.rdbSet_CheckedChanged);
            this.rdbSet.Click += new System.EventHandler(this.rdbSet_Click);
            // 
            // rdbDisable
            // 
            this.rdbDisable.BackColor = System.Drawing.Color.PaleGreen;
            this.rdbDisable.Checked = true;
            this.rdbDisable.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rdbDisable.Location = new System.Drawing.Point(53, 208);
            this.rdbDisable.Name = "rdbDisable";
            this.rdbDisable.Size = new System.Drawing.Size(87, 29);
            this.rdbDisable.TabIndex = 14;
            this.rdbDisable.TabStop = true;
            this.rdbDisable.Text = "Alarm Off";
            this.rdbDisable.UseVisualStyleBackColor = false;
            this.rdbDisable.CheckedChanged += new System.EventHandler(this.rdbDisable_CheckedChanged);
            this.rdbDisable.Click += new System.EventHandler(this.rdbDisable_Click);
            // 
            // mtxt
            // 
            this.mtxt.BackColor = System.Drawing.Color.PaleGreen;
            this.mtxt.BeepOnError = true;
            this.mtxt.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mtxt.Location = new System.Drawing.Point(226, 141);
            this.mtxt.Mask = "0000/00/00 00:00:00";
            this.mtxt.Name = "mtxt";
            this.mtxt.Size = new System.Drawing.Size(146, 29);
            this.mtxt.TabIndex = 16;
            this.mtxt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxt_MaskInputRejected);
            // 
            // tmr2
            // 
            this.tmr2.Enabled = true;
            this.tmr2.Interval = 1000;
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // lbllbl
            // 
            this.lbllbl.AutoSize = true;
            this.lbllbl.BackColor = System.Drawing.Color.PaleGreen;
            this.lbllbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbllbl.Location = new System.Drawing.Point(182, 84);
            this.lbllbl.Name = "lbllbl";
            this.lbllbl.Size = new System.Drawing.Size(0, 13);
            this.lbllbl.TabIndex = 17;
            this.lbllbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAbout.Location = new System.Drawing.Point(185, 426);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(54, 23);
            this.btnAbout.TabIndex = 19;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::WindowsFormsApplicationTimer.Properties.Resources.cave;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(422, 480);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lbllbl);
            this.Controls.Add(this.mtxt);
            this.Controls.Add(this.rdbDisable);
            this.Controls.Add(this.rdbSet);
            this.Controls.Add(this.btnOpenFormWMP);
            this.Controls.Add(this.lblTime);
            this.Name = "frmTimer";
            this.Text = "TIMER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTimer_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTimer_FormClosed);
            this.Load += new System.EventHandler(this.frmTimer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTimer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Button btnOpenFormWMP;
        private System.Windows.Forms.RadioButton rdbSet;
        private System.Windows.Forms.RadioButton rdbDisable;
        private System.Windows.Forms.MaskedTextBox mtxt;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.Label lbllbl;
        private System.Windows.Forms.Button btnAbout;
    }
}

