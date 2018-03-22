using System;

namespace SubstringInText
{
    public class CountSubstringInText
    {
        public static void Main()
        {
            string searchSubstring = Console.ReadLine();
            string inputText = Console.ReadLine();

            int count = SearchSubstringCount(inputText, searchSubstring);

            Console.WriteLine(count);
        }

        private static int SearchSubstringCount(string inputText, string searchSubstring)
        {
            int firstPos = -1;
            int lastPos = inputText.LastIndexOf(searchSubstring, StringComparison.CurrentCultureIgnoreCase);
            // case insensitive serch !
            int count = 0;

            while (firstPos < lastPos)
            {
                firstPos = inputText.IndexOf(
                    searchSubstring, firstPos + 1, 
                    StringComparison.CurrentCultureIgnoreCase);

                count++;
            }

            return count;
        }
    }
}
