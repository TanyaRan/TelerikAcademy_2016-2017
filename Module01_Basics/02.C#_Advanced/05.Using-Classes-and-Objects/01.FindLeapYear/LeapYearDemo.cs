using System;

namespace FindLeapYear
{
    public class LeapYearDemo
    {
        public static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(year);

            if (isLeap)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
