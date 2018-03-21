using System;

namespace SayHello
{
    public class Program
    {
        public static void Main()
        {
            PrintUserName();
        }

        private static void PrintUserName()
        {
            Console.Write("Enter your name :");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
