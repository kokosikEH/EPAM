using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1._2
{
    class Roundline
    {
        private double radius;

        public double Radius
        {
            get => radius;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Введите положительное число");
                }
                else
                    radius = value;
            }
        }

        public double Perimetr()
        {
            double perimetr;
            perimetr = 2 * 3.14 * Radius;
            Console.WriteLine("Длина окружности:" + perimetr);
            return perimetr;
        }
    }
    
}
