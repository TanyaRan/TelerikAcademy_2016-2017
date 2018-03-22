using System;
using System.Text.RegularExpressions;

namespace SeriesOfLetters
{
    public class ReplaceSeriesOfLettersWithOne
    {
        public static void Main()
        {
            string inputText = Console.ReadLine();

            string changedText = Regex.Replace(inputText, @"(\s)\1+", "$1"); // single spaces only
           
            changedText = Regex.Replace(changedText, @"(\w)\1+", "$1"); // replace "aaaa" with "a"

            Console.WriteLine(changedText);
        }
    }
}
