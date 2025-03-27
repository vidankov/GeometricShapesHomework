using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    public class GeometricalShapeException : Exception
    {
        public GeometricalShapeException()
        {
        }

        public GeometricalShapeException(string message)
            : base(message)
        {
        }

        public GeometricalShapeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
