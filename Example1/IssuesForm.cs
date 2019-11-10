using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example1
{
    public partial class IssuesForm : Form
    {
        public IssuesForm()
        {
            InitializeComponent();
        }

        private string issues;
        public IssuesForm(List<string> linesList)
        {
            InitializeComponent();

            issues = string.Join(Environment.NewLine, linesList.ToArray());

            saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            
            Shown += IssuesForm_Shown;
        }

        private void IssuesForm_Shown(object sender, EventArgs e)
        {
            textBox1.Text = issues;
            textBox1.Select(0,0);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, textBox1.Lines);
            }
        }
    }
}
