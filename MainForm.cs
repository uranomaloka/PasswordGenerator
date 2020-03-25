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
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            tbpsw.Text = generation.Generationmethod();
            
        }
    }
}
