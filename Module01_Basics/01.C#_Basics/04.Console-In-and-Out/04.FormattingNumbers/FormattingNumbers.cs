using System;

public class FormattingNumbers
{
    public static void Main()
    {
        //input
        Console.Write("Enter an integer a (0 <= a <= 500), a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter a real number, b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a real number, c = ");
        double c = double.Parse(Console.ReadLine());

        //print
        Console.Write("|{0,-10:X}|", a);
        Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write("|{0,10:F2}|", b);
        Console.Write("{0,-10:F3}|", c);
    }
}
