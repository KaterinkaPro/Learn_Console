/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29*/
uint m = 0, n = 0;

Console.WriteLine("Введите число n: ");
n = Convert.ToUInt32(Console.ReadLine());


Console.WriteLine("Введите число m: ");
m = Convert.ToUInt32(Console.ReadLine());
Console.Clear();

static uint Akker(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akker(n - 1, 1);
    else
      return Akker(n - 1, Akker(n, m - 1));
}

Console.WriteLine(Akker(n, m));