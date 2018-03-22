using System;
using System.Text.RegularExpressions;

namespace ReplaceTags
{
    public class ReplaceTagsMarkdownNotation
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string parsedHTML = Regex.Replace(input, "(<a href=\")(.*?)(\">)(.*?)(</a>)", "[$4]($2)");

            Console.WriteLine(parsedHTML);
        }
    }
}
