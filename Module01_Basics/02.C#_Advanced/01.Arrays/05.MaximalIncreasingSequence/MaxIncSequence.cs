namespace MaximalIncreasingSequence
{
    using System;

    public class MaxIncSequence
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxIncSequenceLength = SearchMaxIncSequence(arr);

            Console.WriteLine(maxIncSequenceLength);
        }

        private static int SearchMaxIncSequence(int[] arr)
        {
            int seqLength = 1;
            int bestLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    seqLength++;
                }
                else
                {
                    if (seqLength > bestLength)
                    {
                        bestLength = seqLength;
                    }

                    seqLength = 1;
                }
            }

            if (seqLength > bestLength)
            {
                bestLength = seqLength;
            }

            return bestLength;
        }
    }
}
