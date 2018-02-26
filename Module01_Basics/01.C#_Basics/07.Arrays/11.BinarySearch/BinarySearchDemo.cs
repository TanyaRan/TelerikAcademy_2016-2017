namespace BinarySearch
{
    using System;

    public class BinarySearchDemo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int numberToFind = int.Parse(Console.ReadLine());

            int start = 0;
            int end = arr.Length - 1;
            int middle;
            bool found = false;

            while (start <= end)
            {
                middle = (start + end) / 2;

                if (arr[middle] == numberToFind)
                {
                    Console.WriteLine(middle);
                    found = true;
                    break;
                }

                if (arr[middle] < numberToFind)
                {
                    start = middle + 1;
                }

                if (arr[middle] > numberToFind)
                {
                    end = middle - 1;
                }
            }

            if (!found)
            {
                Console.WriteLine(-1);
            }
        }
    }
}
