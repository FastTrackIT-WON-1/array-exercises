using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    public static class MatrixHelper
    {
        public static int[,] ReadMatrix()
        {
            int rows = Utils.ReadNumber("Number of rows=");
            int cols = Utils.ReadNumber("Number of cols=");

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Utils.ReadNumber($"elem[{i},{j}]=");
                }
            }

            return matrix;
        }

        public static void Print(string label, int[,] matrix)
        {
            if (matrix is null)
            {
                return;
            }

            int consoleWidth = Console.WindowWidth;

            Console.WriteLine(new string('-', consoleWidth - 1));
            Console.WriteLine(label);
            Console.WriteLine(new string('-', consoleWidth - 1));

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j], 6}");
                }

                Console.WriteLine();
            }
        }

        public static void PrintMainDiagonal(int[,] matrix)
        {
            if (matrix is null)
            {
                return;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int minRowsOrCols = Math.Min(rows, cols);

            Console.WriteLine();
            Console.Write("Main Diagonal: [");
            for (int i = 0; i < minRowsOrCols; i++)
            {
                Console.Write(matrix[i, i]);

                if(i < minRowsOrCols - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.Write("]");
        }

        public static int[,] Sum(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1 is null && matrix2 is null)
            {
                return new int[0, 0];
            }

            int rows1 = matrix1?.GetLength(0) ?? matrix2?.GetLength(0) ?? 0;
            int cols1 = matrix1?.GetLength(1) ?? matrix2?.GetLength(1) ?? 0;

            int rows2 = matrix2?.GetLength(0) ?? matrix1?.GetLength(0) ?? 0;
            int cols2 = matrix2?.GetLength(1) ?? matrix1?.GetLength(1) ?? 0;

            if(rows1 != rows2 || cols1 != cols2)
            {
                Console.WriteLine("Cannot sum the two matrices!");
                return null;
            }

            int[,] result = new int[rows1, cols1];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    result[i, j] = matrix1?[i, j] ?? 0 + matrix2?[i, j] ?? 0;
                }
            }

            return result;
        }

        public static int[,] Product(int[,] matrix1, int[,] matrix2)
        {
            if (matrix1 is null || matrix2 is null)
            {
                return new int[0, 0];
            }

            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);

            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != rows2)
            {
                Console.WriteLine("Cannot calculate the product of the two matrices!");
                return null;
            }

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < rows2; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }

                    result[i, j] = sum;
                }
            }

            return result;
        }
    }
}
