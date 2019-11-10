using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Example1Library;
using Example1Library.Classes;
using Example1Library.HelperClasses;
using static Example1.Classes.Dialogs;

namespace Example1
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Example where there are zero issues with reading in a delimited file
        /// into a strong typed list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PerfectWorldExampleListButton_Click(object sender, EventArgs e)
        {
            var fileOperations = new FileOperations();
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Import1.txt");

            _bindingSource.DataSource = fileOperations.ReadCustomersPerfectWorld(fileName);

            dataGridView1.DataSource = _bindingSource;

        }
        /// <summary>
        /// Example where there are zero issues with reading in a delimited file
        /// into a strong typed list then finally into a DataTable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PerfectWorldExampleDataTableButton_Click(object sender, EventArgs e)
        {
            var fileOperations = new FileOperations();
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Import1.txt");

            _bindingSource.DataSource = ListHelpers.ConvertToDataTable(
                fileOperations.ReadCustomersPerfectWorld(fileName));

            dataGridView1.DataSource = _bindingSource;

        }
        /// <summary>
        /// Example of reading in a file which is imperfect, not suitable
        /// to import.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RealWorldBad1Button_Click(object sender, EventArgs e)
        {
            var fileOperations = new FileOperations();
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Import2.txt");

            _bindingSource.DataSource = fileOperations.ReadCustomersImperfectWorld(fileName);

            if (fileOperations.IsSuccessFul)
            {
                dataGridView1.DataSource = _bindingSource;
            }
            else
            {
                MessageBox.Show(fileOperations.LastExceptionMessage);
            }
            
        }
        /// <summary>
        /// Example were validation is performed in a method which
        /// returns information via a ValueTuple, a list of Customer
        /// and a list of issues if any
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RealWorldGoodButton_Click(object sender, EventArgs e)
        {
            var fileOperations = new FileOperations();
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Import1.txt");

            var (customers, issueList) = fileOperations.ReadCustomersPerfectWorldCreator(fileName);

            if (fileOperations.IsSuccessFul)
            {
                _bindingSource.DataSource = customers;
                dataGridView1.DataSource = _bindingSource;
            }
            else
            {
                MessageBox.Show(fileOperations.LastExceptionMessage);
            }

            if (issueList.Count <= 0) return;

            if (Question("There were imperfect data, review?"))
            {
                var issuesForm = new IssuesForm(issueList) {Text = "Encountered these issues"};
                try
                {
                    issuesForm.ShowDialog();
                }
                finally
                {
                    issuesForm.Dispose();
                }
            }
        }
        /// <summary>
        /// Iterate lines in a text file, remove leading an trailing spaces
        /// from each field then save to a new file.
        ///
        /// This would part of a incremental process of parsing a file to
        /// get ready to import rather than doing all processing at once.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SpacesInLinesButton_Click(object sender, EventArgs e)
        {
            var fileOperations = new FileOperations();

            var inputfileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Import4.txt");
            var outputfileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Import4a.txt");

            fileOperations.FixingSpacesInLines(inputfileName);

            fileOperations.FixSpacesToNewFile(inputfileName,outputfileName);

            Process.Start(outputfileName);
        }

        private void ValidateDateColumnButton_Click(object sender, EventArgs e)
        {
            var fileOperations = new FileOperations();
            var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Import5.txt");
            var issueList = fileOperations.ValidatePaidDate(fileName);
            if (issueList.Count >0)
            {
                var issuesForm = new IssuesForm(issueList) {Text = "Invalid paid dates"};
                try
                {
                    issuesForm.ShowDialog();
                }
                finally
                {
                    issuesForm.Dispose();
                }
            }
        }
    }
}
