using System;

// 13.Write a program that safely compares two floating-point numbers(double) with precision eps = 0.000001.

// Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point 
// arithmetic.Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

public class FloatsCompare
{
    public static void Main()
    {
        double a = double.Parse(Console.ReadLine()); // 1.123123
        double b = double.Parse(Console.ReadLine()); // 1.12312399999(true) or 1.123124(false)
        float precision = 0.000001f;

        bool areEqual = Math.Abs(a - b) < precision;

        Console.WriteLine(areEqual);
    }
}