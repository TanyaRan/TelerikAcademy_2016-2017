using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WordsCount
{
    public class CountWordsInText
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (Match item in Regex.Matches(input, @"\w+"))
            {
                if (wordsCount.ContainsKey(item.Value))
                {
                    wordsCount[item.Value]++;
                }
                else
                {
                    wordsCount.Add(item.Value, 1);
                }
            }

            foreach (var word in wordsCount)
            {
                Console.WriteLine("{0} - {1} times", word.Key, word.Value);
            }
        }
    }
}
