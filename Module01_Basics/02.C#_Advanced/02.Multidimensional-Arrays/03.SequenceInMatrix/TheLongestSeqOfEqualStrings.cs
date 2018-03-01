namespace SequenceInMatrix
{
    using System;

    public class TheLongestSeqOfEqualStrings
    {
        public static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(matrixSize[0]);
            int m = int.Parse(matrixSize[1]);

            string[,] rectArray = FillMatrix(n, m);

            int maxSeqLength = FindTheLongestSeqOfEqualStrings(rectArray);

            Console.WriteLine(maxSeqLength);
        }

        private static int FindTheLongestSeqOfEqualStrings(string[,] rectArray)
        {
            int maxSeqLength = 0;
            int tempLength = 0;

            for (int row = 0; row < rectArray.GetLength(0); row++)
            {
                for (int col = 0; col < rectArray.GetLength(1); col++)
                {
                    string current = rectArray[row, col]; //start counting from current string

                    int currentRowCount = FindThread(rectArray, row, col, 0);
                    int currentDiagRightCount = FindThread(rectArray, row, col, 1);
                    int currentColCount = FindThread(rectArray, row, col, 2);
                    int currentDiagLeftCount = FindThread(rectArray, row, col, 3);

                    tempLength = Math.Max(Math.Max(currentRowCount, currentColCount), Math.Max(currentDiagLeftCount, currentDiagRightCount));

                    if (tempLength > maxSeqLength)
                    {
                        maxSeqLength = tempLength;
                    }
                }
            }

            return maxSeqLength;
        }

        private static int FindThread(string[,] rectArray, int startRow, int startCol, int direction)
        {
            int count = -1;
            string current = rectArray[startRow, startCol];
            
            if (direction == 0)
            {
                //Search in row -> direction 0: row = const, col++
                count = 1;
                for (int col = startCol + 1; col < rectArray.GetLength(1); col++)
                {
                    if (rectArray[startRow, col] == current)
                    {
                        count++;
                    }
                    else
                    {
                        return count;
                    }
                }
            }
            else if (direction == 1)
            {
                //Search in diagonal-right -> direction 1: col++ row++
                count = 1;

                while (startRow < (rectArray.GetLength(0) - 1) && startCol < (rectArray.GetLength(1) - 1))
                {
                    if (rectArray[startRow + 1, startCol + 1] == current)
                    {
                        count++;
                        startRow++;
                        startCol++;
                    }
                    else
                    {
                        return count;
                    }
                }
            }
            else if (direction == 2)
            {
                //Search in column -> direction 2: col = const, row++
                count = 1;
                for (int row = startRow + 1; row < rectArray.GetLength(0); row++)
                {
                    if (rectArray[row, startCol] == current)
                    {
                        count++;
                    }
                    else
                    {
                        return count;
                    }
                }
            }
            else if (direction == 3)
            {
                //Search in diagonal-left -> direction 3: col-- row++
                count = 1;
                while (startRow < (rectArray.GetLength(0) - 1) && startCol > 0)
                {
                    if (rectArray[startRow + 1, startCol - 1] == current)
                    {
                        count++;
                        startRow++;
                        startCol--;
                    }
                    else
                    {
                        return count;
                    }
                }
            }

            return count;
        }

        private static string[,] FillMatrix(int n, int m)
        {
            string[,] rectArray = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                var rowElements = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < m; col++)
                {
                    rectArray[row, col] = rowElements[col];
                }
            }

            return rectArray;
        }

    }
}
