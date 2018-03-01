namespace MatrixClass
{
    using System.Text;

    public class Matrix
    {
        private int[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.matrix = new int[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.matrix.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return this.matrix.GetLength(1);
            }
        }

        // indexer
        public int this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, first.Cols);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Cols; col++)
                {
                    result[row, col] = first[row, col] + second[row, col];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, first.Cols);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < first.Cols; col++)
                {
                    result[row, col] = first[row, col] - second[row, col];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            Matrix result = new Matrix(first.Rows, second.Cols);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Cols; col++)
                {
                    for (int k = 0; k < first.Rows; k++)
                    {
                        result[row, col] = first[row, k] * second[k, col];
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(matrix[row, col] + " ");
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
