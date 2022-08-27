/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/



using System;

namespace homework
{
    class Program
    {
        static int MaxNumArray(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int MinNumArray(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] array = { 12, 10, 2, 78, 26, 124, 3, 8, 90, 45 };
            int max = MaxNumArray(array);
            int min = MinNumArray(array);
            Console.WriteLine(max - min);

        }
    }
}
