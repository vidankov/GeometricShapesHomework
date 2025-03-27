using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    abstract class TwoDimensionalShape
    {
        public int Dimension => 2;
        public List<TwoDimensionalSide> Sides { get; }
        public TwoDimensionalShape(params List<TwoDimensionalSide> sides)
        {
            Sides = sides;
        }
    }
}
