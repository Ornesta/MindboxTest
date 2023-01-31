﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreas
{
    public class Circle : IShape
    {
        private double _radius { get; }

        public Circle(double radius)
        {
            if (!IsValid(radius))
            {
                throw new ArgumentException("Radius cannot be negative or zero.");
            }
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        private bool IsValid(double radius)
        {
            return radius > 0;
        }
    }
}
