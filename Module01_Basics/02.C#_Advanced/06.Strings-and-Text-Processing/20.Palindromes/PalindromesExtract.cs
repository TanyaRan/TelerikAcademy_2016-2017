using System;
using System.Text.RegularExpressions;

namespace Palindromes
{
    public class PalindromesExtract
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            foreach (Match item in Regex.Matches(input, @"\w+"))
            {
                if (IsPalindrome(item.Value))
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
