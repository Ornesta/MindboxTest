using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreas
{
    public class Triangle : IShape
    {
        private double[] _sides { get; }
        public Triangle(double[] sides)
        {
            if (!IsValid(sides))
            {
                throw new ArgumentException("Triangle side cannot be greater than the sum of the other two sides.");
            }
            _sides = sides.AsEnumerable().OrderBy(x => x).ToArray();
        }
        public double CalculateArea()
        {
            if (IsRightAngled(_sides))
            {
                return (_sides[0] * _sides[1]) / 2;
            }
            else
            {
                double s = (_sides[0] + _sides[1] + _sides[2]) / 2;
                return Math.Sqrt(s * (s - _sides[0]) * (s - _sides[1]) * (s - _sides[2]));
            }
        }
        public bool IsRightAngled(double[] sides)
        {
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        private bool IsValid(double[] sides)
        {
            return sides[0] + sides[1] > sides[2]
                && sides[1] + sides[2] > sides[0]
                && sides[0] + sides[2] > sides[1];
        }

    }
}
