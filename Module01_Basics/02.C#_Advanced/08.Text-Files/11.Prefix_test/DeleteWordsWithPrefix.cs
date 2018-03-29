using System.IO;
using System.Text.RegularExpressions;

namespace Prefix_test
{
    public class DeleteWordsWithPrefix
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("test.txt");
            string line = string.Empty;

            using (reader)
            {
                line = reader.ReadLine();
                StreamWriter writer = new StreamWriter("result.txt");

                using (writer)
                {
                    while (line != null)
                    {
                        writer.WriteLine(Regex.Replace(line, @"\btest\w+\b", "", 
                            RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace));
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
