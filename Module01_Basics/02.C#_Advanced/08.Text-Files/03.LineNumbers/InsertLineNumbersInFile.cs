using System.IO;
using System.Text;

namespace LineNumbers
{
    public class InsertLineNumbersInFile
    {
        public static void Main()
        {
            string line = string.Empty;
            StringBuilder newFile = new StringBuilder();
            StreamReader reader = new StreamReader("test.txt");

            using (reader)
            {
                line = reader.ReadLine();
                int lineCounter = 1;

                while (line != null)
                {
                    newFile.AppendFormat("{0,-4} {1}", lineCounter, line);
                    newFile.AppendLine();

                    line = reader.ReadLine();
                    lineCounter++;
                }
            }

            StreamWriter writer = new StreamWriter("testWithLineNumbers.txt");
            
            using (writer)
            {
                writer.WriteLine(newFile.ToString());
            }
        }
    }
}
