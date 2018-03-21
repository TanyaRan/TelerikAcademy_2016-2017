using System;
using System.Text;

namespace ConvertDecimalToHexadecimal
{
    public class DecimalToHexadecimalDemo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            while (n != 0)
            {
                char digit = GetDigit(n % 16);
                sb.Insert(0, digit);

                n = n / 16;
            }

            Console.WriteLine(sb);
        }

        private static char GetDigit(int remainder)
        {
            if (remainder > 9)
            {
                return (char)('A' + remainder - 10);
            }
            else
            {
                return (char)('0' + remainder);
            }
        }
    }
}
