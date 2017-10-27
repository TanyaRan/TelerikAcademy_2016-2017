namespace FormatCode
{
    using System;

    public class NiceCodeNow
    {
        public static void Main()
        {
            Console.WriteLine("Hi, I am horribly formatted program");
            Console.WriteLine("Numbers and squares:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " --> " + i*i);
            }
        }
    }
}
