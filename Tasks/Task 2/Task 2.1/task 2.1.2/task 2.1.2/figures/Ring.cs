using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1._2
{
    class Ring: Figures
    {
        int x;
        private double radius;
        private double outerradius;


        public override int X
        {
            get => x;
            set
            {
            }
        }
        public Ring()
        {
            x = 0;
            radius = 0;
        }
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

        public double Outerradius 
        { 
           get => outerradius;
            
           set
            {
                if (value < 1)
                {
                    Console.WriteLine("Введите положительное число");
                }
                else
                    outerradius = value;
            }
        }

        public override double  Plowad()
        {
            double plowad = 3.14 * (Radius *  Radius - Outerradius * Outerradius);
            Console.WriteLine("Площадь круга:" + plowad);
            return plowad;
        }

        public override double Perimetr()
        {
            double outerperimetr = 2 * 3.14 * Outerradius;
            double innerperimetr = 2 * 3.14 * Radius;
            Console.WriteLine("Внешний периметр кольца:" + outerperimetr);
            Console.WriteLine("Внутренний периметр кольца:" + innerperimetr);
            Console.WriteLine("Сумма периметров:" +(outerperimetr + innerperimetr));
            return outerperimetr + innerperimetr;
        }
    }
}
