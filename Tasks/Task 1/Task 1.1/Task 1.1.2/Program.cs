using System;

namespace Task_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write(" N= ");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 1; i <= n; i++)
            {
                int k = i;
                while(k>0)
                {
                    Console.Write("*");
                    k--; 
                }
                Console.WriteLine();
            }
        }
    }
}
