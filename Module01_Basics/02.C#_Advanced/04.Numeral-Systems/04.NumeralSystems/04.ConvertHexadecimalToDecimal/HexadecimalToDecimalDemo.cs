using System;

namespace ConvertHexadecimalToDecimal
{
    public class HexadecimalToDecimalDemo
    {
        public static void Main()
        {
            string hexNumber = Console.ReadLine();
            hexNumber = hexNumber.ToUpper();

            int number = HexadecimalToDecimal(hexNumber);

            Console.WriteLine(number);
        }

        private static int HexadecimalToDecimal(string hexNumber)
        {
            int decNumber = 0;
            int power;

            for (int i = 0; i < hexNumber.Length; i++)
            {
                // start with the least significant digit
                int digit = GetNumber(hexNumber[hexNumber.Length - i - 1]);
                if (digit == 0)
                {
                    continue;
                }

                power = (int)Math.Pow(16, i);
                decNumber += power * digit;
            }

            return decNumber;
        }

        private static int GetNumber(char hexDigit)
        {
            if (hexDigit >= 'A')
            {
                return hexDigit - 'A' + 10; // 'F' - 'A' + 10 = 15 !
            }
            else
            {
                return hexDigit - '0'; // '1' - '0' = 1 !
            }
        }
    }
}
