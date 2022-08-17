/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

class Test
{
    static void Main(string[] args)
    {
        int[] a = new int[3];             
        int[] b = new int[3];             
        double ab = 0;                     
        string koord;           




        Console.WriteLine("Введите координаты точки А (x,y,z): ");

        for (int i = 0; i < 3; i++)
        {
            koord = Console.ReadLine();
            a[i] = Convert.ToInt32(koord);
        }

         Console.WriteLine("Введите координаты точки B (x,y,z): ");

        
        for (int j = 0; j < 3; j++)
        {
            koord = Console.ReadLine();
            b[j] = Convert.ToInt32(koord);
        }
    
    ab = Math.Sqrt(Math.Pow((a[0]-b[0]),2) + Math.Pow((a[1]-b[1]),2) + Math.Pow((a[2]-b[2]),2)); 

    
    Console.WriteLine ($"Расстояние между точками: \n= {ab}" );
    
    }

}