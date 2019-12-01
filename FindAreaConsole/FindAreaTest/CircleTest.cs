using FindAreaLibrary.Dto;
using FindAreaLibrary.Figure;
using System;
using Xunit;

namespace FindAreaTest
{
    public class CircleTest
    {
        [Fact]
        public void CircleGetAreaNoData()
        {
            var circle = new Circle();

            circle.SetParameters(null);

            Assert.Throws<ArgumentNullException>(() => circle.GetArea());
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void CircleGetAreaRadiusLess(double radius)
        {
            var circle = new Circle();

            var param = new ParamOfCircle { Radius = radius };

            circle.SetParameters(param);

            Assert.Throws<ArgumentNullException>(() => circle.GetArea());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(100.6)]
        public void CircleGetAreaRadiusCorrect(double radius)
        {
            var circle = new Circle();

            var param = new ParamOfCircle { Radius = radius };

            circle.SetParameters(param);

            var s = circle.GetArea();

            Assert.True(s > 0);
        }

        [Theory]
        [InlineData(1)]
        public void CircleSetParameters(double radius)
        {
            var circle = new Circle();

            var param = new ParamOfCircle { Radius = radius };

            circle.SetParameters(param);

            Assert.True(circle.Parameters?.Radius == radius);
        }
    }
}
