using System;
using System.Text;

namespace ConvertDecimalToBinary
{
    public class DecimalToBinary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            while (number > 0)
            {
                sb.Insert(0, number % 2); // at position 0
                number = number / 2;
            }

            Console.WriteLine(sb);
        }
    }
}
