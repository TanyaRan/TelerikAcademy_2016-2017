using System;

public class OddOrEvenInteger
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        if ((inputNumber & 1) == 0)
        {
            Console.WriteLine("even {0}", inputNumber);
        }
        else
        {
            Console.WriteLine("odd {0}", inputNumber);
        }
    }
}