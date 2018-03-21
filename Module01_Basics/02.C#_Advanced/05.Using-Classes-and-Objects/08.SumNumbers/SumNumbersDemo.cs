using System;
using System.Linq;

namespace SumNumbers
{
    public class SumNumbersDemo
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToList();

            int sum = numbers.Sum();

            Console.WriteLine(sum);
        }
    }
}
