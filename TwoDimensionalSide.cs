using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    internal class TwoDimensionalSide : ISide<TwoDimensionalCoordinate>
    {
        public TwoDimensionalCoordinate StartCoordinate { get; }
        public TwoDimensionalCoordinate EndCoordinate { get; }
        public double Length =>
            Math.Sqrt(
                Math.Pow(EndCoordinate.X - StartCoordinate.X, 2) +
                Math.Pow(EndCoordinate.Y - StartCoordinate.Y, 2)
            );
        public TwoDimensionalSide(TwoDimensionalCoordinate startCoordinate,
            TwoDimensionalCoordinate endCoordinate)
        {
            StartCoordinate = startCoordinate;
            EndCoordinate = endCoordinate;
            Validate();
        }
        protected void Validate()
        {
            if (Length == 0) throw new InvalidSideException("Длина стороны фигуры должна быть больше нуля!");
        }
    }
}
