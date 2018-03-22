using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OrderWords_Unique
{
    public class SeparateAndOrderUniqueWords
    {
        public static void Main()
        {
            string inputText = Console.ReadLine();
            var words = new SortedSet<string>(); // unique words !!!

            foreach (Match word in Regex.Matches(inputText, @"\w+"))
            {
                words.Add(word.Value);
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
