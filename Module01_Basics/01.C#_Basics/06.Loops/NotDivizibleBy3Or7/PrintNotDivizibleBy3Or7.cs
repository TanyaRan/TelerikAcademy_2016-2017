namespace NotDivizibleBy3Or7
{
    using System;

    public class PrintNotDivizibleBy3Or7
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            //  !((i % 3 == 0) || (i % 7 == 0)) = (i % 3 != 0) && (i % 7 != 0), De Morgan
            for (int i = 1; i < n + 1; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                    Console.Write("{0} ", i);
            }
        }
    }
}
