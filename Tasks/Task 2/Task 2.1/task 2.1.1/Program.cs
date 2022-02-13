using System;

namespace task_2._1._1
{
    public class MyString
    {
        public char[] ArrChar { get; set; }

        public MyString(int length)
        {
            ArrChar = new char[length];
        }

        public MyString(char[] input)
        {
            ArrChar = input;
        }

        public void StringWrite()
        {
            foreach (char c in ArrChar)
                Console.Write(c);
            Console.WriteLine();
        }

        public bool Equality(MyString input)
        {

            if (this.ArrChar.Length == input.ArrChar.Length)
            {
                for (int i = 0; i < this.ArrChar.Length; i++)
                    if (this.ArrChar[i] != input.ArrChar[i])
                        return false;
                return true;
            }
            return false;
        }

        public int Index(char input)
        {
            for (int i = 0; i < this.ArrChar.Length; ++i)
            {
                if (this.ArrChar[i] == input)
                    return i;
            }
            return -1;
        }

        public int Length()
        {
            int counter = 0;
            for (int i = 0; i < this.ArrChar.Length; ++i)
            {
                ++counter;
            }
            return counter;
        }

        public static MyString operator +(MyString left, MyString right)
        {
            MyString newstr = new MyString(left.ArrChar.Length + right.ArrChar.Length);

            for (int i = 0; i < left.ArrChar.Length; ++i)
            {
                newstr.ArrChar[i] = left.ArrChar[i];
            }
            for (int i = left.ArrChar.Length; i < left.ArrChar.Length + right.ArrChar.Length; ++i)
            {
                newstr.ArrChar[i] = right.ArrChar[i - left.ArrChar.Length];
            }

            return newstr;
        }

    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the 1st string:");

            MyString String1 = new MyString(Console.ReadLine().ToCharArray());

            Console.WriteLine("Enter the 2nd string:");

            MyString String2 = new MyString(Console.ReadLine().ToCharArray());

            Console.WriteLine("Entered strings:");
            String1.StringWrite();
            String2.StringWrite();

            Console.WriteLine($"Equality: {String1.Equality(String2)}");

            Console.Write("Concatenation: ");
            (String1 + String2).StringWrite();

            Console.WriteLine($"Length of String1 is: {String1.Length()}");
            Console.WriteLine($"Length of String2 is: {String2.Length()}");

            Console.WriteLine("Enter character to look for: ");

            char.TryParse(Console.ReadLine(), out char inputCharacter);

            if (String1.Index(inputCharacter) >= 0)
                Console.WriteLine($"Index of {inputCharacter} char in String1: {String1.Index(inputCharacter)}");
            else Console.WriteLine("There is no such character in the String1 :(");

            if (String2.Index(inputCharacter) >= 0)
                Console.WriteLine($"Index of {inputCharacter} char in String2: {String2.Index(inputCharacter)}");
            else Console.WriteLine("There is no such character in the String2 :(");
        }
    }
}

