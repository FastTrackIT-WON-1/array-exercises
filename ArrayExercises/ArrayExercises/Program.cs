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
            elem curent: 7, elem urmator: 13 
            7 < 13? Da =>

            index = 1,
            elem curent: 13, elem urmator: 22 
            13 < 22? Da =>

            index = 2,
            elem curent: 22, elem urmator: 1
            22 < 1? Nu => interschimbare: 7, 13, 1, 22, 5

            index = 0,
            elem curent: 7, elem urmator: 13 
            7 < 13? Da =>
            */

            int[] sortedArrayAsc = ArrayHelper.BubbleSort(array, SortDirection.Ascending);
            int[] sortedArrayDesc = ArrayHelper.BubbleSort(array, SortDirection.Descending);

            Console.WriteLine(ReferenceEquals(sortedArrayAsc, array));
            Console.WriteLine(ReferenceEquals(sortedArrayDesc, array));


            ArrayHelper.Print("Bubble Sort (asc)", sortedArrayAsc);
            ArrayHelper.Print("Bubble Sort (desc)", sortedArrayDesc);
        }
    }
}
