using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationTimer
{ 
    public partial class frmTimer : Form
    {
    
        public frmTimer()
        {
            InitializeComponent();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            tmr2.Enabled = false;
        }

        private void btnOpenFormWMP_Click(object sender, EventArgs e)
        {
            

            frmWMP f = new frmWMP();
            f.Show();
            

        }


        DateTime dSet;
        private void btnOk_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rdbSet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSet.Checked == true)
            {
                rdbDisable.Checked = false;

                try
                {
                    dSet = Convert.ToDateTime(mtxt.Text);

                         if (dSet > System.DateTime.Now){
                            lbllbl.Text = "Alarm Is On";
                            tmr2.Enabled=true ;
                            
                      }
                        
                    
                    else
                    {
                        MessageBox.Show("Datetime entered not valid!");
                        rdbDisable.Checked = true;
                        rdbSet.Checked = false;
                    }
                }
                catch
                {
                    MessageBox.Show("Improper input... Enter alarm time first, e.g. "+ System.DateTime.Now );
                    rdbSet.Checked = false;
                    rdbDisable.Checked = true;
                }
            }
            else { rdbDisable.Checked = true; }
        }
        private void rdbDisable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDisable.Checked == true)
            {
                rdbSet.Checked = false;
                tmr2.Enabled = false ;
                lbllbl.Text = "";
            }
            else { rdbSet.Checked = true; }
        }

        private void txtSet_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbDisable_Click(object sender, EventArgs e)
        {
        }

        private void rdbSet_Click(object sender, EventArgs e)
        {
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            if (dSet < System.DateTime.Now)
            {
                tmr2.Enabled = false;

                frmWMP w = new frmWMP();
                w.Show();

                lbllbl.Text = "";
                rdbDisable.Checked = true;

            }

        }

        private void mtxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
           
            frmAbout a = new frmAbout();
            a.Show();
        }

        private void frmTimer_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmTimer_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmTimer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8 && e.Modifiers == Keys.Shift)
            {
                frmAbout z = new frmAbout();
                z.Show();
            }
        }
    }
    }

