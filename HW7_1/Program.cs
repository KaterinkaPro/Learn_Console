/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

using System;

Console.WriteLine("Введите количество строк  :");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов  :");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m,n];
Random random = new Random();

void FillArray(string args)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = new Random().Next(-100,100);
            Console.Write($"[{String.Join(",", arr[i,j])}] +\t");
        }
        Console.WriteLine();
    }

}
FillArray(Convert.ToString(1));