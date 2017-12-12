using System;

public class NumberComparer
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        double greaterNum = ((a + b) + Math.Abs(a - b)) / 2;

        Console.WriteLine(greaterNum);
    }
}
