using System;
using System.Text;

namespace ReverseWithSb
{
    public class ReverseStringWithSb
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string reversed = StringReverse(input);

            Console.WriteLine(reversed);
        }

        private static string StringReverse(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result.Append(input[i]);
            }

            return result.ToString();
        }
    }
}
