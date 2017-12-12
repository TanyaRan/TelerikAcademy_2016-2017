using System;

public class SumOfN_Numbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x,
               sum = 0;

        for (int i = 0; i < n; i++)
        {
            x = double.Parse(Console.ReadLine());
            sum += x;
        }

        Console.WriteLine(sum);
    }
}