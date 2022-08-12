/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.Write($"Ожидается ввод числа: ");
int num = Convert.ToInt32(Console.ReadLine());

int a = Math.Abs(num);
string stringNum = Convert.ToString(a);

if (stringNum.Length < 3)
{
    Console.WriteLine("Введенное число меньше трехзначного");
}
else
{
    Console.WriteLine("Третья цифра: " + stringNum[2]);
}
