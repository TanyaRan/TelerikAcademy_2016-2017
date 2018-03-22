using System;

namespace UnicodeCharacters
{
    public class StringToUnicodeLiterals
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (var symbol in input)
            {
                Console.Write("\\u{0:X4}", (int)symbol);
            }

            Console.WriteLine();
        }
    }
}
