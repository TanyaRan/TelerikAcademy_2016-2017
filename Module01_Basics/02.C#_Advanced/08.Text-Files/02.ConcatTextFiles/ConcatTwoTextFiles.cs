using System.IO;
using System.Text;

namespace ConcatTextFiles
{
    public class ConcatTwoTextFiles
    {
        public static void Main()
        {
            StreamReader readFirstFile = new StreamReader("firstFile.txt");
            StreamReader readSecondFile = new StreamReader("secondFile.txt");

            using (readFirstFile)
            {
                using (readSecondFile)
                {
                    StreamWriter resultFile = new StreamWriter("resultFile.txt");

                    string firstFileString = readFirstFile.ReadToEnd();
                    string secongFileString = readSecondFile.ReadToEnd();

                    StringBuilder result = new StringBuilder();
                    result.Append(firstFileString);
                    result.AppendLine();
                    result.Append(secongFileString);

                    using (resultFile)
                    {
                        resultFile.WriteLine(result.ToString());
                    }
                }
            }
        }
    }
}
