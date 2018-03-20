using System;

namespace LastDigitAsWord
{
    public class EnglishDigit
    {

        public static void Main()
        {
            int x = int.Parse(Console.ReadLine());

            string lastDigitString = ReturnLastDigit(x);

            Console.WriteLine(lastDigitString);
        }

        private static string ReturnLastDigit(int x)
        {
            string digitName = "";
            int lastDigit = Math.Abs(x) % 10;
            //If number is negative - remainder is negative too.

            switch (lastDigit)
            {
                case 0:
                    digitName = "zero";
                    break;
                case 1:
                    digitName = "one";
                    break;
                case 2:
                    digitName = "two";
                    break;
                case 3:
                    digitName = "three";
                    break;
                case 4:
                    digitName = "four";
                    break;
                case 5:
                    digitName = "five";
                    break;
                case 6:
                    digitName = "six";
                    break;
                case 7:
                    digitName = "seven";
                    break;
                case 8:
                    digitName = "eight";
                    break;
                case 9:
                    digitName = "nine";
                    break;
            }

            return digitName;
        }
    }
}
