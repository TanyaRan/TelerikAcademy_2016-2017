using System;

namespace PrintLongSequence
{
    public class Startup
    {
        public static void Main()
        {
            int member = 0;
            for (int i = 2; i < 1002; i++)
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
