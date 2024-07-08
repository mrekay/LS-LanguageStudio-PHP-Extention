using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSLanguagePhpExtention.Forms
{
    public partial class StandardClassEditor : LSForm
    {
        public StandardClassEditor()
        {

            FormText = "Standard Sets";
           MinimizeBox = false;

            InitializeComponent();
        }

        private void StandardClassEditor_Load(object sender, EventArgs e)
        {
            rtb_stdclass.Text = Properties.Settings.Default.DefaultClass;
            rtb_translation.Text = Properties.Settings.Default.DefaultTranslation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultClass = rtb_stdclass.Text;
            Properties.Settings.Default.DefaultTranslation = rtb_translation.Text;
            Properties.Settings.Default.Save();
        }
    }
}
