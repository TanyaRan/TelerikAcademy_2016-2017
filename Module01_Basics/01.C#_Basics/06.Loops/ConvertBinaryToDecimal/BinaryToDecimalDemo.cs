namespace ConvertBinaryToDecimal
{
    using System;

    public class BinaryToDecimalDemo
    {
        public static void Main()
        {
            string binaryNumber = Console.ReadLine();

            int number = BinaryToDecimal(binaryNumber);
            Console.WriteLine(number);
        }

        public static int BinaryToDecimal(string binaryNumber)
        {
            int decNumber = 0;
            for (int i = 0; i < binaryNumber.Length; i++)
            {
                // start with the least significant digit -> 110001 => 11000[1-start]
                if (binaryNumber[binaryNumber.Length - i - 1] == '1')
                {
                    decNumber += (int)Math.Pow(2, i);
                }
            }
            return decNumber;
        }
    }
}
