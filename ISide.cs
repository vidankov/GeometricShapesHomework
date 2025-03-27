using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    internal interface ISide<T>
    {
        public T StartCoordinate { get; }
        public T EndCoordinate { get; }
        public double Length { get; }
    }
}
