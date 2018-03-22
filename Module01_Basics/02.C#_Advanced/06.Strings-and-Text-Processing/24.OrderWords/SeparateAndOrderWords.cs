using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OrderWords
{
    public class SeparateAndOrderWords
    {
        public static void Main()
        {
            string inputText = Console.ReadLine();
            List<string> words = new List<string>();

            foreach (Match word in Regex.Matches(inputText, @"\w+"))
            {
                words.Add(word.Value);
            }

            words.Sort(); 

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
