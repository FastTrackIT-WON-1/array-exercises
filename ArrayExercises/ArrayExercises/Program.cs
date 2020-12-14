using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 7, 13, 22, 1, 5 };

            /*
            index = 0,
            (1 => array.Length) swap index 0 with 3: 1, 13, 22, 7, 5

            index = 1,
            (2 => array.Length) swap index 1 with 4: 1, 5, 22, 7, 13

            index = 2,
            (3 => array.Length) swap index 2 with 3: 1, 5, 7, 22, 13

            index = 3,
            (4 => array.Length) swap index  with : 1, 5, 7, 13, 22

            index 4 
            */

            // int[] sortedArrayAsc = ArrayHelper.SelectionSort(array, SortDirection.Ascending);
            // int[] sortedArrayDesc = ArrayHelper.SelectionSort(array, SortDirection.Descending);
            int[] fibo = ArrayHelper.Fibonacci(12);
            ArrayHelper.Print("Fibonacci", fibo);

            // ArrayHelper.Print("Bubble Sort (desc)", sortedArrayDesc);

            int[] primes = ArrayHelper.EratostenePrimes(120);
            ArrayHelper.Print("Prime numbers", primes);
        }
    }
}
