using System;
using System.Globalization;

namespace DaysBetween
{
    public class CalculateDaysBetween
    {
        public static void Main()
        {
            Console.Write("Enter the first date(dd.MM.yyyy): ");
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Console.Write("Enter the second date(dd.MM.yyyy): ");
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            TimeSpan tSpan = new TimeSpan();

            tSpan = firstDate - secondDate;
            int daysCount = Math.Abs(tSpan.Days);

            Console.WriteLine("Distance: {0} days", daysCount);
        }
    }
}
