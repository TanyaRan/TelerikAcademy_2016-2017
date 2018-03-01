namespace PrimeNumbers
{
    using System;

    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            bool[] notPrime = new bool[n + 1];

            notPrime[0] = true;
            notPrime[1] = true;

            for (int i = 2; i < notPrime.Length; i++)
            {
                if (!notPrime[i])
                {
                    for (int j = 2; i * j < notPrime.Length; j++)
                    {
                        notPrime[i * j] = true;
                    }
                }
            }

            int lastPrime = Array.LastIndexOf(notPrime, false);

            Console.WriteLine(lastPrime);
        }
    }
}
