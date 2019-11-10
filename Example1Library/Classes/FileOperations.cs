using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Example1Library.Extensions;

namespace Example1Library.Classes
{
    public class FileOperations : BaseConnectionLibrary.BaseExceptionProperties
    {
        public List<Customer> ReadCustomersPerfectWorld(string fileName)
        {

            return (
                from line in File.ReadAllLines(fileName)
                where line.Length > 0
                let lineParts = line.Split(',')
                select new Customer()
                {
                    FirstName = lineParts[0],
                    LastName = lineParts[1],
                    Street = lineParts[2],
                    City = lineParts[3],
                    State = lineParts[4],
                    Country = lineParts[5],
                    Balance = Convert.ToDecimal(lineParts[6]),
                    LastPaid = Convert.ToDateTime(lineParts[7])
                }).ToList();

        }
        public List<Customer> ReadCustomersImperfectWorld(string fileName)
        {

            var customerList = new List<Customer>();

            try
            {
                customerList = (
                    from line in File.ReadAllLines(fileName)
                    where line.Length > 0
                    let lineParts = line.Split(',')
                    select new Customer()
                    {
                        FirstName = lineParts[0],
                        LastName = lineParts[1],
                        Street = lineParts[2],
                        City = lineParts[3],
                        State = lineParts[4],
                        Country = lineParts[5],
                        Balance = Convert.ToDecimal(lineParts[6]),
                        LastPaid = Convert.ToDateTime(lineParts[7])
                    }).ToList();
            }
            catch (Exception ex)
            {
                mHasException = true;
                mLastException = ex;
            }

            return customerList;

        }

        public (List<Customer> customers, List<string> issues) ReadCustomersPerfectWorldCreator(string fileName)
        {

            var customerList = new List<Customer>();
            var issueList = new List<string>();


            var counterValidLines = 0;
            var counterEmptyLines = 0;
            var currentLineIndex = 1;

            string line;


            var file = new StreamReader(fileName);
            try
            {
                while ((line = file.ReadLine()) != null)
                {

                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        counterValidLines++;
                        var result = new CustomerCreator(line, currentLineIndex);
                        if (result.HasIssues)
                        {
                            issueList.AddRange(result.IssueList);
                        }
                        else
                        {
                            customerList.Add(result.Customer);
                        }

                    }
                    else
                    {
                        counterEmptyLines++;
                    }

                    currentLineIndex++;

                }
            }
            catch (Exception exception)
            {
                mHasException = true;
                mLastException = exception;
            }
            finally
            {
                file.Close();
            }


            Console.WriteLine("There were {0} valid lines.", counterValidLines);
            Console.WriteLine("There were {0} empty lines.", counterEmptyLines);
            Console.WriteLine(counterEmptyLines + counterValidLines);

            return (customerList, issueList);
        }

        public List<string> FixingSpacesInLines(string fileName)
        {

            var linesList = new List<string>();

            string line;
            using (var reader = new StreamReader(fileName))
            {

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    string[] parts = Array.ConvertAll(line.Split(','), p => p.Trim());
                    var tttt = parts.Select(items => $"[{items}]");
                    Console.WriteLine(string.Join(",", tttt));
                }

            }

     
            return linesList;
        }

        public void FixSpacesToNewFile(string inputFileName, string newFileName)
        {
            var stringBuilder = new StringBuilder();

            using (var reader = new StreamReader(inputFileName))
            {

                while (!reader.EndOfStream)
                {
                    stringBuilder.AppendLine(reader.ReadLine().ProcessSpacings());
                }

            }

            File.WriteAllText(newFileName, stringBuilder.ToString());

        }
        /// <summary>
        /// Used for validating each line has a valid date field
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<string> ValidatePaidDate(string fileName)
        {
            const int fieldCount = 8;
            var issues = new List<string>();
            var line = "";
            int lineIndex = 1;

            using (var reader = new StreamReader(fileName))
            {

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();

                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var parts = line.ProcessSpacings().Split(',');

                        if (parts.Length != fieldCount)
                        {
                            issues.Add($"Line {lineIndex} has no data");
                        }

                        if (!string.IsNullOrWhiteSpace(parts[7]))
                        {
                            if (!DateTime.TryParse(parts[7], out var _ ))
                            {
                                issues.Add($"Line {lineIndex} '{parts[7]}' is not a valid date");
                            }
                        }
                    }

                    lineIndex++;
                }

            }

            return issues;
        }
        /// <summary>
        /// For validating each line in a file has information
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<int> EmptyLines(string fileName)
        {
            var lineList = new List<int>();
            var line = "";
            int lineIndex = 1;

            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        lineList.Add(lineIndex);
                    }

                    lineIndex++;
                }
            }

            return lineList;
        }
        /// <summary>
        /// Validate each line has the proper field count
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public List<int> HasValidFieldCount(string fileName)
        {
            var lineList = new List<int>();
            var line = "";
            int lineIndex = 1;

            const int fieldCount = 8;

            using (var reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();

                    if (line != null && line.Split(',').Length != fieldCount)
                    {                        
                        lineList.Add(lineIndex);
                    }

                    lineIndex++;
                }
            }

            return lineList;
        }

    }

}
