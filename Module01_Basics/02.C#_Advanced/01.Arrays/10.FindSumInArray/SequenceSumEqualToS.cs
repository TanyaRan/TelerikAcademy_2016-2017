namespace FindSumInArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SequenceSumEqualToS
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            List<int> arr = new List<int>(
                input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                     .Select(x => int.Parse(x)));
            int s = int.Parse(Console.ReadLine());

            int start = 0;
            int sum = 0;
            bool found = false;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                sum += arr[i];
                start = i;
                if (sum == s)
                {
                    found = true;
                    Console.WriteLine(arr[i]);
                }

                for (int j = i + 1; j < arr.Count; j++)
                {
                    sum += arr[j];
                    if (sum == s)
                    {
                        found = true;
                        for (int k = start; k <= j; k++)
                        {
                            Console.Write(arr[k] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                sum = 0;
            }

            if (!found)
            {
                Console.WriteLine("The sum does not exist in the array");
            }
        }
    }
}
