using System;
using System.Text;

namespace Convert16BitsSignedIntToBinary
{
    public class ShortToBinary
    {
        public static void Main()
        {
            short number = short.Parse(Console.ReadLine());

            string binaryNum = ShortDecimalToBinary(number);

            Console.WriteLine(binaryNum);
        }

        private static string ShortDecimalToBinary(short number)
        {
            StringBuilder sb = new StringBuilder();

            if (number > 0)
            {
                while (number > 0)
                {
                    sb.Insert(0, number % 2);
                    number = (short)(number / 2);
                }

                string all16digits = sb.ToString().PadLeft(16, '0');
                sb.Clear();
                sb.Append(all16digits);
            }
            else if (number < 0)
            {
                sb.Append(1);
                int newNumber = int.MaxValue - Math.Abs(number + 1);
                int pos = 14;
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
                sb.Append("".PadLeft(16, '0'));
            }

            return sb.ToString();
        }
    }
}
