using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceSubstring
{
    public class ReplaceSubstringInFile
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("start.txt");
            string line = string.Empty;

            using (reader)
            {
                line = reader.ReadLine();
                StreamWriter writer = new StreamWriter("finish.txt");

                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine(Regex.Replace(line, @"\b\w*start\w*\b", "finish", 
                            RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
