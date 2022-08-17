class Test
{
    static void Main(string[] args)
    {
        Console.Write($"Insert random number:");
        int N = Convert.ToInt32(Console.ReadLine());
        int[] cube = new int[N + 1];
        Console.Write($"Insert second random number");
        int b = Convert.ToInt32(Console.ReadLine()); // степень, в которую возводим
          
        double sum = 0;
        
          sum = Convert.ToInt32(Math.Pow(N, b));
          Console.Write($"Результат вычислений: \n{N} возведенное в степень {b} ровняется {sum}");
    } 
   
}
