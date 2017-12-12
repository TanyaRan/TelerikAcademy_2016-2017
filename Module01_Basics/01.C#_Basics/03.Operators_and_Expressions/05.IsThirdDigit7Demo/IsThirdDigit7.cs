using System;

public class IsThirdDigit7
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        int thirdDigit = inputNumber / 100 % 10;

        if (thirdDigit == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", thirdDigit);
        }
    }
}