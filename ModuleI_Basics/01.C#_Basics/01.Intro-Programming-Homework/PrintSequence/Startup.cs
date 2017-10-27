using System;

namespace PrintSequence
{
    public class Startup
    {
        public static void Main()
        {
            int member = 0;
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    member = i;
                }
                else
                {
                    member = -i;
                }
                Console.WriteLine(member);
            }
        }
    }
}
