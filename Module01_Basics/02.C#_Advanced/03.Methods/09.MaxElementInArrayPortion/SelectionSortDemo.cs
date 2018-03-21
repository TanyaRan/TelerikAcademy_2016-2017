using System;
using System.Linq;

namespace MaxElementInArrayPortion
{
    public class SelectionSortDemo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = (Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray());

            SortAscending(arr);
            // SortDescending(arr);

            Console.WriteLine(string.Join(" ", arr.Select(el => el.ToString())));
        }

        private static int FindMaxInPortion(int[] inputArray, int startIndex)
        {
            int maxElement = inputArray[startIndex];
            int maxIndex = startIndex;
            for (int i = startIndex + 1; i < inputArray.Length; i++)
            {
                if (maxElement < inputArray[i])
                {
                    maxElement = inputArray[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private static int FindMinInPortion(int[] inputArray, int startIndex)
        {
            int minElement = inputArray[startIndex];
            int minIndex = startIndex;
            for (int i = startIndex + 1; i < inputArray.Length; i++)
            {
                if (minElement > inputArray[i])
                {
                    minElement = inputArray[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        private static void SortDescending(int[] inputArray)
        {
            int index = -1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                index = FindMaxInPortion(inputArray, i);
                if (index != i)
                {
                    int temp = inputArray[i];
                    inputArray[i] = inputArray[index];
                    inputArray[index] = temp;
                }
            }
        }

        private static void SortAscending(int[] inputArray)
        {
            int index = -1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                index = FindMinInPortion(inputArray, i);
                if (index != i)
                {
                    int temp = inputArray[i];
                    inputArray[i] = inputArray[index];
                    inputArray[index] = temp;
                }
            }
        }
    }
}
