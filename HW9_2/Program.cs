/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30*/


int m = 0, n = 0;

Console.WriteLine("Введите число m: ");
m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите число n: ");
n = Convert.ToInt32(Console.ReadLine());
Console.Clear();


int Summ (int m, int n)
{
    if (n == 0) return 0;

    else 
    {
        return n + Summ (m, n - 1);
    }
}

Console.Write($"Сумма чисел от {m} до {n} = ");
Console.Write(Summ (m,n));
