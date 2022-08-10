using GeometryFabric.Model;
using System;
using System.Collections.Generic;

namespace GeometryFabric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> figures = Settings.ReturnFigureList();
            Console.WriteLine("Добро пожаловать!");
            start:
            string welcomeMessage = "Выберите фигуру:\n";
            foreach (var item in figures)
            {
                welcomeMessage += $"{item.Key}. {item.Value}\n"; 
            }
            Console.WriteLine(welcomeMessage);
            int.TryParse(Console.ReadLine(), out int fig);
            Figure figure = FormFigure(fig);
            Console.WriteLine("Вы хотите:\n 1. Посчитать периметр\n 2. Посчитать площадь");
            int.TryParse(Console.ReadLine(), out int action);

            switch (action) 
            {
                case 1:
                    Console.WriteLine($"Периметр фигуры равен {figure.Perimeter()}");
                    break;
                case 2:
                    Console.WriteLine($"Площадь фигуры равна {figure.Area()}"); ;
                    break;
            }
            Console.WriteLine("Если хотите продолжить нажмите любую кнопку, иначе нажмите ESC");
            ConsoleKeyInfo inf = Console.ReadKey();
            if (inf.Key != ConsoleKey.Escape)
                goto start;
        }
        public static Figure FormFigure(int fig) 
        {
            Figure figure = null;
            switch (fig) 
            {
                case 1:
                    figure = RegularPolytope.Form();
                    break;
                case 2:
                    figure = Circle.Form();
                    break;
                case 3:
                    figure = Triangle.Form();
                    if(Triangle.CheckIfPossible((Triangle)figure))
                        figure.CheckIfRightMessage();
                    else
                        Console.WriteLine("Такого треугольника не может быть");
                    return null;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            return figure;
        }
    }
}
