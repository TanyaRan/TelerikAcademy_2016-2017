namespace LargestAreaInMatrix
{
    using System;

    public class LargestAreaOfEqualNeighbours
    {
        public static bool[,] visited;
        public static int[,] matrix;

        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(matrixSize[0]);
            int m = int.Parse(matrixSize[1]);

            matrix = FillMatrix(n, m);
            visited = new bool[n, m];

            int result = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    result = Math.Max(result, DepthFirstSearch(row, col, matrix[row, col]));
                }
            }

            Console.WriteLine(result);
        }

        private static int DepthFirstSearch(int row, int col, int value)
        {
            if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
            {
                return 0;
            }

            if (visited[row, col] == true)
            {
                return 0;
            }

            if (matrix[row, col] != value)
            {
                return 0;
            }

            visited[row, col] = true;

            return DepthFirstSearch(row, col + 1, value) + 
                   DepthFirstSearch(row, col - 1, value) +
                   DepthFirstSearch(row + 1, col, value) + 
                   DepthFirstSearch(row - 1, col, value) + 1;
        }

        private static int[,] FillMatrix(int n, int m)
        {
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                var rowNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = int.Parse(rowNumbers[col]);
                }
            }

            return matrix;
        }
    }
}
