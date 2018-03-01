namespace MaximalSum
{
    using System;

    public class Platform3x3WithMaxSum
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(matrixSize[0]);
            int m = int.Parse(matrixSize[1]);

            int[,] rectArray = FillMatrix(n, m);

            // int k = int.Parse(Console.ReadLine());
            int k = 3;

            int maxSum = FindMaxSumPlatformKxK(rectArray, k);
            Console.WriteLine(maxSum);
        }

        private static int FindMaxSumPlatformKxK(int[,] rectArray, int k)
        {
            int bestSum = int.MinValue;
            for (int row = 0; row < rectArray.GetLength(0) - k + 1; row++)
            {
                for (int col = 0; col < rectArray.GetLength(1) - k + 1; col++)
                {
                    int sumPlatform = 0;
                    for (int platformRow = row; platformRow < row + k; platformRow++)
                    {
                        for (int platformCol = col; platformCol < col + k; platformCol++)
                        {
                            sumPlatform += rectArray[platformRow, platformCol];
                        }
                    }

                    if (sumPlatform > bestSum)
                    {
                        bestSum = sumPlatform;
                    }
                }
            }

            return bestSum;
        }

        private static int[,] FillMatrix(int n, int m)
        {
            int[,] rectArray = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                var rowNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < m; col++)
                {
                    rectArray[row, col] = int.Parse(rowNumbers[col]);
                }
            }

            return rectArray;
        }
    }
}
