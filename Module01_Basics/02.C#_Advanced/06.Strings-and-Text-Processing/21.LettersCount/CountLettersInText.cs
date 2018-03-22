using System;

namespace LettersCount
{
    public class CountLettersInText
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int[] values = new int[26]; // alphabet

            foreach (char ch in input.ToLower())
            {
                if ('a' <= ch && ch <= 'z')
                {
                    values[ch - 'a']++; // 'a' -> values[0]
                }
            }

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != 0)
                {
                    Console.WriteLine("{0}: {1}", (char)(i + 'a'), values[i]);
                }
            }
        }
    }
}
