using System;

namespace Generics_FindMinMaxAvgSumProd
{
    public class GenericsCalculations
    {
        public static void Main()
        {
            decimal[] arr = new decimal[] { 8.33m, 15.34m, 54.23m, 23.56m };

            Console.WriteLine(ArrayMin(arr));
            Console.WriteLine(ArrayMax(arr));
            Console.WriteLine("{0:F2}", ArrayAverage(arr));
            Console.WriteLine(ArraySum(arr));
            Console.WriteLine(ArrayProduct(arr));

            byte[] digits = new byte[] { 1, 9, 5, 7, 6, 2 };
            // byteSum and byteProduct -> problem

            Console.WriteLine(ArrayMin(digits));
            Console.WriteLine(ArrayMax(digits));
            Console.WriteLine("{0:F2}", ArrayAverage(digits));
            Console.WriteLine(ArraySum(digits));
            Console.WriteLine(ArrayProduct(digits));
        }

        private static T ArrayMin<T>(T[] arr)
        {
            dynamic min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }

        private static T ArrayMax<T>(T[] arr)
        {
            dynamic max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }

        private static decimal ArrayAverage<T>(T[] arr)
        {
            decimal sum = ArraySum(arr);
            decimal result = sum / arr.Length;

            return result;
        }

        private static decimal ArraySum<T>(T[] arr)
        {
            dynamic sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        private static decimal ArrayProduct<T>(T[] arr)
        {
            dynamic prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                prod *= arr[i];
            }

            return prod;
        }
    }
}
