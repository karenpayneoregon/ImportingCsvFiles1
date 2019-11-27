using System;
using System.IO;
using System.Windows.Forms;

namespace ForumQuestionTabbed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Import1.txt");

            var fileOperations = new FileOperations();
            fileOperations.OnLineHandler += FileOperations_OnReadingFirstLine;

            var data = fileOperations.ReadLines(fileName);

            foreach (var rowData in data)
            {
                dataGridView1.Rows.Add(rowData);
            }
        }
        private void FileOperations_OnReadingFirstLine(object myObject, LineDataArgs args)
        {
            Console.WriteLine(string.Join(",",args.LineArray));
        }
    }
}
