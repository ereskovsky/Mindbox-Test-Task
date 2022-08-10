using System.Collections.Generic;
using System.Linq;

namespace GeometryFabric.Model
{
    abstract class Figure : IFigure
    {
        private int _numberOfSides;
        public List<double> _sides;

        public virtual int NumberOfSides
        {
            get
            {
                if (_numberOfSides > 2)
                    return _numberOfSides;
                else
                    return 3;
            }
        }
        public virtual List<double> Sides
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
        public virtual double Perimeter() { return Sides.Sum(); }
        public virtual void CheckIfRightMessage() { }
        public abstract double Area();
    }
}
