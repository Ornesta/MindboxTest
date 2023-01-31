using ShapeAreas;

namespace ShapeAreaTests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(new double[] { 3, 4, 5 }, 6)]
        [InlineData(new double[] { 10, 6, 8 }, 24)]
        [InlineData(new double[] { 10, 7, 5 }, 16.248)]
        [InlineData(new double[] { 15, 18, 20 }, 129.76)]
        public void CalculateArea_SidesAreValid_GetsCorrectArea(double[] sides, double expected)
        {
            var result = new Triangle(sides).CalculateArea();
            Assert.Equal(expected, result, 0.001);
        }

        [Theory]
        [InlineData(new double[] { 3, 4, 5 })]
        public void IsRightAngled_RightTriangle_ReturnsTrue(double[] sides)
        {
            var result = new Triangle(sides).IsRightAngled(sides);
            Assert.True(result);
        }

        [Fact]
        public void Ctor_SidesAreInvalid_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(new double[] { 2, 3, 5 }));
        }
    }
}