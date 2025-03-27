using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    internal class TwoDimensionalCoordinate : OneDimensionCoordinate
    {
        public double Y { get; }
        public TwoDimensionalCoordinate(double x, double y) : base(x)
        {
            Y = y;
        }
    }
}
