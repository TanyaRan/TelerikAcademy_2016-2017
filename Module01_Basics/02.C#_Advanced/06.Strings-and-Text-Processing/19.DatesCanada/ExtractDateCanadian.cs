using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace DatesCanada
{
    public class ExtractDateCanadian
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            DateTime date;
            foreach (Match item in Regex.Matches(input, @"\b\d{2}.\d{2}.\d{4}\b"))
            {
                if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
            }
        }
    }
}
