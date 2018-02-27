namespace RemoveElementsFromArray
{
    using System;
    using System.Collections.Generic;

    public class RemoveMinElementsToSort
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int count = (int)Math.Pow(2, n);

            int maxCounterOfTakenElements = 0;
            List<int> checker = new List<int>();
            List<int> result = new List<int>();

            for (int i = 1; i < count; i++)
            {
                bool isSorted = true;
                checker.Clear();

                for (int j = 0; j < arr.Length; j++)
                {
                    // checks if take a number
                    if ((i >> j & 1) == 1)
                    {
                        checker.Add(arr[j]);
                    }
                }

                // if checker isSorted
                for (int k = 0; k < checker.Count; k++)
                {
                    if (k != 0 && k == checker.Count - 1 && checker[k - 1] > checker[k])
                    {
                        isSorted = false;
                        break;
                    }

                    if (k != checker.Count - 1 && checker[k] > checker[k + 1])
                    {
                        isSorted = false;
                        break;
                    }
                }

                // if current sequence is bigger than the best
                if (isSorted == true && maxCounterOfTakenElements < checker.Count)
                {
                    maxCounterOfTakenElements = checker.Count;
                    result.Clear();
                    result.AddRange(checker);
                }
            }

            Console.WriteLine(n - result.Count);
            // Console.WriteLine(string.Join(" ", result));
        }
    }
}
