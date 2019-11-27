using System;
using System.IO;
using System.Windows.Forms;
using ForumQuestionTabbed.Classes;

namespace ForumQuestionTabbed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
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

            ActiveControl = dataGridView1;
            dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            dataGridView1.Rows[0].Selected = true;
        }
        /// <summary>
        /// Set column header text to the array elements containing the
        /// first line read from the file.
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="args"></param>
        private void FileOperations_OnReadingFirstLine(object myObject, LineDataArgs args)
        {
            for (int index = 0; index < args.LineArray.Length; index++)
            {
                dataGridView1.Columns[index].HeaderText = args.LineArray[index];
            }
        }
    }
}
