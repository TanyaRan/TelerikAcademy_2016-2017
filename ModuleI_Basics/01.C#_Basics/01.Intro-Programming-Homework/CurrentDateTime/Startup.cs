using System;

namespace CurrentDateTime
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Today: {0: dd MMM yyyy}", DateTime.Now);
            Console.WriteLine("Now: {0: HH:mm}", DateTime.Now);
        }
    }
}
