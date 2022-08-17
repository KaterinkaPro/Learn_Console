/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

class program
{
    static int Numb(int value)
    {
        if (value<10)
        return value;
        int digit = value %10;
        int nextValue = value / 10;

        return digit + Numb(nextValue);
    }
        static void Main(string[] args)
        {
           Console.Write($"Give me your number! - ");
            int MyValue = Convert.ToInt32(Console.ReadLine());
            int result = Numb(MyValue);
            Console.WriteLine ($"Сумма введенных цифр: - {result}");
        }
}