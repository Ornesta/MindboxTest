using ShapeAreas.Shapes;

namespace ShapeAreaTests.ShapeTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(10, 6, 8, 24)]
        [InlineData(10, 7, 5, 16.248)]
        [InlineData(15, 18, 20, 129.76)]
        public void CalculateArea_ValidSides_GetsCorrectArea(double sideA, double sideB, double sideC, double expected)
        {
            var result = new Triangle(sideA, sideB, sideC).CalculateArea();
            Assert.Equal(expected, result, 0.001);
        }

        [Theory]
        [InlineData(new double[] { 3, 4, 5 })]
        public void IsRightAngled_RightTriangle_ReturnsTrue(double[] sides)
        {
            var result = new Triangle(sides[0], sides[1], sides[2]).IsRightAngled(sides);
            Assert.True(result);
        }

        [Fact]
        public void Ctor_InvalidSides_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(2, 3, 5));
        }
    }
}