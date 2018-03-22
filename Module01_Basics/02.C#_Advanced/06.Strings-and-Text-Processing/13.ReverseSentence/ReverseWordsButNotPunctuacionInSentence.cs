using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReverseSentence
{
    public class ReverseWordsButNotPunctuacionInSentence
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string regex = @"\s+|,\s*|\.\s*|!\s*|\?\s*";
            var words = new Stack<string>(); // Stack
            var separators = new List<string>(); // like Queue

            foreach (string word in Regex.Split(input, regex))
            {
                words.Push(word);
            }
            words.Pop(); // one empty string -> remove

            foreach (Match sign in Regex.Matches(input, regex))
            {
                separators.Add(sign.Value);
            }

            for (int i = 0; i < separators.Count; i++)
            {
                Console.Write(words.Pop() + separators[i]);
            }

            Console.WriteLine();
        }
    }
}
