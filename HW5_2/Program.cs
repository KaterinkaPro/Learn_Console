/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

class Test
{
    static void Main(string[] args)
    {
        int min = 1, max = 999, j = 0;
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

            if(i % 2 != 0)                
            {
            j = j + Array[i];
            }
        }
        Console.WriteLine();
        Console.WriteLine ($"Сумма нечетных элементов массива : \n{j}");
        
    }
}