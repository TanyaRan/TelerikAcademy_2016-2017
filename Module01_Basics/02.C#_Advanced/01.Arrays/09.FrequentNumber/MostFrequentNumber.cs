namespace FrequentNumber
{
    using System;

    public class MostFrequentNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            int bestNumber = arr[0];
            int currentLength = 1;
            int bestLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestNumber = arr[i - 1];
                    }

                    currentLength = 1;
                }
            }

            if (currentLength > bestLength)
            {
                bestLength = currentLength;
                bestNumber = arr[arr.Length - 1];
            }

            Console.WriteLine("{0} ({1} times)", bestNumber, bestLength);
        }
    }
}
