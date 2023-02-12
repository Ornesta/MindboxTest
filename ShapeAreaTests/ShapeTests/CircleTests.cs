using ShapeAreas.Shapes;

namespace ShapeAreaTests.ShapeTests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1, 3.1416)]
        [InlineData(2, 12.566)]
        [InlineData(10, 314.16)]
        public void CalculateArea_RadiusIsValid_GetsCorrectArea(double radius, double expected)
        {
            var result = new Circle(radius).CalculateArea();
            Assert.Equal(expected, result, 0.001);
        }
        [Fact]
        public void Ctor_RadiusIsNegative_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }
    }
}