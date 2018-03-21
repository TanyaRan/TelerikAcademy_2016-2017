using System;

namespace DayOfWeek
{
    public class DayOfWeekPrint
    {
        public static void Main()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("Today , {0}, is {1}", today, today.DayOfWeek);
        }
    }
}
