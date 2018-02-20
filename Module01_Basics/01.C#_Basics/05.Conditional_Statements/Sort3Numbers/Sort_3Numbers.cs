namespace Sort3Numbers
{
    using System;

    public class Sort_3Numbers
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a < b)
            {
                a = a ^ b;
                b = a ^ b;
                a = a ^ b;
            }
            if (b < c)
            {
                if (a < c)
                {
                    a = a ^ c;
                    c = a ^ c;
                    a = a ^ c;

                    b = b ^ c;
                    c = b ^ c;
                    b = b ^ c;
                }
                else
                {
                    b = b ^ c;
                    c = b ^ c;
                    b = b ^ c;
                }
            }

            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}
