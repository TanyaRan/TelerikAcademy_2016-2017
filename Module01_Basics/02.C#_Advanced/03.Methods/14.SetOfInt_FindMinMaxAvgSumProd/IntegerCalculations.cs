using System;
using System.Linq;
using System.Numerics;

namespace SetOfInt_FindMinMaxAvgSumProd
{
    public class IntegerCalculations
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            int[] arr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => int.Parse(x)).ToArray();

            Console.WriteLine(ArrayMin(arr));
            Console.WriteLine(ArrayMax(arr));
            Console.WriteLine("{0:F2}", ArrayAverage(arr));
            Console.WriteLine(ArraySum(arr));
            Console.WriteLine(ArrayProduct(arr));
        }

        private static int ArrayMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }

        private static int ArrayMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }

        private static double ArrayAverage(int[] arr)
        {
            double sum = ArraySum(arr);
            int len = arr.Length;

            return sum / len;
        }

        private static long ArraySum(int[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        private static BigInteger ArrayProduct(int[] arr)
        {
            BigInteger prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                prod *= arr[i];
            }

            return prod;
        }
    }
}
