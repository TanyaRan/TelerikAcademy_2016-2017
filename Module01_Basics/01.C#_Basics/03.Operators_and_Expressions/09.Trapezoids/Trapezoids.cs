using System;

public class Trapezoids
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine()),
               b = double.Parse(Console.ReadLine()),
               h = double.Parse(Console.ReadLine());

        double trapezoidArea = (a + b) * h / 2;

        Console.WriteLine("{0:f7}", trapezoidArea);
    }
}