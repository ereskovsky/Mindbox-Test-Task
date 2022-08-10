using System;
using System.Collections.Generic;
using System.Linq;

namespace GeometryFabric.Model
{
    class Triangle : Figure
    {
        private int _numberOfSides;
        private List<double> _sides;
        public override List<double> Sides
        {
            get
            {
                return _sides;
            }
            set
            {
                _sides = value;
            }
        }

        public Triangle(List<double> sides)
        {
            _numberOfSides = 3;
            _sides = sides;
        }
        public bool IsRight
        {
            get
            {
                _sides.Sort((a, b) => a.CompareTo(b));
                if (_sides[0] * _sides[0] + _sides[1] * _sides[1] == _sides[2] * _sides[2])
                    return true;
                else return false;
            }
        }

        public override double Area()
        {
            double halfPerimeter = Perimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _sides[0]) * (halfPerimeter - _sides[1]) * (halfPerimeter - _sides[2]));
        }
        public static Triangle Form()
        {
            List<double> sides = new List<double>();
            Console.WriteLine("Введите сторону A:");
            double.TryParse(Console.ReadLine(), out double A);
            sides.Add(A);
            Console.WriteLine("Введите сторону B:");
            double.TryParse(Console.ReadLine(), out double B);
            sides.Add(B);
            Console.WriteLine("Введите сторону C:");
            double.TryParse(Console.ReadLine(), out double C);
            sides.Add(C);
            return new Triangle(sides);
        }
        
        public override void CheckIfRightMessage() 
        {
            switch (IsRight)
            {
                case true: Console.WriteLine("Треугольник правильный\n");
                    break;
                case false: Console.WriteLine("Треугольник неправильный\n");
                    break;
            }
        }
        public static bool CheckIfPossible(Triangle triangle)
        {
            triangle._sides.Sort((a, b) => a.CompareTo(b));
            if (triangle._sides[0] + triangle._sides[1] <= triangle._sides[2])
                return true;
            else return false;
        }
    }
}
