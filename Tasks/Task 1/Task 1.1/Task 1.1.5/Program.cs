using System;

namespace Task_1._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int s=0;
            for (int i = 0; i < 1000; i++)
                if (i % 3==0 || i % 5 ==0)
                    s += i;
            Console.WriteLine($"Sum= {s}");
        }
    }
}
