/*Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21*/


using System;
Console.Write("Введите эл-ты массива через пробел: ");
string elements = Console.ReadLine();                               // 1. Ввод элементов массива, через пробел
int[] baseArray = GetArrayFromString(elements);                     // 7. записали полученный, с помощью функции GetArrayFromString, массив, в массив baseArray

Console.WriteLine(String.Join(" ", ResultArray(baseArray)));          // 15. выведет массив baseArrey на печать через пробел

int[] GetArrayFromString(string stringArray)                                             // 2. функция принимает строку чисел, а отдает целочисленный массив из чисел
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);       // 3. Разбивает, введенную через пробелы строку чисел, в массив 
    int[] res = new int[nums.Length];                                                     // 4. создаем массив res такой же длинны, как и масси nums

    for (int i = 0; i < nums.Length; i++)                                                 // 5. заполняем масси res числами из массива nums
    {
        res[i] = int.Parse(nums[i]);                                                      // 6. с помощью int.Parse (аналог Convert.ToInt32) преобразуем числа массива в integer
    }
    return res;
}

int[] ResultArray(int[] array)
{
    int size = array.Length / 2;                                                         // 8. делим размер массива на 2
    if(array.Length % 2 == 1) size++;                                                    // 9. если длинна массива не четная, добавляем в массив один элемент
    int[] result = new int[size];                                                        // 10. создаем массив result, длинной size
    for (int i = 0; i < array.Length / 2; i++)                                           // 11. пробегаем по массиву, умножая перый и последний л-т массива друг на друга, 
    {
        result[i] = array[i] * array[array.Length - 1 - i];                              // 12. продвигаясь к середине массива
    }
    if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];                 // 13. если массив содержал не четное кол-во эл-тов, 
    return result;                                                                       // 14. то последнее значение станоится равным последнему оставшемуся элементу
}