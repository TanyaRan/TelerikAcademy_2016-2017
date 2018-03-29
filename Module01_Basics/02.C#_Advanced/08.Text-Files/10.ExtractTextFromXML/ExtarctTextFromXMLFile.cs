using System.IO;
using System.Text;

namespace ExtractTextFromXML
{
    public class ExtarctTextFromXMLFile
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("xmlFile.txt");
            StringBuilder sb = new StringBuilder();

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    bool isLessThen = false;

                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '<')
                        {
                            isLessThen = true;
                        }
                        else if (line[i] == '>')
                        {
                            isLessThen = false;
                        }
                        else if (!isLessThen)
                        {
                            sb.Append(line[i]);
                        }
                    }

                    line = reader.ReadLine();

                    if (line != null)
                    {
                        sb.AppendLine();
                    }
                }
            }

            File.WriteAllText("result.txt", sb.ToString());
        }
    }
}
