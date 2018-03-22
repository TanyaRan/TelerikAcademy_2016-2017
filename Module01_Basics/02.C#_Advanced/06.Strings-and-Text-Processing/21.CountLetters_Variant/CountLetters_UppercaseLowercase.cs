using System;
using System.Linq;

namespace CountLetters_Variant
{
    public class CountLetters_UppercaseLowercase
    {
        public static void Main()
        {
            string letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

            string input = Console.ReadLine();

            for (int i = 0; i < letters.Length; i++)
            {
                int count = input.Count(c => c == letters[i]);

                if (count > 0)
                {
                    Console.WriteLine("{0}: {1}", letters[i], count);
                }
            }
        }
    }
}
