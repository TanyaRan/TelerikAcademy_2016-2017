using System;
using System.Collections.Generic;

namespace Workdays
{
    public class CalculateWorkdays
    {
        public static void Main()
        {
            DateTime today = DateTime.Today;
            int y = today.Year;

            string finalDayAsString = Console.ReadLine();
            DateTime finalDay = DateTime.Parse(finalDayAsString);

            int AllDaysBetween = (finalDay - today).Days;
            int countWorkingDays = 0;

            var holidays = new List<DateTime>();
            holidays.Add(new DateTime(y, 01, 01));
            holidays.Add(new DateTime(y, 01, 02));
            holidays.Add(new DateTime(y, 03, 03));
            holidays.Add(new DateTime(y, 05, 01));
            holidays.Add(new DateTime(y, 05, 06));
            holidays.Add(new DateTime(y, 05, 24));
            holidays.Add(new DateTime(y, 09, 06));
            holidays.Add(new DateTime(y, 09, 22));
            holidays.Add(new DateTime(y, 12, 24));
            holidays.Add(new DateTime(y, 12, 25));
            holidays.Add(new DateTime(y, 12, 26));
            holidays.Add(new DateTime(y, 12, 31));

            for (int i = 0; i < AllDaysBetween; i++)
            {
                if (today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)
                {
                    today = today.AddDays(i);
                    continue;
                }

                foreach (var item in holidays)
                {
                    if (today == item)
                    {
                        continue;
                    }

                }

                countWorkingDays++;
                today = today.AddDays(i);
            }

            Console.WriteLine("Working days: " + countWorkingDays);
        }
    }
}
