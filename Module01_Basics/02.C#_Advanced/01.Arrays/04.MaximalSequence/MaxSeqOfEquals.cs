namespace MaximalSequence
{
    using System;

    public class MaxSeqOfEquals
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxSequenceLength = SearchMaxSequenceOfEquals(arr);

            Console.WriteLine(maxSequenceLength);
        }

        public static int SearchMaxSequenceOfEquals(int[] arr) 
        {
            int seqLength = 1;
            int bestLength = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
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
