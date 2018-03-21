using System;
using System.Collections.Generic;
using System.Linq;

namespace GetLargestNumber
{
    public class GetLargestDemo
    {        
        public static void Main()
        {
            var input = Console.ReadLine();

            List<int> arr = new List<int>(
                input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(x => int.Parse(x)));

            int max;
            max = GetMax(arr[0], arr[1]);
            max = GetMax(max, arr[2]);

            Console.WriteLine(max);
        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
