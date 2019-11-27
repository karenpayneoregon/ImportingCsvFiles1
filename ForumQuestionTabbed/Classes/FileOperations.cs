using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ForumQuestionTabbed.Classes
{
    public class FileOperations
    {
        public delegate void LineHandler(object sender,LineDataArgs myArgs);
        public event LineHandler OnLineHandler;

        public List<string[]> ReadLines(string fileName)
        {
            var linesList = new List<string[]>();

            if (!File.Exists(fileName))
            {
                return linesList;
            }

            string line;
            var isFirstLine = true;

            using (var reader = new StreamReader(fileName))
            {

                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();

                    if (isFirstLine)
                    {
                        isFirstLine = false;
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            var lineDataArgs = new LineDataArgs(
                                Array.ConvertAll(
                                    line.Split('\t'), p => p.Trim()));

                            OnLineHandler(this, lineDataArgs);

                        }

                        continue;
                    }

                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var parts = Array.ConvertAll(line.Split('\t'), p => p.Trim());

                    if (parts.Length <= 3)
                    {
                        linesList.Add(parts);
                    }
                    else if (parts.Length > 3)
                    {
                        linesList.Add(parts.Take(3).ToArray());
                    }
                    
                }

            }

            return linesList;
        }

    }
}
