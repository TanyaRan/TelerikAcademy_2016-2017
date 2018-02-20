using System;

public class TheBiggestOf_5Numbers
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double max = FindMax(a, b);
        max = FindMax(max, c);
        max = FindMax(max, d);
        max = FindMax(max, e);

        Console.WriteLine(max);
    }

    private static double FindMax(double x, double y)
    {
        if (x >= y)
        {
            return x;
        }

        return y;
    }
}