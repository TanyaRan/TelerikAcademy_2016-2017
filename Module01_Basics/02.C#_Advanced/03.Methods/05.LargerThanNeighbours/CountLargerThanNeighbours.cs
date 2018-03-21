using System;
using System.Collections.Generic;
using System.Linq;

namespace LargerThanNeighbours
{
    public class CountLargerThanNeighbours
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var input = Console.ReadLine();

            List<int> arr = new List<int>(
                input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(x => int.Parse(x)));

            int count = 0;
            for (int i = 1; i < arr.Count - 1; i++)
            {
                if (FindIfIsLarger(arr, i))
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        private static bool FindIfIsLarger(List<int> arr, int i)
        {
            bool isLarger = false;

            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                isLarger = true;
            }

            return isLarger;
        }
    }
}
