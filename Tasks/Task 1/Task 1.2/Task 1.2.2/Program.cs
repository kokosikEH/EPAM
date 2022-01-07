using System;

namespace Task_1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string text2 = Console.ReadLine();
            string result = "";
            foreach (char ch in text)
                if (text2.Contains(ch))
                {
                    result += ch;
                    result += ch;
                }
                else result += ch;
            Console.WriteLine(result);
        }
    }
}
