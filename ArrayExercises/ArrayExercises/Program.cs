using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = MatrixHelper.ReadMatrix();
            MatrixHelper.Print("Matrix1:", matrix1);

            int[,] matrix2 = MatrixHelper.ReadMatrix();
            MatrixHelper.Print("Matrix2:", matrix2);

            int[,] prod = MatrixHelper.Product(matrix1, matrix2);
            MatrixHelper.Print("Product Matrix:", prod);
        }
    }
}
