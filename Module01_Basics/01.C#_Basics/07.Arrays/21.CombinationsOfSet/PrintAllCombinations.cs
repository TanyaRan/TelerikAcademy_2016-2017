namespace CombinationsOfSet
{
    using System;

    public class PrintAllCombinations
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            PrintCombinations(n, k);
        }

        private static void PrintCombinations(int n, int k)
        {
            int[] combination = new int[k];

            PrintCombinations(0, n, combination);
        }

        private static void PrintCombinations(int i, int n, int[] combination)
        {
            int k = combination.Length;

            if (i == k)
            {
                Console.WriteLine("{" + string.Join(", ", combination) + "}");
                return;
            }

            var start = i == 0 ? 1 : combination[i - 1] + 1;
            // start from 1

            for (int j = start; j <= n; j++)
            {
                combination[i] = j;
                PrintCombinations(i + 1, n, combination);
            }
        }
    }
}
