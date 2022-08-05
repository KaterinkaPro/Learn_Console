/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int a = Convert. ToInt32(Console.ReadLine());
int b = Convert. ToInt32(Console.ReadLine());
int max = a;
{
    if(a<b)
    {
        Console.Write("Большее число - ");
        Console.WriteLine(b);
         Console.Write("Меньшее число - ");
        Console.Write(a);
       
    }
else
    if(a>b)
    {
        Console.Write("Большее число - ");
        Console.WriteLine(a);
        Console.Write("Меньшее число - ");
        Console.Write(b);
       
    }
}
