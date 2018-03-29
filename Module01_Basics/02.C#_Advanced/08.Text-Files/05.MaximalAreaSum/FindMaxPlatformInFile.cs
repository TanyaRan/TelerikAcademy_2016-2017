using System;
using System.IO;

namespace MaximalAreaSum
{
    public class FindMaxPlatformInFile
    {
        public static void Main()
        {
            StreamReader reader = new StreamReader("matrixFile.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int matrixSize = int.Parse(line);

                int[,] matrix = new int[matrixSize, matrixSize];

                for (int row = 0; row < matrixSize; row++)
                {
                    line = reader.ReadLine();
                    string[] temp = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int col = 0; col < matrixSize; col++)
                    {
                        matrix[row, col] = int.Parse(temp[col]);
                    }
                }

                // Find the maximal sum of platform of size 2 x 2
                int bestSum = int.MinValue;
                int bestRow = 0;
                int bestCol = 0;

                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        int sum = matrix[row, col] + matrix[row, col + 1] +
                            matrix[row + 1, col] + matrix[row + 1, col + 1];

                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestRow = row;
                            bestCol = col;
                        }
                    }
                }

                StreamWriter writer = new StreamWriter("maxSum.txt");
                using (writer)
                {
                    writer.Write(bestSum);
                }
            }
        }
    }
}
