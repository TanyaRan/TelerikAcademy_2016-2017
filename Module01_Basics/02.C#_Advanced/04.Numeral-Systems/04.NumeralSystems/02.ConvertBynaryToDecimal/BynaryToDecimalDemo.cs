using System;

namespace ConvertBynaryToDecimal
{
    public class BynaryToDecimalDemo
    {
        public static void Main()
        {            
            string binaryNumber = Console.ReadLine();

            int number = BinaryToDecimal(binaryNumber);

            Console.WriteLine(number);
        }

        private static int BinaryToDecimal(string binaryNumber)
        {
            int decNumber = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                // start with the least significant digit
                if (binaryNumber[binaryNumber.Length - i - 1] == '0')
                {
                    continue;
                }

                decNumber += (int)Math.Pow(2, i);
            }

            return decNumber;
        }
    }
}
