using System;

namespace RandomNumbersInTheRange
{
    public class GenerateRandomNumbers
    {
        public static void Main()
        {
            Random rand = new Random();
            // range is [100, 200]

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", rand.Next(100, 201));
            }
        }
    }
}
