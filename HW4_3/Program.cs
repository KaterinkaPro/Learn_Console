/*Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

class program
{
    static void WriteArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }



    static void Main(string[] args)
    {
        int[] array = new int[0];
        Console.Write($"Ожидается ввод чисел: \nпо окончанию введите end:");
        while (true)
        {

            string meaning = Console.ReadLine();
            if (meaning != "end")
            {
                int number = Convert.ToInt32(meaning);
                int[] NewArray = array;
                array = new int[array.Length + 1];
                for (int i = 0; i < NewArray.Length; i++)
                {
                    array[i] = NewArray[i];
                }
                array[array.Length - 1] = number;
            }

            else
            {
                break;
            }

        }
        WriteArray(array);
    }


}

