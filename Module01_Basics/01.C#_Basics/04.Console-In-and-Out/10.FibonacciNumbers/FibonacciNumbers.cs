using System;

public class FibonacciNumbers
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long first = 0;
        long second = 1;
        long result;

        if (n == 1)
        {
            Console.WriteLine(first);
        }
        else if (n == 2)
        {
            Console.Write(first + ", ");
            Console.WriteLine(second);
        }
        else if (n > 2)
        {
            Console.Write("{0}, {1}", first, second);

            for (int i = 3; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;
                Console.Write(", {0}", second);
            }
            Console.WriteLine();
        }
    }
}