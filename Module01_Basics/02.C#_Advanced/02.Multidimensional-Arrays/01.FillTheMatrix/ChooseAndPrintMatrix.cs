namespace FillTheMatrix
{
    using System;

    public class ChooseAndPrintMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrixArr = new int[n, n];

            string variant = Console.ReadLine();

            switch (variant)
            {
                case "a":
                    FillMatrixByColumn(n, matrixArr);
                    break;
                case "b":
                    FillMatrixChainByColumn(n, matrixArr);
                    break;
                case "c":
                    FillMatrixDiagonally(n, matrixArr);
                    break;
                case "d":
                    FillMatrixSpiral(n, matrixArr);
                    break;
                default:
                    break;
            }
        }

        private static void FillMatrixByColumn(int n, int[,] matrixArr)
        {
            int x = 1;

            //fill matrix
            for (int cols = 0; cols < n; cols++)
            {
                for (int rows = 0; rows < n; rows++)
                {
                    matrixArr[rows, cols] = x;
                    x++;
                }
            }

            PrintMatrix(matrixArr);
        }

        private static void FillMatrixChainByColumn(int n, int[,] matrixArr)
        {
            int x = 1;

            //fill matrix
            for (int cols = 0; cols < n; cols++)
            {
                for (int rows = 0; rows < n; rows++)
                {
                    if (cols % 2 == 0)
                    {
                        matrixArr[rows, cols] = x;
                    }
                    else
                    {
                        matrixArr[n - rows - 1, cols] = x;
                    }

                    x++;
                }
            }

            PrintMatrix(matrixArr);
        }

        private static void FillMatrixDiagonally(int n, int[,] matrixArr)
        {
            int x = 1;

            //fill matrix
            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col < n - row; col++)
                {
                    matrixArr[row + col, col] = x++;
                }
            }
            for (int col = 1; col < n; col++)
            {
                for (int row = 0; row < n - col; row++)
                {
                    matrixArr[row, col + row] = x++;
                }
            }

            PrintMatrix(matrixArr);
        }

        private static void FillMatrixSpiral(int n, int[,] matrixArr)
        {
            int x = 1;
            int maxX = n * n;

            //fill matrix
            int direction = 1;
            int currentRow = -1;
            int currentCol = 0;
            int size = n;

            while (x <= maxX)
            {
                for (int row = 0; row < size; row++)
                {
                    currentRow = currentRow + direction;
                    matrixArr[currentRow, currentCol] = x;
                    x++;
                }
                size--;

                for (int col = 0; col < size; col++)
                {
                    currentCol = currentCol + direction;
                    matrixArr[currentRow, currentCol] = x;
                    x++;
                }
                direction = direction * (-1);
            }

            PrintMatrix(matrixArr);
        }

        private static void PrintMatrix(int[,] matrixArr)
        {
            for (int rows = 0; rows < matrixArr.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrixArr.GetLength(1); cols++)
                {
                    Console.Write("{0, -5}", matrixArr[rows, cols]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
