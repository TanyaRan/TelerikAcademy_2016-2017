using System;
using System.Text.RegularExpressions;

namespace _18.ExtractEmails
{
    public class ExtractEmailsDemo
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"([0-9a-zA-Z_-])+@([a-zA-Z])+\.([a-z]{2,3})";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }
    }
}
