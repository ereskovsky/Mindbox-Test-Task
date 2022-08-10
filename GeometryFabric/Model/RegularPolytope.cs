using System;

namespace GeometryFabric.Model
{
    class RegularPolytope : Figure
    {
        private int _numberOfSides;
        private double _side;

        public RegularPolytope(int numberOfSides, double side)
        {
            _numberOfSides = numberOfSides;
            _side = side;
        }
        public override double Area() { return (_numberOfSides * _side * _side) / (4 * Math.Tan(180 / _numberOfSides)); }

        public static RegularPolytope Form() {
            Console.WriteLine("Введите количество сторон:");
            int.TryParse(Console.ReadLine(), out int sidesNumber);
            Console.WriteLine("Введите длину стороны:");
            int.TryParse(Console.ReadLine(), out int side);
            return new RegularPolytope(sidesNumber, side);
        }
    }
}
