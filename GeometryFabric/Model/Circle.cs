using System;
using System.Collections.Generic;

namespace GeometryFabric.Model
{
    class Circle : Figure
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Perimeter() { return 2 * Math.PI * _radius; }
        public override double Area() { return (Math.PI * _radius * _radius); }
        public static Circle Form()
        {
            Console.WriteLine("Введите радиус:");
            double.TryParse(Console.ReadLine(), out double rad);
            return new Circle(rad);
        }
    }
}
