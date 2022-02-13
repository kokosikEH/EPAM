using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1._2
{
    class Circle: Figures
    {
        int x;
        private double radius;
        public override int X
        {
            get => x;
            set
            {
            }
        }
        public Circle()
        {
            x = 0;
            radius = 0;
        }
        public double Radius
        {
            get => radius;
            set
            {               
                if (value < 1 )
                {
                    Console.WriteLine("Введите положительное число");
                }
                else
                   radius = value;
            }
        }

        public override double Perimetr()
        {
            double perimetr = 2 * 3.14 * Radius;
            Console.WriteLine("Длина круга" + perimetr);
            return perimetr;
        }

        public override double Plowad()
        {
            double plowad = 3.14 * Radius * Radius;
            Console.WriteLine("Площадь круга:" + plowad);
            return plowad;
        }
    }
}
