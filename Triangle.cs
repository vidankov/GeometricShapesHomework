using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    internal class Triangle : TwoDimensionalShape, IGeometricShape<TwoDimensionalSide>
    {
        public double Square
        {
            get
            {
                double[] sides = Sides.Select(side => side.Length).ToArray();
                double p = sides.Sum() / 2;
                return Math.Sqrt(p * sides.Select(side => p - side).Aggregate((a, b) => a * b));
            }
        }
    public Triangle(params List<TwoDimensionalSide> sides) : base(sides)
    {
    }
}
}
