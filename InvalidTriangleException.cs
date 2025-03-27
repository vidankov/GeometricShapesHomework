using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    internal class InvalidTriangleException : GeometricalShapeException
    {
        public InvalidTriangleException()
        {
        }

        public InvalidTriangleException(string message)
            : base(message)
        {
        }

        public InvalidTriangleException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
