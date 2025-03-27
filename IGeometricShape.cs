using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    internal interface IGeometricShape
    {
        double Square { get; }
        int Dimension { get; }
        List<Side> Sides { get; }
    }
}
