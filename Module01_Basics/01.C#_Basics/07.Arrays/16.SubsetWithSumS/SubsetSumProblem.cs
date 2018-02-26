namespace SubsetWithSumS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SubsetSumProblem
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            List<int> arr = new List<int>(
                input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(x => int.Parse(x)));

            int sum = int.Parse(Console.ReadLine());
            int n = arr.Count;

            int checks = (int)Math.Pow(2, n);
            bool findSum = false;

            for (int i = 1; i < checks; i++)
            {
                string mask = Convert.ToString(i, 2).PadLeft(n, '0');
                int combinationSum = 0;

                for (int j = 0; j < n; j++)
                {
                    int charValue = Convert.ToInt32(char.GetNumericValue(mask[j]));
                    combinationSum += charValue * arr[j];
                }

                if (sum == combinationSum)
                {
                    Console.WriteLine("yes");
                    findSum = true;
                    break;
                }

            }

            if (!findSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
