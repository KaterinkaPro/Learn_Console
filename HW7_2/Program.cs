/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;

Console.WriteLine("Введите количество строк массива :");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива :");
int n = Convert.ToInt32(Console.ReadLine());

int[,] a = new int[m,n];
Random random = new Random();

void FillArray(string args)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i,j] = new Random().Next(0,100);
            Console.Write($"[{String.Join(",", a[i,j])}]");
        }
        Console.WriteLine();
    }

}
FillArray(Convert.ToString(1));

Console.WriteLine("Введите искомую строку элемента массива :");
int str = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомый стролбец элемента массива :");
int column = Convert.ToInt32(Console.ReadLine());
if (str > m && column > n) Console.WriteLine ("Такого элемента массива не существует");
else
{
    Console.WriteLine($"Искомый элемент массива {a[str - 1,column - 1]}");
}