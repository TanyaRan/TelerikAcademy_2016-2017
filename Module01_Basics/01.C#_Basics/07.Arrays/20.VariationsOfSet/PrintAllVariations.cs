namespace VariationsOfSet
{
    using System;

    public class PrintAllVariations
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            PrintVariations(n, k);
        }

        private static void PrintVariations(int n, int k)
        {
            int[] variation = new int[k];
            bool[] used = new bool[n];

            PrintVariations(0, variation, used);
        }

        private static void PrintVariations(int i, int[] variation, bool[] used)
        {
            int n = used.Length;
            int k = variation.Length;

            if (i == k)
            {
                Console.WriteLine("{" + string.Join(", ", variation) + "}");
                return;
            }

            for (int j = 0; j < n; j++)
            {
                if (used[j])
                {
                    continue;
                }

                variation[i] = j + 1;
                used[j] = true;
                PrintVariations(i + 1, variation, used);
                used[j] = false; // important !!!
            }
        }
    }
}
