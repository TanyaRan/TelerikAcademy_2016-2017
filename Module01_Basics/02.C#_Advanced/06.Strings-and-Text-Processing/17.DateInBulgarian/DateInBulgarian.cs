using System;
using System.Globalization;
using System.Threading;

namespace DateInBulgarian
{
    public class DateInBulgarian
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.Write("Enter date and time(day.month.year hour:minute:second): ");

            DateTime inputDate = DateTime.Parse(Console.ReadLine());
            DateTime outputDate = inputDate.AddHours(6.5);

            Console.WriteLine("After 6h 30m: {0}", outputDate);
            Console.WriteLine("Day of week: {0}", DateTimeFormatInfo.CurrentInfo.GetDayName(outputDate.DayOfWeek).ToUpper());
        }
    }
}
