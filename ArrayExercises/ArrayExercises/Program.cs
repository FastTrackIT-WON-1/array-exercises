using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = MatrixHelper.ReadMatrix();
            MatrixHelper.Print("Matrix:", matrix);
        }
    }
}
