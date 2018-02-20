namespace UsingSelectionSort
{
    using System;

    public class SelectionSortDemo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] sortedArray = SelectionSortAlgo(arr);

            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
        }

        private static int[] SelectionSortAlgo(int[] arr)
        {
            // "Selection sort" algorithm:
            //   Find the smallest element, swap it with element at the first position, 
            // find the smallest from the rest, move it at the second position, etc.

            for (int sortedSize = 0; sortedSize < arr.Length; sortedSize++)
            {
                int minIndex = sortedSize;

                for (int j = sortedSize + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[sortedSize];
                arr[sortedSize] = arr[minIndex];
                arr[minIndex] = temp;
            }

            return arr;
        }
    }
}
