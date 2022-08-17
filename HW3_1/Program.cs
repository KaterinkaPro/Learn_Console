/*Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/



    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите пятизначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string? FiveDigitNumber = Convert.ToString(number);
            if (FiveDigitNumber[0] == FiveDigitNumber[4] || FiveDigitNumber[1] == FiveDigitNumber[3])
            {
                Console.WriteLine("Введённое число является палиндромом");
            }
            else
            {
                Console.WriteLine("Введённое число палидромом не являетсяю Попробуйте еще раз.");
            }
        }
    }







