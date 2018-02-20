//    Cn = (2n)!/((n+1)!*n!) = ((n+n)!/(n+1)!)/n! = (n+n)(n+n-1)...(n+3)(n+2)/n(n-1)...3*2*1
//    or the member of sequence is n+i/i , i=2..n
namespace CalculateNthCatalanNumber
{
    using System;
    using System.Numerics;

    public class NthCatalanNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger NthCatalanNumber = 1;
            BigInteger member = 1;

            if (n == 0 || n == 1)
            {
                Console.WriteLine(NthCatalanNumber);
            }
            else
            {
                BigInteger factorialN = 1;
                for (int j = 2; j <= n; j++)
                {
                    factorialN = factorialN * j;
                }

                for (int i = 2; i < n + 1; i++)
                {
                    member *= (n + i);
                }

                Console.WriteLine(member/factorialN);
            }
        }
    }
}
