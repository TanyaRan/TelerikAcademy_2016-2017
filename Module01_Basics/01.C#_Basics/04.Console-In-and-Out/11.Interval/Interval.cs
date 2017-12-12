using System;

public class Interval
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int amount = 0;
        for (int i = n + 1; i < m; i++)
        {
            if (i % 5 == 0)
            {
                amount++;
                i = i + 4;
            }
        }

        Console.WriteLine(amount);
    }
}
