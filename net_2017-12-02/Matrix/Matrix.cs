namespace Matrixs
{
    public class Matrix
    {

        public int[,] matrix;
        public int rows { get; }
        public int columns { get; }


        public Matrix(int rows, int columns)
        {
            if (rows < 0) throw new MatrixSizeException("Число строк не может быть меньше нуля");
            if (columns <= 0) throw new MatrixSizeException("Число столбцов должно быть положительным");

            this.rows = rows;
            this.columns = columns;
            matrix = new int[this.rows, this.columns];
        }


        public void fill(int row, int col, int element)
        {
            if (row < 0) throw new MatrixInvalidIndexException("Номер строки не мложет быть отрицательным");
            if (col < 0) throw new MatrixInvalidIndexException("Номер столбца не мложет быть отрицательным");

            matrix[row, col] = element;
        }


        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if(m1.columns != m2.columns || m1.rows != m2.rows) throw new MatrixsDifferentSizes("Матрицы разных размеров");
            Matrix m = new Matrix(m1.rows,m1.columns);
            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.columns; col++)
                {
                    m.matrix[row, col] = m1.matrix[row, col] + m2.matrix[row, col];
                }
            }
            return m;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix m = new Matrix(m1.rows, m1.columns);
            m = m1 + (m2 * -1);
            return m;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.columns != m2.rows) throw new MatrixRowsNotEqualColumnsException("Количество столбцов первой матрицы НЕ равно количеству строк второй матрицы");

            Matrix m = new Matrix(m1.rows, m2.columns);

            for (int row = 0; row < m.rows; row++)
            {
                for (int col = 0; col < m.columns; col++)
                {
                    for (int inner = 0; inner < m2.rows; inner++)
                    {
                        m.matrix[row, col] += m1.matrix[row, inner] * m2.matrix[inner, col];
                    }
                }
            }
            return m;
        }


        public static Matrix operator *(Matrix m1, int d)
        {
            Matrix m = new Matrix(m1.rows, m1.columns);
            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.columns; col++)
                {
                    m.matrix[row, col] = m1.matrix[row, col] * d;
                }
            }
            return m;
        }

        public static Matrix operator *(int d, Matrix m1)
        {
            Matrix m = new Matrix(m1.rows, m1.columns);
            m = m1 * d;
            return m;
        }
    }
}
