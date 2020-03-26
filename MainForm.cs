using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwort_Generator
{
    public partial class MainForm : Form
    {
        Generation generation = new Generation();
        public MainForm()
        {
            InitializeComponent();
            cbLength.SelectedIndex = 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.btnGenerate, "Generate your Password");
            toolTip.SetToolTip(this.chbLarge, "Add large Characters to your Password");
            toolTip.SetToolTip(this.chbsmall, "Add small Characters to your Password");
            toolTip.SetToolTip(this.chbNumbers, "Add Numbers to your Password");
            toolTip.SetToolTip(this.chbSpecial, "Add special Characters to your Password");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (chbLarge.Checked)
            {
                generation.chlarge = true;
            }
            else
            {
                generation.chlarge = false;
            }

            if (chbsmall.Checked)
            {
                generation.chsmall = true;
            }
            else
            {
                generation.chsmall = false;
            }

            if (chbNumbers.Checked)
            {
                generation.chnumbers = true;
            }
            else
            {
                generation.chnumbers = false;
            }

            if (chbSpecial.Checked)
            {
                generation.chspecial = true;
            }
            else
            {
                generation.chspecial = false;
            }
            tbpsw.Text = generation.Generationmethod(Convert.ToInt32(cbLength.SelectedItem));
            if (tbpsw.Text == "")
            {
                MessageBox.Show("You need to check at least one checkbox");
            }
        }


    }
}
