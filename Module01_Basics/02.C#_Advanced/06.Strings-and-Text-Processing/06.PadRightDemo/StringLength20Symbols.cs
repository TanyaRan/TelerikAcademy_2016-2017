using System;

namespace PadRightDemo
{
    public class StringLength20Symbols
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int length = input.Length;

            Console.WriteLine(input.PadRight(20, '*'));
        }
    }
}
