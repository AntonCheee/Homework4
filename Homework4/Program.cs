using System;

namespace Homework4
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 5);
                Console.Write(array[i] + " ");
            }

            int result = Task4(array);
            Console.WriteLine("       " + result);

            //int[] result = Task12(array);
            //for (int i = 0; i < result.Length; i++)
            //{
            //    Console.Write(result[i] + " ");
            //}
        }

        public static int Task1(int[] array)
        {
            int minElement = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (minElement > array[i])
                {
                    minElement = array[i];
                }
            }

            return minElement;
        }

        public static int Task2(int[] array)
        {
            int maxElement = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (maxElement < array[i])
                {
                    maxElement = array[i];
                }
            }

            return maxElement;
        }

        public static int Task3(int[] array)
        {
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[index] > array[i])
                {
                    index = i;
                }
            }

            return index;
        }

        public static int Task4(int[] array)
        {
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[index] < array[i])
                {
                    index = i;
                }
            }

            return index;
        }

        public static int Task5(int[] array)
        {
            int sumOddIndexElements = 0;

            for (int i = 1; i < array.Length; i += 2)
            {
                sumOddIndexElements += array[i];
            }

            return sumOddIndexElements;
        }

        public static int[] Task6(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[array.Length - 1 - i]);
            }

            return array;
        }

        public static int Task7(int[] array)
        {
            int sumOddElements = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    sumOddElements += array[i];
                }
            }

            return sumOddElements;
        }

        public static int[] Task8(int[] array)
        {
            int additional = array.Length / 2 + array.Length % 2;

            for (int i = 0; i < array.Length / 2; i++)
            {
                Swap(ref array[i], ref array[i + additional]);
            }

            return array;
        }

        public static int[] Task9(int[] array)
        {
            var minPosition = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[minPosition] > array[j])
                    {
                        minPosition = j;
                    }
                }

                Swap(ref array[i], ref array[minPosition]);

                minPosition = i + 1;
            }

            return array;
        }

        public static int[] Task10(int[] array)
        {
            for (int a = 1; a < array.Length; a++)
            {
                for (int i = a - 1; i >= 0; i--)
                {
                    if (array[a] > array[i])
                    {
                        Swap(ref array[a], ref array[i]);
                        a--;
                    }
                }
            }

            return array;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}