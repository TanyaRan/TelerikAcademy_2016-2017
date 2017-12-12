using System;

public class PrimeNumberCheck
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = false;

        if (n > 1)
        {
            isPrime = ((n % 2 > 0) && (n % 3 > 0) && (n % 5 > 0) && (n % 7 > 0))
            || ((n == 2) || (n == 3) || (n == 5) || (n == 7));
        }

        if (isPrime)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}