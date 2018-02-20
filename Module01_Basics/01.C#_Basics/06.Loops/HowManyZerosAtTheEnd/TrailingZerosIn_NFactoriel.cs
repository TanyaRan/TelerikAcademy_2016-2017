//NOTE(Wikipedia - Trailing zero, Factorial):
//  The number of trailing zeros in the decimal representation of n!, the factorial of a non-negative integer n, 
//  is simply the multiplicity of the prime factor 5 in n!. This can be determined with :
//  f(n) = [n/5] + [n/5^2] + ... + [n/5^k], where k must be chosen such that is 5^k <= n< 5^(k+1)
//  and [a] denotes the floor function applied to a. 
namespace HowManyZerosAtTheEnd
{
    using System;

    public class TrailingZerosIn_NFactoriel
    {
        public static void Main()
        {
            int n;
            int trailingZeros = 0;

            n = int.Parse(Console.ReadLine());

            if (n < 5)
            {
                Console.WriteLine(trailingZeros);
            }
            else
            {
                while (n >= 5)
                {
                    trailingZeros = trailingZeros + n / 5;
                    n = n / 5;
                }
                Console.WriteLine(trailingZeros);
            }
        }
    }
}
