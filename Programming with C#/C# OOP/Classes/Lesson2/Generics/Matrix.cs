namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public struct Matrix<T>
    {

        public int GetRows
        {
            get { return this.myMatrix.GetLength(0); }
        }
        public int GetCols
        {
            get { return this.myMatrix.GetLength(1); }
        }

        public Matrix(int rows, int cols)
        {
            this.myMatrix = new T[rows, cols];
        }

        private T[,] myMatrix;

        public T this[int row, int col]
        {
            get { return this.myMatrix[row, col]; }
            set { this.myMatrix[row, col] = value; }
        }
        public static Matrix<T> operator +(Matrix<T> one, Matrix<T> two)
        {
            int newRows = one.getRows + two.getRows;
            int newCols = one.getCols + two.getCols;

            return new Matrix<T>(newRows, newCols);
        }
    }
}
