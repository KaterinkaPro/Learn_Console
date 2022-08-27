/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

using System;
class program
{
    public static void Main(string[] args)
    {
        int min = 100, max = 999, j = 0;
        Console.Clear();
        Console.WriteLine("Введите количество элементов массива :");
        string longMassiv = Console.ReadLine();
        int count = Convert.ToInt32(longMassiv);
        int[] Array = new int[count];
        Console.Clear();
        Console.Write($"Массив из случайных чисел, от 0 до {count} элементов :");
       
        for(int i = 0; i < count; i++)
        {
            
            Array[i] = new Random().Next(min, max);
                       
            Console.Write($"{Array[i]} , ");

            if(Array[i] % 2 == 0)                
            {
            j++;
            }
        }
        Console.WriteLine ($"Количество четных чисел в массиве : {j}");
        
       
        
    

    }
}
