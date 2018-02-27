namespace PermutationsOfSet
{
    using System;

    public class PrintAllPermutations
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintPermutations(n);
        }

        private static void PrintPermutations(int n)
        {
            int[] permutation = new int[n];
            bool[] used = new bool[n];

            PrintPermutations(0, permutation, used);
        }

        private static void PrintPermutations(int i, int[] permutation, bool[] used)
        {
            int n = permutation.Length;

            if (i == n)
            {
                Console.WriteLine("{" + string.Join(", ", permutation)+ "}");
                return;
            }

            for (int j = 0; j < n; j++)
            {
                if (used[j])
                {
                    continue;
                }

                permutation[i] = j + 1;

                used[j] = true;
                PrintPermutations(i + 1, permutation, used);
                used[j] = false;
            }
        }
    }
}
