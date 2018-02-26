namespace QuickSort
{
    using System;

    public class QuickSortDemo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Quick_Sort(arr, 0, arr.Length - 1);

            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
        }

        private static void Quick_Sort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivot = Partition(arr, left, right);

            Quick_Sort(arr, left, pivot - 1);
            Quick_Sort(arr, pivot + 1, right);

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int temp;
            int marker = left;//divides left and right subarrays

            for (int i = left; i <= right; i++)
            {
                if (arr[i] < arr[right]) //array[end] is pivot
                {
                    temp = arr[marker]; // swap
                    arr[marker] = arr[i];
                    arr[i] = temp;

                    marker += 1;
                }
            }

            //put pivot(array[end]) between left and right subarrays
            temp = arr[marker];
            arr[marker] = arr[right];
            arr[right] = temp;

            return marker;
        }
    }
}
