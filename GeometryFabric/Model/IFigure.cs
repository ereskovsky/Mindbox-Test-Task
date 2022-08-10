using System.Collections.Generic;

namespace GeometryFabric.Model
{
    interface IFigure
    {
        int NumberOfSides { get; }
        List<double> Sides { get; set; }

        double Perimeter();
        double Area();
    }
}
