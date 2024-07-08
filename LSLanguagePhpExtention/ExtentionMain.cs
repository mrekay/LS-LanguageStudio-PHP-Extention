using LongShiftLanguage.Classes.Components;
using LongShiftLanguage.Forms;
using LongShiftLanguage.Interfaces;
using LSLanguagePhpExtention.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSLanguagePhpExtention
{
    public class ExtentionMain : IExtension
    {
        public void Execute()
        {

        }

        public ToolMenuButton[] GetButtons()
        {
            var ExportToIDE = new ToolMenuButton(Properties.Resources.php);
            ExportToIDE.Click += ExportPHP;
            ExportToIDE.ToolTipText = "Convert project to php standard class";
            return new ToolMenuButton[] { ExportToIDE };
        }

        public ToolStripMenuItem[] GetMenuItems()
        {
            var showEditorMI = new ToolStripMenuItem() { Text = "PHP Class Editor"};
            showEditorMI.Click += ShowEditorMI_Click;
            return new ToolStripMenuItem[] { showEditorMI };
        }

        public void ExportPHP(object sender, EventArgs eventArgs)
        {

            var defLang = ProjectForm.SelectedLanguage();
            var dict = defLang.ConvertToDict();
            var buildedClass = LanguageClassBuilder.BuildClass(defLang.name, dict);
            if (string.IsNullOrEmpty(Properties.Settings.Default.ExportLocation))
            {

                OpenFileDialog opf = new OpenFileDialog();
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    if (opf.CheckFileExists)
                    {
                        Properties.Settings.Default.ExportLocation = opf.FileName;
                        Properties.Settings.Default.Save();

                        SaveToFile(buildedClass);
                    }
                    else CopyToClipboard(buildedClass);
                }
                else CopyToClipboard(buildedClass);
            }
            else
            {
                SaveToFile(buildedClass);
            }
        }

        private void SaveToFile(string buildedClass)
        {
            File.WriteAllText(Properties.Settings.Default.ExportLocation, buildedClass);

            ProjectForm.SetLastProcessLabel(string.Format("Code exported to {0}", Properties.Settings.Default.ExportLocation));
        }

        private void CopyToClipboard(string text)
        {
            MessageBox.Show("Code copied to clipboard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText(text);
            ProjectForm.SetLastProcessLabel("Code copied to clipboard");
        }

        private void ShowEditorMI_Click(object sender, EventArgs e)
        {
           var stdCEditor = new StandardClassEditor();
            stdCEditor.ShowDialog();
        }
    }
}
