using System;
using System.IO;

namespace CompareTextFiles
{
    public class CompareTextFilesLineByLine
    {
        public static void Main()
        {
            StreamReader firstFile = new StreamReader("firstFile.txt");
            StreamReader secondFile = new StreamReader("secondFile.txt");

            using (firstFile)
            {
                using (secondFile)
                {
                    string lineInFirstFile = firstFile.ReadLine();
                    string lineInSecondFile = secondFile.ReadLine();

                    int equalLinesCounter = 0;
                    int differentLinesCounter = 0;

                    // The files have equal number of lines!
                    while (lineInFirstFile != null)
                    {
                        int equalLines = lineInFirstFile.CompareTo(lineInSecondFile);
                        if (equalLines == 0)
                        {
                            equalLinesCounter++;
                        }
                        else
                        {
                            differentLinesCounter++;
                        }

                        lineInFirstFile = firstFile.ReadLine();
                        lineInSecondFile = secondFile.ReadLine();
                    }

                    Console.WriteLine("The number of lines that are the same is {0}.\nThe number of lines that are different is {1}.",
                                        equalLinesCounter, differentLinesCounter);
                }
            }
        }
    }
}
