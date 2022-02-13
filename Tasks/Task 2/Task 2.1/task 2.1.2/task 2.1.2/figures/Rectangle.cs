using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1._2
{
    class Rectangle: Figures
    {
        int x;
        private double sideA;
        private double sideB;
        public override int X
        {
            get => x;
            set
            {
            }
        }

        public double SideA
        {
            get => sideA;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Введите положительное число");
                }
                else
                    sideA = value; ;
            }
        }
        public double SideB
        { 
            get => sideB;
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Введите положительное число");
                }
                else
                    sideB = value; ; 
            }
        }

        public override double Perimetr()
        {
            double perimetr = 0;
            perimetr = 2 * (SideA + SideA);
            Console.WriteLine("Периметр прямоугольника:" + perimetr);
            return perimetr;
        }

        public override double Plowad()
        {
            double plowad = 0;
            plowad = SideA * SideB;
            Console.WriteLine("Площадь прямоугольника:" + plowad);
            return plowad;
        }
       
    }
}
