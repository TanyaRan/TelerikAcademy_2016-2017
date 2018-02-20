using System;

public class TheBiggestOf3Numbers
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double max;

        if (a >= b)
        {
            if (a >= c)
            {
                max = a;
            }
            else
            {
                max = c;
            }
        }
        else
        {
            if (b >= c)
            {
                max = b;
            }
            else
            {
                max = c;
            }
        }

        Console.WriteLine(max);
    }
}
