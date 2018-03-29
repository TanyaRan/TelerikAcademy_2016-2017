using System.IO;
using System.Text;

namespace DeleteOddLines
{
    public class DeleteOddLinesInFile
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("test.txt");
            StringBuilder resultFileString = new StringBuilder();

            using (reader)
            {
                string line = reader.ReadLine();
                int linesCounter = 1;

                while (line != null)
                {
                    if (linesCounter % 2 == 0)
                    {
                        resultFileString.Append(line);
                        resultFileString.AppendLine();
                    }

                    line = reader.ReadLine();
                    linesCounter++;
                }
            }

            StreamWriter writer = new StreamWriter("test.txt");
            using (writer)
            {
                writer.WriteLine(resultFileString.ToString());
            }
        }
    }
}
