using System;

namespace Task_1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write(" N= ");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 0; i <= n; i++)
            {
                int k = 2*i+1;
                for (int j = n-i; j > 0; j--)
                    Console.Write(" ");
                while (k> 0)
                {
                    Console.Write("*");
                    k--;
                }

                Console.WriteLine();
            }
        }
    }
}
