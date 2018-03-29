using System;
using System.IO;

namespace OddLines
{
    public class PrintOddLinesOfFile
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("test.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int linesCounter = 1;

                while (line != null)
                {
                    if (linesCounter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    line = reader.ReadLine();
                    linesCounter++;
                }
            }
        }
    }
}
