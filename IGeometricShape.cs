﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapesHomework
{
    internal interface IGeometricShape<T>
    {
        double Square { get; }
        int Dimension { get; }
    }
}
