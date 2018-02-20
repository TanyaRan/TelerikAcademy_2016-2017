namespace MinMaxSumAverage
{
    using System;

    public class MinMaxSumAverageOfSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int x = int.Parse(Console.ReadLine());

            int min, max, sum;
            min = x;
            max = x;
            sum = x;

            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x > max)
                {
                    max = x;
                }

                if (x < min)
                {
                    min = x;
                }

                sum += x;
            }

            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", sum/(double)n);
        }
    }
}
