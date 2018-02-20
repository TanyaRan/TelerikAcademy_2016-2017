namespace PrintMatrixOfNumbers
{
    using System;

    public class MatrixOfNumbers
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < N + 1; j++)
                {
                    Console.Write("{0,2}", i + j);
                }
                Console.WriteLine();
            }
        }
    }
}
