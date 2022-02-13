using System;
using System.Collections.Generic;

namespace task_2._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, пройдите регистрацию");
            FigurePrint newFigurePrint = new FigurePrint();
            User newUser = new User();
            newUser.AddUser(newUser);
            
            byte choice = 7;
            
            do
            {
                Console.WriteLine("Добро пожаловать," + newUser.Name + " выберите нижеуказанный пункт");
                Console.WriteLine("1 - Ввести новое имя пользователя" + Environment.NewLine + "2 - Ввести фигуру" + Environment.NewLine +
                                  "3 - Очистить холст" + Environment.NewLine + "4- Вывести все фигуры" + Environment.NewLine + "5- Выход");
                choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        newUser.AddUser(newUser);
                        break;
                    case 2:
                        Console.Write("Выберите фигуру:" + Environment.NewLine +
                            "0 - выйти" + Environment.NewLine +
                            "1 - круг" + Environment.NewLine +
                            "2 - окружность" + Environment.NewLine +
                            "3 - кольцо" + Environment.NewLine +
                            "4 - квадрат" + Environment.NewLine +
                            "5 - прямоугольник" + Environment.NewLine +
                            "6 - треугольник" + Environment.NewLine);
                        byte choiceFigure = 0;
                        choiceFigure = byte.Parse(Console.ReadLine());
                        switch (choiceFigure)
                        {
                            case 0:
                                break;
                            case 1:
                                newFigurePrint.PrintCircle();
                                break;
                            case 2:
                                newFigurePrint.PrintRoundLine();
                                break;
                            case 3:
                                newFigurePrint.PrintCircle();
                                break;
                            case 4:
                                newFigurePrint.PrintSquare();
                                break;
                            case 5:
                                newFigurePrint.PrintRectangle();
                                break;
                            case 6:
                                newFigurePrint.PrintTriangle();
                                break;
                            default:
                                Console.WriteLine("Введите корректное значение");
                                break;
                        }
                        break;
                    case 3:
                        newFigurePrint.DeliteFigure();
                        break;
                    case 4:
                        newFigurePrint.ShowFigures();
                        break;
                    default:
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);
            
           
        }
    }
}
