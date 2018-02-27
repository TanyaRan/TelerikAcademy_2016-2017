namespace SubsetKWithSumS
{
    using System;

    public class SubsetKWithSumSDemo
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int k = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            int checks = (int)Math.Pow(2, n);
            bool findSum = false;

            for (int i = 1; i < checks; i++)
            {
                string mask = Convert.ToString(i, 2).PadLeft(n, '0');
                int count = CountOnes(mask);

                if (count == k)
                {
                    int combinationSum = 0;

                    for (int j = 0; j < n; j++)
                    {
                        int charValue = Convert.ToInt32(char.GetNumericValue(mask[j]));
                        combinationSum += charValue * arr[j];
                    }

                    if (s == combinationSum)
                    {
                        Console.WriteLine("yes");
                        findSum = true;
                        break;
                    }
                }
            }

            if (!findSum)
            {
                Console.WriteLine("no");
            }
        }

        private static int CountOnes(string mask)
        {
            int count = 0;
            foreach (var x in mask)
            {
                if (x == '1')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
