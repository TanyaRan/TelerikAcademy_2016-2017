namespace MaximalSum
{
    using System;

    public class MaxSumOfSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = FindMaxSum(arr);

            Console.WriteLine(maxSum);
        }

        private static int FindMaxSum(int[] arr)
        {
            int bestSum = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = 0;

                for (int j = i; j < arr.Length; j++)
                {
                    currentSum += arr[j];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }

            return bestSum;
        }
    }
}
