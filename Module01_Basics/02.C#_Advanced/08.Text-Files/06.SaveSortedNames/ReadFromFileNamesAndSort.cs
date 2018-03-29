using System.Collections.Generic;
using System.IO;

namespace SaveSortedNames
{
    public class ReadFromFileNamesAndSort
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("fileToSort.txt");
            List<string> linesContainer = new List<string>();

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    linesContainer.Add(line.Trim());
                    line = reader.ReadLine();
                }

                linesContainer.Sort();
            }

            StreamWriter writer = new StreamWriter("sortedFile.txt");

            using (writer)
            {
                foreach (var lines in linesContainer)
                {
                    writer.WriteLine(lines);
                }
            }
        }
    }
}
