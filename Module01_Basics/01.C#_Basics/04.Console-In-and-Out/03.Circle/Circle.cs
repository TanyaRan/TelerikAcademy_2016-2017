using System;

public class Circle
{
    public static void Main()
    {
        double r = double.Parse(Console.ReadLine());

        double perimeter = Math.PI * 2 * r;
        double area = Math.PI * r * r;

        Console.WriteLine("{0:F2} {1:F2}", perimeter, area);
    }
}