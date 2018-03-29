using System;
using System.Collections.Generic;

namespace EnterNumbers
{
    public class EnterNumbersDemo
    {
        public static void Main()
        {
            const int START = 1;
            const int END = 100;

            List<int> nums = new List<int>();

            try
            {
                int number = ReadNumber(START, END);
                nums.Add(number);

                for (int i = 1; i < 10; i++)
                {
                    number = ReadNumber(number, END);
                    nums.Add(number);
                }

                string numsSequence = string.Join(" < ", nums);
                Console.WriteLine($"{START} < {numsSequence} < {END}");
            }
            catch (Exception ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static int ReadNumber(int start, int end)
        {
            int number;
            bool result = int.TryParse(Console.ReadLine(), out number);

            if (number < start || number > end || !result)
            {
                throw new Exception("Exception");
            }

            return number;
        }
    }
}
