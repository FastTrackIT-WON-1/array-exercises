using System;

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

        public static int[] Clone(int[] array)
        {
            if (array is null || array.Length == 0)
            {
                return new int[0];
            }

            int[] result = new int[array.Length];
            for (int index = 0; index < result.Length; index++)
            {
                result[index] = array[index];
            }

            return result;
        }

        public static int[] BubbleSort(int[] array, SortDirection sort)
        {
            int[] result = Clone(array);

            bool hasSwap = true;
            while (hasSwap)
            {
                hasSwap = false;
                for (int index = 0; index < result.Length - 1; index++)
                {
                    bool isSwapNeeded;
                    switch (sort)
                    {
                        case SortDirection.Descending:
                            isSwapNeeded = result[index] < result[index + 1];
                            break;

                        case SortDirection.Ascending:
                        default:
                            isSwapNeeded = result[index] > result[index + 1];
                            break;
                    }

                    if (isSwapNeeded)
                    {
                        // We need to swap!
                        int tmp = result[index];
                        result[index] = result[index + 1];
                        result[index + 1] = tmp;
                        hasSwap = true;
                        break;
                    }
                }
            }

            return result;
        }

        public static int[] SelectionSort(int[] array, SortDirection sort)
        {
            int[] result = Clone(array);

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    bool isSwapNeeded;
                    switch (sort)
                    {
                        case SortDirection.Descending:
                            isSwapNeeded = result[i] < result[j];
                            break;

                        case SortDirection.Ascending:
                        default:
                            isSwapNeeded = result[i] > result[j];
                            break;
                    }

                    if (isSwapNeeded)
                    {
                        int temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;
        }

        public static int[] Fibonacci(int n)
        {
            if (n < 0)
            {
                return new int[0];
            }

            if (n == 0)
            {
                return new int[] { 0 };
            }

            if (n == 1)
            {
                return new int[] { 0, 1 };
            }

            int[] fibo = new int[n + 1];
            fibo[0] = 0;
            fibo[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }

            return fibo;
        }

        public static int[] EratostenePrimes(int n)
        {
            if (n <= 1)
            {
                return new int[0];
            }

            bool[] primes = new bool[n + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            int countPrimes = 0;
            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    countPrimes++;

                    for (int factor = 2; i * factor <= n; factor++)
                    {
                        primes[i * factor] = false;
                    }
                }
            }

            int[] result = new int[countPrimes];
            for (int i = 2, j = 0; i <= n; i++)
            {
                if (primes[i])
                {
                    result[j] = i;
                    j++;
                }
            }

            return result;
        }
    }
}
