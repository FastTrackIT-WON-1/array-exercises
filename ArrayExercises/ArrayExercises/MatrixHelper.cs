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
    }
}
