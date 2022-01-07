using System;

namespace Task_1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text =Console.ReadLine();
            int l = 0, i=0;// средняя длинна слова округляется

            char[] separators = new char[] { ' ', '.', ':' };

            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                l += word.Length;
                i++;
            }
            Console.WriteLine(l/i);
        }
    }
}

