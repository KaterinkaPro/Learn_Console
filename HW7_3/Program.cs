/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using System;

Console.WriteLine("Введите количество строк массива :");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива :");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];
Random random = new Random();

void FillArray(string args)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(0, 100);
            Console.Write($"[{String.Join(",", arr[i, j])}] \t");
        }
        Console.WriteLine();
    }

}
FillArray(Convert.ToString(1));


int[] summ = new int[n];
for (int j = 0; j < n; j++)
{
    for (int i = 0; i < m; i++)
    {        
        summ[j] += arr[i, j];     
    }
    Console.WriteLine();
}
Console.WriteLine();
foreach (double elem in summ)
{

    Console.Write($"{elem /m}, \t"); 
}