using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumberAppearanceInArray
{
    public class AppearanceCount
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var inputArr = Console.ReadLine();

            List<int> arr = new List<int>(
                inputArr.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(el => int.Parse(el)));

            int x = int.Parse(Console.ReadLine());

            int count = CountNumberAppearance(arr, x);

            Console.WriteLine(count);
        }

        private static int CountNumberAppearance(List<int> arr, int x)
        {
            int count = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
