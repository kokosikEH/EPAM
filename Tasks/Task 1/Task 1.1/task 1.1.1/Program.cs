using System;

namespace task_1._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the sides: ");

            Console.Write("a= ");
            int.TryParse(Console.ReadLine(), out a);

            Console.Write("b= ");
            int.TryParse(Console.ReadLine(), out b);

            if ( a > 0 && b > 0)
                Console.WriteLine($"Rectangle area= {a * b}");
            else Console.WriteLine("Error(");
        }
    }
}
