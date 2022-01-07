using System;

namespace Task_1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int i = 0;

            char[] separators = new char[] { ' ', '.', ':', ';', '!', '?', ',' };

            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
                if (word[0] != word.ToUpper()[0])
                    i++;

            Console.WriteLine( i);
        }
    }
}
