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
          
            cbsmallamount.SelectedIndex = 0;
            cblargeamount.SelectedIndex = 0;
            cbspecialamount.SelectedIndex = 0;
            cbnumberamount.SelectedIndex = 0;
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
                generation.largeamount = Convert.ToInt32(cblargeamount.SelectedItem);
            }
            else
            {
                generation.chlarge = false;
                generation.largeamount = 0;
            }

            if (chbsmall.Checked)
            {
                generation.chsmall = true;
                generation.smallamount = Convert.ToInt32(cbsmallamount.SelectedItem);
            }
            else
            {
                generation.chsmall = false;
                generation.smallamount = 0;
            }

            if (chbNumbers.Checked)
            {
                generation.chnumbers = true;
                generation.numberamount = Convert.ToInt32(cbnumberamount.SelectedItem);
            }
            else
            {
                generation.chnumbers = false;
                generation.numberamount = 0;
            }

            if (chbSpecial.Checked)
            {
                generation.chspecial = true;
                generation.specialamount = Convert.ToInt32(cbspecialamount.SelectedItem);
            }
            else
            {
                generation.chspecial = false;
                generation.specialamount = 0;
            }
            tbpsw.Text = generation.Generationmethod();
            if (tbpsw.Text == "")
            {
                MessageBox.Show("You need to check at least one checkbox");
            }
        }


    }
}
