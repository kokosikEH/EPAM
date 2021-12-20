using System;

namespace Task_1._1._10
{
    class Program
    {
        static void Write(int[,] arr)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write("{0,4}", arr[i, j]);
                Console.WriteLine();

            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 5, sum = 0;
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    arr[i, j] = rnd.Next(-10, 10);
            Write(arr);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                        Console.WriteLine($"Summ({i}, {j}) = {sum}");
                    }
                }
            }
            Console.WriteLine($"Summ= {sum}");


        }
    }
}
