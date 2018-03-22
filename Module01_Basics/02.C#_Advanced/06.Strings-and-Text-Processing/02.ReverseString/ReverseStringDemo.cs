using System;

namespace ReverseString
{
    public class ReverseStringDemo
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string reversed = StringReverse(input);

            Console.WriteLine(reversed);
        }

        private static string StringReverse(string input)
        {
            var arr = input.ToCharArray();
            Array.Reverse(arr);

            return string.Join("", arr);
        }
    }
}
