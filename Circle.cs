using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    internal class Circle : TwoDimensionalShape, IGeometricShape<TwoDimensionalSide>
    {
        public double Square => Math.PI * Math.Pow(Radius, 2);
        public double Radius => Sides[0].Length;
        public Circle(params List<TwoDimensionalSide> sides) : base(sides) { }
    }
}
