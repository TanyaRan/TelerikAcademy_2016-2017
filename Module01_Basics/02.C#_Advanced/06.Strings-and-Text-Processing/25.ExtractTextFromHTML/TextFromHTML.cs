using System;
using System.Text.RegularExpressions;

namespace ExtractTextFromHTML
{
    public class TextFromHTML
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            foreach (Match text in Regex.Matches(input, "(?<=>).*?(?=<)"))
            {
                if (!String.IsNullOrWhiteSpace(text.Value))
                {
                    Console.WriteLine(text);
                }
            }
        }
    }
}
