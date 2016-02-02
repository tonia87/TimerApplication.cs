using System;
using System.Windows.Forms;

namespace WindowsFormsApplicationTimer
{
    public partial class frmWMP : Form
    {
        public frmWMP()
        {
            InitializeComponent();
        }

        private void frmWMP_Load(object sender, EventArgs e)
        {
            WMP1.BeginInit();
            
        }

        private void frmWMP_Leave(object sender, EventArgs e)
        {
            
            
        }

        private void frmWMP_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void WMP1_Enter(object sender, EventArgs e)
        {
            string resourcesPath=System.IO.Directory.GetParent(Application.StartupPath).Parent.FullName + @"\Resources";
            WMP1.URL = resourcesPath + @"\" + "anouk.mp4";
            lblTrack.Text = lblTrack.Text + "NOBODY'S WIFE";
        }
                private void lbxTrack_SelectedIndexChanged(object sender, EventArgs e)
        {
           string resourcesPath = System.IO.Directory.GetParent(Application.StartupPath).Parent.FullName + @"\Resources";

            lblTrack.Text = "Selected track: " + lbxTrack.Text;

            if (lbxTrack.Text == "NOBODY'S WIFE") { WMP1.URL= resourcesPath+@"\"+"anouk.mp4"; }

            else if (lbxTrack.Text == "DELIRIOUS") { WMP1.URL = resourcesPath+@"\"+"guetta.mp4"; }
            else if (lbxTrack.Text == "INFINITY") { WMP1.URL = resourcesPath+@"\"+"guru.mp4"; }
            else if (lbxTrack.Text == "SUMMER MOVED ON") { WMP1.URL = resourcesPath+@"\"+"aha.mp4"; }
            else { WMP1.URL = ""; }
        }

                private void lblChoose_Click(object sender, EventArgs e)
                {
                    
                }
    }
}
