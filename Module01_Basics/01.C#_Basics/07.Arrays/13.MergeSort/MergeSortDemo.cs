namespace MergeSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MergeSortDemo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> arr = new List<int>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(int.Parse(Console.ReadLine()));
            }

            List<int> sorted = MergeSort(arr);

            foreach (var x in sorted)
            {
                Console.WriteLine(x);
            }
        }

        private static List<int> MergeSort(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = arr.Count / 2;

            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(arr[i]);
            }
            for (int i = middle; i < arr.Count; i++)
            {
                right.Add(arr[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }

            return result;
        }
    }
}
