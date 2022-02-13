using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1._2
{
    class Square: Figures
    {
        int x;
        private double side;
        public override int X
        {

            get => x;
            set
            {
            }
        }

        public double Side 
        { 
            get => side;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Введите положительное число");
                }
                else
                    side = value; ;
            }
        }
        public override double Plowad()
        {
            double plowad = 0;
            plowad = Side * Side;
            Console.WriteLine("Площадь квадрата:" + plowad);
            return plowad;
        }
        public override double Perimetr()
        {
            double perimetr = 0;
            perimetr = Side * 4;
            Console.WriteLine("Периметр квадрата равен:" + perimetr);
            return perimetr;
        }
    }
}
