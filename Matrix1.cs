using System;

namespace Assignment4
{
    /// <summary>
    /// The Matrix class
    /// </summary>
    class Matrix
    {
        private int[,] matrix;
        private int rows { get; }
        private int columns { get; }

        /// <summary>
        /// Creates the matrix with given number of rows and columns
        /// </summary>
        /// <param name="rows"> Number of rows </param>
        /// <param name="columns"> Number of columns </param>
        public Matrix(int rows, int columns)
        {
            matrix = new int[rows, columns];
            Random random = new Random();
            for(int i = 0; i < rows; ++i)
            {
                for(int j = 0; j < columns; ++j)
                {
                    matrix[i, j] = random.Next(100);
                }
            }
        }

        /// <summary>
        /// Adds matrices
        /// </summary>
        /// <param name="matrix"> Operand </param>
        /// <returns> Sum if two martices</returns>
        public void addition(Matrix matrix)
        {
            if (this.rows == matrix.rows && this.columns == matrix.columns)
            {
                for (int i = 0; i < rows; ++i)
                {
                    for (int j = 0; j < columns; ++j)
                    {
                        this.matrix[i, j] += matrix.matrix[i, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("Your matrices must have an equal number of rows and columns");
            }
        }

        /// <summary>
        /// Multiplies martices
        /// </summary>
        /// <param name="matrix"> Operand </param>
        /// <returns> Multiplication of two matrices </returns>
        public void multiplication(Matrix matrix)
        {
            if (this.columns == matrix.rows)
            {
                for (int i = 0; i < rows; ++i)
                {
                    for (int j = 0; j < columns; ++j)
                    {
                        this.matrix[i, j] *= matrix.matrix[i, j];
                    }
                }
            }
            else
            {
                Console.WriteLine("For multiply your first matrix's columns number and second matrix rows number must be the same.");
            }
        }

        /// <summary>
        /// Scalar multiplies matrices
        /// </summary>
        /// <param name="num"> Operand </param>
        /// <returns> Scalar multiplication of the number and the matrix </returns>
        public void scalarMultiplication(int num)
        {
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    matrix[i, j] *= num;
                }
            }
        }

        /// <summary>
        /// Inverse the matrix
        /// </summary>
        public void inverse()
        {

        }

        /// <summary>
        /// Transpose the matrix
        /// </summary>
        public Matrix transpose()
        {
            Matrix transposeMatrix = new Matrix(this.columns, this.rows);
            int temp = 0;

            for (int i = 0; i < transposeMatrix.rows; ++i)
            {
                for (int j = 0; j < transposeMatrix.columns; ++j)
                {

                    transposeMatrix.[i, j] = matrix[j, i];
                }
            }

            return transposeMatrix;
        }

        /// <summary>
        /// Determine whether a matrix is orthogonal or not
        /// </summary>
        /// <returns></returns>
        public bool isOrthogonal()
        {
            Matrix identityMatrix = new Matrix(rows, rows);
            multiplication(this.transpose());
            return this.equals(identityMatrix);
        }

        /// <summary>
        /// Checks matrix equality
        /// </summary>
        /// <param name="matrix"> Operand </param>
        /// <returns> </returns>
        public bool equals(Matrix matrix)
        {
            if (this.rows != matrix.rows || this.columns != matrix.columns)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < rows; ++i)
                {
                    for (int j = 0; j < columns; ++j)
                    {
                        if (this.matrix[i, j] != matrix.matrix[i, j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Finds smallest element of matrix
        /// </summary>
        /// <returns> Smallest element </returns>
        public int smallestElement()
        {
            int smallest = matrix[0, 0];

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    if (matrix[i, j] <= smallest)
                    {
                        smallest = matrix[i, j];
                    }
                }
            }
            return smallest;
        }

        /// <summary>
        /// Finds the largest element of matrix
        /// </summary>
        /// <returns> The largest element </returns>
        public int largestElement()
        {
            int largest = matrix[0, 0];

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    if (matrix[i, j] >= largest)
                    {
                        largest = matrix[i, j];
                    }
                }
            }
            return largest;
        }


        public void printMatrix()
        {
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    Console.Write(matrix[i, j] + " ");
                    if (j == columns - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
