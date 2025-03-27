using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    internal class InvalidSideException : GeometricalShapeException
    {
        public InvalidSideException()
        {
        }

        public InvalidSideException(string message)
            : base(message)
        {
        }

        public InvalidSideException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
