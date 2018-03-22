using System;
using System.Text;

namespace ExtractSentences
{
    public class ExtractSentencesContainingGivenWord
    {
        public static void Main()
        {
            string inputText = Console.ReadLine();
            string searchWord = Console.ReadLine();

            string sentences = SearchWordAndExtract(inputText, searchWord);

            Console.WriteLine(sentences);
        }

        private static string SearchWordAndExtract(string inputText, string searchWord)
        {
            string[] splitedText = SplitInputText(inputText);

            var sentences = new StringBuilder();

            foreach (var item in splitedText)
            {
                if (item.Contains(searchWord))
                {
                    sentences.Append(item);
                    sentences.Append(".");
                }
            }

            return sentences.ToString().Trim();
        }

        private static string[] SplitInputText(string inputText)
        {
            char[] sentenceSeparators = new char[] { '.', '!', '?' };
            string[] splitedText = inputText
                .Split(sentenceSeparators, StringSplitOptions.RemoveEmptyEntries);

            return splitedText;
        }
    }
}
