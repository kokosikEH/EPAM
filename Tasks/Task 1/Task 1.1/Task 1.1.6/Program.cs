using System;

namespace Task_1._1._6
{
    class Program
    {
        static void Write(int[] arr)
        {
            string a = "Параметры надписи: ";
            string b = "Введите: ";
            string[] type = { "None", "Bold", "Italic", "Underline" };
            int[] num = { -1, -1, -1 };

            int p = 0, w = 0;
            while (p < 3)
            {
                if (arr[p] >= 0)
                {
                    num[w] = arr[p];
                    w++;
                }
                p++;
            }

            Console.Write(a);
            for (int m = 0; m < 3; m++)
            {
                if (num[m]>=0)
                Console.Write($"{type[num[m]]} ");
            }
            if(num[0]==-1) Console.Write(type[0]);

            Console.WriteLine();

            Console.WriteLine(b);
            for (int k = 1; k < 4; k++)
                Console.WriteLine($"{k}: {type[k]}");

        }

        static int[] BuubleSort(int[] arr)
        {
            int t;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] < arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
            return arr;
        }
        static void Main(string[] args)
        {
            int i = 0, s = 1, k = 0;
            int[] condition = { 0, -1, -1 };
            Write(condition);

            while (s != 0)
            {
                //while (condition[i] >=0) i++;
                int.TryParse(Console.ReadLine(), out s);
                BuubleSort(condition);
                for (int j = 0; j < 3; j++)
                    if (s == condition[j])
                    {
                        condition[j] = -1;
                        k++;                                            
                    }                    
                
                if (k<= 0) condition[i] = s;
                if (condition[i] >= 0) i++;

                if (i > 2) i = 0;
                BuubleSort(condition);
                Write(condition);
                }
            }
        }
    }

