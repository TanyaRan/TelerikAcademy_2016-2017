using System;
using System.Text.RegularExpressions;

namespace ChangeTextInTags
{
    public class ParseTagsDemo
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Regex reg = new Regex("<upcase>(\\w+\\s*)+</upcase>");// finds all
            MatchCollection matches = reg.Matches(input);

            foreach (Match match in matches)
            {
                string result = match.ToString();
                result = result.Replace("<upcase>", ""); 
                result = result.Replace("</upcase>", ""); 
                result = result.ToUpper(); 

                input = input.Replace(match.ToString(), result); // replace in the main text
            }

            Console.WriteLine(input);
        }
    }
}
