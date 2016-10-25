using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingeproject
{
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
            ValidBtn.Enabled = false;
        }
        
        private void ValidBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            exerciceForm ef = new exerciceForm(new Attempt(NameTB.Text, (int)AgeUD.Value));
            ef.ShowDialog();
            
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {
            if (NameTB.Text != "" && AgeUD.Value > 0)
            {
                ValidBtn.Enabled = true;
            }
            else
            {
                ValidBtn.Enabled = false;
            }
        }

        private void AgeUD_ValueChanged(object sender, EventArgs e)
        {
            if (NameTB.Text != "" && AgeUD.Value > 0)
            {
                ValidBtn.Enabled = true;
            }
            else
            {
                ValidBtn.Enabled = false;
            }
        }
    }
}
