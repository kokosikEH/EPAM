using System;

namespace Task_1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            Random rnd = new Random();
            int n = rnd.Next(10, 20);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(-100, 100);
            Console.WriteLine("Array: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{arr[i]} ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                if (arr[i] > 0) t += arr[i];
            Console.WriteLine($"Summ= {t}");
        }
    }
}
