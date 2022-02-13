using System;
using System.Collections.Generic;

namespace task_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество участников: ");
            int N = ReadInt();
            Console.Write("Введите, какой по счету человек будет вычеркнут каждый раунд: ");
            int excludeStep = ReadInt();

            var list = new List<int>();
            for (int i = 0; i < N; i++)
            {
                list.Add(i + 1);
            }
            Console.WriteLine($"Сгенерирован круг людей. Начинаем вычеркивать каждого {excludeStep}");
            int k = 0;
            while (N >= excludeStep)
            {
                list.Remove(excludeStep);
                N -= 1;
                k++;
                Console.WriteLine($"Раунд {k}. Вычеркнут человек. Людей осталось: {N}");
            }
            Console.WriteLine("Игра окончена. Невозможно вычеркнуть больше людей.");
        }

        static int ReadInt()
        {
            int res;
            string input;
            do
            {
                input = Console.ReadLine();
            } while (!int.TryParse(input, out res) && res > 0);
            return res;
        }
    }
}