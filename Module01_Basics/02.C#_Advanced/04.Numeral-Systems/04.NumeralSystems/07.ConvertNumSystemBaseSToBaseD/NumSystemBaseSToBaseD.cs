using System;
using System.Text;

namespace ConvertNumSystemBaseSToBaseD
{
    public class NumSystemBaseSToBaseD
    {
        public static void Main()
        {
            string inputNum = Console.ReadLine();

            int baseS = int.Parse(Console.ReadLine());
            int baseD = int.Parse(Console.ReadLine());

            int decimalNum = ConvertBaseSToBase10(inputNum, baseS);
            string numberBaseD = ConvertBase10ToBaseD(decimalNum, baseD);

            Console.WriteLine(numberBaseD);
        }        

        private static int ConvertBaseSToBase10(string inputNum, int baseS)
        {
            int decNumber = 0;
            int power;

            for (int i = 0; i < inputNum.Length; i++)
            {
                // start with the least significant digit
                int digit = GetNumber(inputNum[inputNum.Length - i - 1]);
                if (digit == 0)
                {
                    continue;
                }

                power = (int)Math.Pow(baseS, i);
                decNumber += power * digit;
            }

            return decNumber;
        }

        private static string ConvertBase10ToBaseD(int decimalNum, int baseD)
        {
            StringBuilder sb = new StringBuilder();

            while (decimalNum != 0)
            {
                char digit = GetDigit(decimalNum % baseD);
                sb.Insert(0, digit);

                decimalNum = decimalNum / baseD;
            }

            return sb.ToString();
        }

        private static int GetNumber(char symbol)
        {
            if (symbol >= 'A')
            {
                return symbol - 'A' + 10; // 'F' - 'A' + 10 = 15 !
            }
            else
            {
                return symbol - '0'; // '1' - '0' = 1 !
            }
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
