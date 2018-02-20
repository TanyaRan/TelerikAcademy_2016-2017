using System;

public class ExchangeNumbers
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            /*a = a ^ b; // when a and b are int
              b = a ^ b;
              a = a ^ b; */

            var temp = a;
            a = b;
            b = temp;
        }

        Console.WriteLine("{0} {1}", a, b);
    }
}