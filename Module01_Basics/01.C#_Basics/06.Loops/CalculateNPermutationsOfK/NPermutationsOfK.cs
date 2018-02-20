// Calculate N!/ (K!* (K-N)!) where (1<K<N<100)

//NOTE (Wikipedia) : 
//     "The number of k-permutations of n can be written as 
//     n!/(n-k)! = n(n-1)...(n-k+1) , k<n"
namespace CalculateNPermutationsOfK
{
    using System;
    using System.Numerics;

    public class NPermutationsOfK
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger factorialDivision = 1;
            for (int i = n - k + 1; i <= n; i++)
            {
                factorialDivision = factorialDivision * i;
            }

            BigInteger factorialK = 1;
            for (int j = 1; j <= k; j++)
            {
                factorialK = factorialK * j;
            }

            Console.WriteLine(factorialDivision/ factorialK);
        }
    }
}
