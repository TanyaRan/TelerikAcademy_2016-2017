// Calculates N!/K! for given N and K(1<K<N).

//NOTE (Wikipedia) : 
//     "The number of k-permutations of n can be written as 
//     n!/(n-k)! = n(n-1)...(n-k+1) , k<n"
//     If  n-k = x  then   n!/x! = n(n-1)...(x+2)(x+1)

namespace CalculateDivisionOfFactorials
{
    using System;
    using System.Numerics;

    public class DivisionOfFactorials
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            BigInteger factorialDivision = 1;

            for (int i = k + 1; i <= n; i++)
            {
                factorialDivision = factorialDivision * i;
            }

            Console.WriteLine(factorialDivision);
        }
    }
}
