using System;

namespace Task_1._1._8
{
    class Program
    {
        static void Write(int [,,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                        Console.Write("{0,4}", arr[i, j, k]);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,,] arr = new int[3, 3, 3];
            for(int i=0; i<3; i++)
                for(int j=0; j<3; j++)
                    for(int k=0; k<3; k++)
                        arr[i, j, k]= rnd.Next(-100, 100);
            Console.WriteLine("Before:");
            Write(arr);
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                        if(arr[i, j, k]>0)
                            arr[i, j, k] =0;
            Console.WriteLine("After: ");
            Write(arr);


        }


    }
}
