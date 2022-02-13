using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1._2
{
    class Triangle: Figures
    {
        int x;
        private double sideA;
        private double sideB;
        private double sideC;
        private double perimetr;
        private double plowad;
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
                    sideA = value; 
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
        public double SideC
        {
            get => sideC;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Введите положительное число");
                }
                else
                    sideC = value; ;
            }
        }

        public double Perimetr1 { get => perimetr; set => perimetr = value; }
        public double Plowad1 { get => plowad; set => plowad = value; }

        public override double Perimetr()
        {
            Perimetr1 = SideA + SideB + SideC;
            Console.WriteLine("Периметр треугольника равен:" + Perimetr1);
            return Perimetr1;
        }

        public double Perimeterforisosceles()
        {
            Perimetr1 = (SideA * 2)  + SideB;
            Console.WriteLine("Периметр треугольника равен:" + Perimetr1);
            return Perimetr1;
        }

        public double Perimeterforequilateral()
        {
            Perimetr1 = SideA * 3;
            Console.WriteLine("Периметр треугольника равен:" + Perimetr1);
            return Perimetr1;
        }

        public override double Plowad()
        {
            double poluperimetr = Perimetr1 / 2;
            Plowad1 = Math.Sqrt(poluperimetr * (poluperimetr - SideA) * (poluperimetr - SideB) * (poluperimetr - SideC));
            Console.WriteLine("Площадь треугольника:" + Plowad1);
            return Plowad1;
        }

        public double Plowadforisosceles()
        {
            double visota = 0;
            Console.Write("Введите высоту: ");
            visota = double.Parse(Console.ReadLine());
            Plowad1 = 0.5 * SideA * visota;
            Console.WriteLine("Площадь равнобедренного треугольника:" + Plowad1);
            return Plowad1;
        }

        public double Plowadforequilateral()
        {
            double visota = 0;
            Console.Write("Введите высоту: ");
            visota = double.Parse(Console.ReadLine());
            Plowad1 = 0.5 * SideA * visota;
            Console.WriteLine("Площадь равностороннего треугольника:" + Plowad1);
            return Plowad1;
        }
    }
}
