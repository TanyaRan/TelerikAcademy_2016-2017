namespace HexToDecimalConvert
{
    using System;

    public class ConvertHexadecimalToDecimal
    {
        public static void Main()
        {
            string hexadecimalNumber = Console.ReadLine();
            hexadecimalNumber = hexadecimalNumber.ToUpper();

            int number = HexadecimalToDecimal(hexadecimalNumber);

            Console.WriteLine(number);
        }

        public static int HexadecimalToDecimal(string hexadecimalNumber)
        {
            int decNumber = 0;

            for (int i = 0; i < hexadecimalNumber.Length; i++)
            {
                // start with the least significant digit
                char digitChar = hexadecimalNumber[hexadecimalNumber.Length - i - 1];
                int digit = 0;
                switch (digitChar)
                {
                    case '0':
                        continue;
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        digit = (int)(digitChar) - 48;
                        break;
                    case 'A':
                        digit = 10;
                        break;
                    case 'B':
                        digit = 11;
                        break;
                    case 'C':
                        digit = 12;
                        break;
                    case 'D':
                        digit = 13;
                        break;
                    case 'E':
                        digit = 14;
                        break;
                    case 'F':
                        digit = 15;
                        break;
                }
                decNumber += digit * (int)Math.Pow(16, i);
            }

            return decNumber;
        }
    }
}
