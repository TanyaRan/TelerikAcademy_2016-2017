using System;

namespace Age
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Please, write your birthday in format MM.DD.YYYY :");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - birthday.Year;
            DateTime newBirthday = birthday.AddYears(age);
            if (newBirthday > DateTime.Now)
            {
                age = age - 1;
            }

            Console.WriteLine($"Now: {age}-years old.");
            Console.WriteLine($"After 10 years: {age + 10}-years old.");
        }
    }
}
