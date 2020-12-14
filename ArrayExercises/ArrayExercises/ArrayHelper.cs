using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayExercises
{
    public static class ArrayHelper
    {
        public static void Print(string label, int[] array)
        {
            string elementsLists = string.Join(",", array ?? new int[0]);
            label = label ?? "Array";
            Console.WriteLine($"{label}=[{elementsLists}]");
        }

        public static int[] BubbleSortAsc(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                return new int[0];
            }

            bool hasSwap = true;
            while (hasSwap)
            {
                hasSwap = false;
                for (int index = 0; index < array.Length - 1; index++)
                {
                    if (array[index] > array[index + 1])
                    {
                        // We need to swap!
                        int tmp = array[index];
                        array[index] = array[index + 1];
                        array[index + 1] = tmp;
                        hasSwap = true;
                        break;
                    }
                }
            }

            return array;
        }
    }
}
