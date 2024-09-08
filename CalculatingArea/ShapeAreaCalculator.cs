﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingArea
{
    public static class ShapeAreaCalculator
    {
        public static double CalculateShapeArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
