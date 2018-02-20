namespace CalculatePowerSeries
{
    using System;

    public class PowerSeries
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int x = int.Parse(Console.ReadLine());

            decimal member = (decimal)1.0 / x;
            decimal sum;
            sum = 1 + member;

            for (int i = 2; i < n + 1; i++)
            {
                member = (member * i) / x;
                sum = sum + member;
            }

            Console.WriteLine("{0:F5}", sum);
        }
    }
}
