using System;

namespace Task_1._1._4
{
    class Program
    {
        static void Triangle(int k, int n)
        {
                for (int i = 0; i <= k; i++)
                {
                    int m = 2 * i + 1;
                    for (int j = n - i; j > 0; j--)
                        Console.Write(" ");
                    while (m > 0)
                    {
                        Console.Write("*");
                        m--;
                    }

                    Console.WriteLine();
                }
            }

        
        static void Main(string[] args)
        {
            int n;
            Console.Write(" N= ");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 0; i <= n; i++)
                Triangle(i, n );
        }
    }
}
