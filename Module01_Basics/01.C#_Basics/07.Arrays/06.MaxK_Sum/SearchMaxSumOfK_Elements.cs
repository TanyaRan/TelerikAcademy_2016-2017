namespace MaxK_Sum
{
    using System;

    public class SearchMaxSumOfK_Elements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxKSum = SearchMaxK_Sum(arr, k);

            Console.WriteLine(maxKSum);
        }

        private static int SearchMaxK_Sum(int[] arr, int k)
        {
            Array.Sort(arr);

            int sum = 0;

            for (int i = arr.Length - 1; i >= arr.Length - k; i--)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
