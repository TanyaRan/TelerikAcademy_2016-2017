using System;
using System.Text;

namespace ReverseNumber
{
    public class ReverseNumberDemo
    {
        public static void Main()
        {
            string number = Console.ReadLine();

            string reversed = ReverseDigits(number);

            Console.WriteLine(reversed);
        }

        private static string ReverseDigits(string number)
        {
            StringBuilder reversedNumber = new StringBuilder();
            char[] digits = number.ToCharArray();

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                reversedNumber.Append(digits[i]);
            }

            return reversedNumber.ToString();
        }
    }
}
