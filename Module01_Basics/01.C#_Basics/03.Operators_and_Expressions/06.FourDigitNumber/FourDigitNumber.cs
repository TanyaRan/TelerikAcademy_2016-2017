using System;

public class FourDigitNumber
{
    public static void Main()
    {
        int x = int.Parse(Console.ReadLine());

        int first = x % 10,
           second = x / 10 % 10,
           third = x / 100 % 10,
           fourth = x / 1000;

        int sum = first + second + third + fourth,
            exchangedX = first + third * 10 + second * 100 + fourth * 1000;

        string reverse = first.ToString() + second + third + fourth,
               lastIsFirst = first.ToString() + fourth + third + second;

        Console.WriteLine(sum);
        Console.WriteLine(reverse);
        Console.WriteLine(lastIsFirst);
        Console.WriteLine(exchangedX);
    }
}