using System;
using System.Text;

namespace ConvertDecimalToBinary_NegativeNums
{
    public class DecimalToBinary_WithNegativeNums
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();

            if (number > 0)
            {
                while (number > 0)
                {
                    sb.Insert(0, number % 2);
                    number = number / 2;
                }
            }
            else if (number < 0)
            {
                sb.Append(1);
                int newNumber = int.MaxValue - Math.Abs(number + 1);
                int pos = 30;
                while (pos != -1)
                {
                    if ((newNumber & (1 << pos)) != 0)
                    {
                        sb = sb.Append(1);
                    }
                    else
                    {
                        sb = sb.Append(0);
                    }
                    pos--;
                }
            }
            else
            {
                sb.Append(0);
            }

            Console.WriteLine("{0}(dec)  ->  {1}(bin)", number, sb);
        }
    }
}
