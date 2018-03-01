namespace MatrixClass
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Matrix matrix1 = new Matrix(2, 2);
            matrix1[0, 0] = 10;
            matrix1[1, 1] = -5;
            Console.WriteLine(matrix1.ToString());

            Matrix matrix2 = new Matrix(2, 2);
            matrix2[0, 1] = -4;
            matrix2[1, 1] = 24;
            Console.WriteLine(matrix2.ToString());

            Matrix sum = matrix1 + matrix2;
            Console.WriteLine("M1+M2 ->\n" + sum.ToString());
            Matrix sub = matrix1 - matrix2;
            Console.WriteLine("M1-M2 ->\n" + sub.ToString());
            Matrix mult = matrix1 * matrix2;
            Console.WriteLine("M1*M2 ->\n" + mult.ToString());
        }
    }
}
