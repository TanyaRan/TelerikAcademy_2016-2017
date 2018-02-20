namespace NumbersFrom1ToN
{
    using System;

    public class PrintNumbersFrom1ToN
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n + 1; i++)
            {
                Console.Write("{0} ", i);
                if (i % 10 == 0)
                    Console.WriteLine();
            }
        }
    }
}
