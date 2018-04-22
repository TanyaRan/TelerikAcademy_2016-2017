using System;

namespace DefineMatrix
{
    public class MatrixStartup
    {
        public static void Main()
        {
            Matrix<int> matrixTestOne = new Matrix<int>(3, 3);
            Matrix<int> matrixTestTwo = new Matrix<int>(3, 3);
            Console.WriteLine("Test matrix -> rols*cols = {0}*{0}", matrixTestOne.Cols);

            matrixTestOne[0, 0] = 21;
            matrixTestTwo[0, 0] = 3;
            Console.WriteLine("matrixTestOne[0, 0] = 21; matrixTestTwo[0, 0] = 3;");

            matrixTestOne[2, 1] = -3;
            matrixTestTwo[2, 1] = -17;
            Console.WriteLine("matrixTestOne[2, 1] = -3; matrixTestTwo[2, 1] = -17;");
            Console.WriteLine("Sum matrix :");
            Console.WriteLine(matrixTestOne + matrixTestTwo);
        }
    }
}
