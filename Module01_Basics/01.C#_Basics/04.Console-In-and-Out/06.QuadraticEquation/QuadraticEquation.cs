using System;

public class QuadraticEquation
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double D = b * b - 4 * a * c;
        double x1;
        double x2;
        if (D > 0)
        {
            x1 = (-b - Math.Sqrt(D)) / (2.0 * a);
            x2 = (-b + Math.Sqrt(D)) / (2.0 * a);
            if (x1 > x2)
            {
                double temp = x1;
                x1 = x2;
                x2 = temp;
            }
            Console.WriteLine("{0:F2}", x1);
            Console.WriteLine("{0:F2}", x2);
        }
        else if (D == 0)
        {
            x1 = -b / (2.0 * a);
            x2 = x1;
            Console.WriteLine("{0:F2}", x1);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}
