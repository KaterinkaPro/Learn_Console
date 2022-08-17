/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

class Test
{
    static void Main(string[] args)
    {
        Console.Write($"Insert random number:");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] cube = new int[N + 1];
        int b = 3; // степень, в которую возводим
         Console.Write($"Числа возведённые в третью степень от одного до {N} : ");
        for(int i  = 1; i <= N; i++)
        {
           cube[i] = Convert.ToInt32(Math.Pow(i, b));
            Console.Write($"{cube[i]}, ");
        }
    }
}
