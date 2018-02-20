namespace SpiralMatrix
{
    using System;

    public class PrintSpiralMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] table = new int[n, n];

            int num = 1;
            int x = 0;
            int y = 0;
            int max = n;
            int row, col;

            while (num <= max * max)
            {
                row = x; col = y;
                while (col < n)
                {
                    table[row, col] = num;
                    num++;
                    col++;
                }
                row++; col--;

                while (row < n)
                {
                    table[row, col] = num;
                    num++;
                    row++;
                }
                row--; col--;

                while (col >= y)
                {
                    table[row, col] = num;
                    num++;
                    col--;
                }
                row--; col++;

                while (row >= x + 1)
                {
                    table[row, col] = num;
                    num++;
                    row--;
                }
                x++; y++;
                n--;
            }

            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    Console.Write("{0,3}", table[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
