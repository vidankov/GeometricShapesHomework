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
            ValidateSizes();
        }
        protected void ValidateSizes()
        {
            if (Sides.Count != 3)
                throw new InvalidTriangleException("У треугольника должно быть три стороны!");

            List<double> sidesLengths = Sides.Select(side => side.Length).ToList();
            sidesLengths.Sort();

            if (sidesLengths[2] >= sidesLengths[1] + sidesLengths[0])
                throw new InvalidTriangleException("Из сторон заданной длины невозможно создать треугольник!");
        }
    }
}
