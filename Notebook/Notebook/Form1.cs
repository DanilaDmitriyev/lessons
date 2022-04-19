using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Notebook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TextForm textForm = this.MdiChildren.OfType<TextForm>().FirstOrDefault(f => f.Path == openFileDialog.FileName);
                    if (textForm == null)
                    {
                        textForm = new TextForm();
                        textForm.MdiParent = this;
                        textForm.Content = File.ReadAllText(openFileDialog.FileName);
                        textForm.Text = Path.GetFileName(openFileDialog.FileName);
                        textForm.Path = openFileDialog.FileName;
                        textForm.Show();
                    }
                    else
                    {
                        textForm.Content = File.ReadAllText(openFileDialog.FileName);
                        textForm.Activate();
                    }
                }
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextForm textForm = this.ActiveMdiChild as TextForm;
            if (textForm == null) return;
            if (textForm.Path == null)
            SaveFile(textForm);
            else File.WriteAllText(textForm.Path, textForm.Content);

        }

        private static void SaveFile(TextForm textForm)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, textForm.Content);
                    textForm.Text = Path.GetFileName(saveFileDialog.FileName);
                    textForm.Path = saveFileDialog.FileName;
                }
            }
        }

        private void createFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextForm textForm = new TextForm();
            textForm.MdiParent = this;
            textForm.Show();
        }

        private void saveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextForm textForm = this.ActiveMdiChild as TextForm;
            if (textForm == null) return;
            SaveFile(textForm);
        }
    }
}
