using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1._2
{
    class FigurePrint: IPrintfigures
    {
        List<Figures> ListFigures = new List<Figures>();
        public void PrintCircle()
        {
            int choise = 0;
            int index = -1;
            while (choise != 2)
            {
                Console.Write("Введите выбор" + Environment.NewLine + "1 - Ввести фигуру " + Environment.NewLine + "2 - Закончить ввод" + Environment.NewLine);
                choise = int.Parse(Console.ReadLine());
                if (choise == 2) break;
                while (++index <= ListFigures.Count)
                {
                    Circle newCircle = new Circle();
                    Console.WriteLine("Введите радиус");
                    newCircle.Radius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату центра");
                    newCircle.X = int.Parse(Console.ReadLine());
                    newCircle.Perimetr();
                    newCircle.Plowad();
                    ListFigures.Add(newCircle);
                    break;
                }
            }
        }

        public void PrintRing()
        {
            int choise = 0;
            int index = -1;
            while (choise != 2)
            {
                Console.Write("Введите выбор" + Environment.NewLine + "1 - Ввести фигуру " + Environment.NewLine + "2 - Закончить ввод" + Environment.NewLine);
                choise = int.Parse(Console.ReadLine());
                if (choise == 2) break;
                while (++index <= ListFigures.Count)
                {
                    Ring newRing = new Ring();
                    Console.WriteLine("Введите радиус");
                    newRing.Radius = double.Parse(Console.ReadLine());
                    newRing.Outerradius = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату центра");
                    newRing.X = int.Parse(Console.ReadLine());
                    newRing.Perimetr();
                    newRing.Plowad();
                    ListFigures.Add(newRing);
                    break;
                }
            }
        }

        public void PrintRoundLine()
        {
            int choise = 0;
            int index = -1;
            while (choise != 2)
            {
                Console.Write("Введите выбор" + Environment.NewLine + "1 - Ввести фигуру " + Environment.NewLine + "2 - Закончить ввод" + Environment.NewLine);
                choise = int.Parse(Console.ReadLine());
                if (choise == 2) break;
                while (++index <= ListFigures.Count)
                {
                    Roundline newRoundline = new Roundline();
                    Console.WriteLine("Введите радиус");
                    newRoundline.Radius = double.Parse(Console.ReadLine());
                    newRoundline.Perimetr();
                    //ListFigures.Add(newRoundline);
                    break;
                }
            }
        }

        public void PrintSquare()
        {
            int choise = 0;
            int index = -1;
            while (choise != 2)
            {
                Console.Write("Введите выбор" + Environment.NewLine + "1 - Ввести фигуру " + Environment.NewLine + "2 - Закончить ввод" + Environment.NewLine);
                choise = int.Parse(Console.ReadLine());
                if (choise == 2) break;
                while (++index <= ListFigures.Count)
                {
                    Square newSquare = new Square();
                    Console.WriteLine("Введите сторону квадрата");
                    newSquare.Side = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату центра");
                    newSquare.X = int.Parse(Console.ReadLine());
                    newSquare.Perimetr();
                    newSquare.Plowad();
                    ListFigures.Add(newSquare);
                    break;
                }
            }
        }

        public void PrintRectangle()
        {
            int choise = 0;
            int index = -1;
            while (choise != 2)
            {
                Console.Write("Введите выбор" + Environment.NewLine + "1 - Ввести фигуру " + Environment.NewLine + "2 - Закончить ввод" + Environment.NewLine);
                choise = int.Parse(Console.ReadLine());
                if (choise == 2) break;
                while (++index <= ListFigures.Count)
                {
                    Rectangle newRectangle = new Rectangle();
                    Console.WriteLine("Введите первую сторону прямоугольника");
                    newRectangle.SideA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите втоорую сторону прямоугольника");
                    newRectangle.SideB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите координату центра");
                    newRectangle.X = int.Parse(Console.ReadLine());
                    newRectangle.Perimetr();
                    newRectangle.Plowad();
                    ListFigures.Add(newRectangle);
                    break;
                }
            }
        }

        

        public void PrintTriangle()
        {
            int choise = 0;
            int index = -1;
            while (choise != 2)
            {
                Console.Write("Введите выбор" + Environment.NewLine + "1 - Ввести фигуру " + Environment.NewLine + "2 - Закончить ввод" + Environment.NewLine);
                choise = int.Parse(Console.ReadLine());
                if (choise == 2) { break; }
                while (++index <= ListFigures.Count)
                {
                    Console.Write("Выберите какой вид треугольника вы хотите добавить: " + Environment.NewLine + "1 - обычный" + Environment.NewLine + "2 - равнобедренный" + Environment.NewLine + "3 - равносторонний");
                    byte tip = 0;                   
                    tip = byte.Parse(Console.ReadLine());
                    Triangle newTriangle = new Triangle();
                    switch (tip)
                    {
                        case 1:
                            Console.WriteLine("Введите первую сторону треугольника");
                            newTriangle.SideA = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите вторую сторону треугольника");
                            newTriangle.SideB = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите третью сторону треугольника");
                            newTriangle.SideC = double.Parse(Console.ReadLine());
                            if( newTriangle.SideA + newTriangle.SideB < newTriangle.SideC || newTriangle.SideA + newTriangle.SideC < newTriangle.SideB || newTriangle.SideB + newTriangle.SideC < newTriangle.SideA)
                            { goto default; } // сумма двух сторон должна быть больше 3 - ей
                            newTriangle.Perimetr();
                            newTriangle.Plowad();
                            ListFigures.Add(newTriangle);
                            break;
                        case 2:
                            Console.WriteLine("Введите длину двух одинаковых сторон треугольника");
                            newTriangle.SideA = double.Parse(Console.ReadLine());
                            Console.WriteLine("Введите оставшуюся сторону треугольника");
                            if (newTriangle.SideA * 2 < newTriangle.SideB)
                            { goto default; } // сумма двух сторон должна быть больше 3 - ей
                            newTriangle.SideB = double.Parse(Console.ReadLine());
                            newTriangle.Perimeterforisosceles();
                            newTriangle.Plowadforisosceles();
                            ListFigures.Add(newTriangle);
                            break;
                        case 3:
                            Console.WriteLine("Введите длину трех одинаковых сторон треугольника");
                            newTriangle.SideA = double.Parse(Console.ReadLine());
                            newTriangle.Perimeterforequilateral();
                            newTriangle.Plowadforequilateral();
                            ListFigures.Add(newTriangle);
                            break;
                        default:
                            Console.WriteLine("Введите корректное значение");
                            index--;//для того, чтобы при неверном вводе несколько  индекс не превысил число элементов листа
                            break; 
                    }
                    break;
                }           
            }
        }

        public void ShowFigures()
        { 
            foreach (var item in ListFigures)
            {
                int counter = 1;
                Console.WriteLine("Фигура номер " + counter + item.GetType());
                Console.WriteLine(item.GetType());
                Console.WriteLine(item.Plowad());
                Console.WriteLine(item.Perimetr());
                Console.WriteLine(Environment.NewLine);
                counter++;
            }
        }
        public void DeliteFigure()
        {
            ListFigures.Clear();
            Console.WriteLine("доска очищена");
        }   
    }

}
