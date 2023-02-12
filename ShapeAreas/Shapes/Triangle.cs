using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreas.Shapes
{
    public class Triangle : IShape
    {
        private double[] _sides { get; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("Triangle side cannot be greater than the sum of the other two sides.");
            }
            _sides = new[] { sideA, sideB, sideC }.OrderBy(x => x).ToArray();
        }
        public double CalculateArea()
        {
            return IsRightAngled(_sides) ? Area(_sides[0], _sides[1])
                : Area(_sides[0], _sides[1], _sides[2]);
        }

        private double Area(double sideA, double sideB)
        {
            return sideA * sideB / 2;
        }

        private double Area(double sideA, double sideB, double sideC)
        {
            double semiPerimeter = _sides.Sum() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public bool IsRightAngled(IReadOnlyCollection<double> sides)
        {
            return Math.Abs(Math.Pow(sides.ElementAt(0), 2) + Math.Pow(sides.ElementAt(1), 2) - Math.Pow(sides.ElementAt(2), 2)) < 0.001;
        }
        private static bool IsValid(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC
                && sideB + sideC > sideA
                && sideA + sideC > sideB;
        }

    }
}
