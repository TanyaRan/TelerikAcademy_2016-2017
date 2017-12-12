using System;

public class PointInACircle
{
    public static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(x * x + y * y);
        bool insideCircle = (x * x + y * y) <= (2 * 2);

        if (insideCircle)
        {
            Console.WriteLine("yes {0:f2}", distance);
        }
        else
        {
            Console.WriteLine("no {0:f2}", distance);
        }
    }
}