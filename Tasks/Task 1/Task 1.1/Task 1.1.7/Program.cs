using System;

namespace Task_1._1._7
{
    class Program
    {

        static int[] BuubleSort(int[] arr)
        {
            int t;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] > arr[j])
                    {
                        t=arr[i];
                        arr[i]= arr[j];
                        arr[j]=t;
                    }
            return arr;
            
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n= rnd.Next(10, 20);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(-100, 100);
            Console.WriteLine("Before sort: ");
            for (int i = 0; i < n; i++)
                Console.Write($"{arr[i]} ");
            BuubleSort(arr);
            Console.WriteLine();
            Console.WriteLine($"Max= {arr[n-1]}, Min= {arr[0]}");
            Console.WriteLine("After sort: ");
            for (int i=0; i<n; i++)
                Console.Write($"{arr[i]} ");
        }
    }
}
