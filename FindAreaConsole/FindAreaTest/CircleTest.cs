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

            Assert.Throws<ArgumentNullException>(() => circle.GetArea(null));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        public void CircleGetAreaRadiusLess(double radius)
        {
            var circle = new Circle();

            var param = new ParamOfCircle { Radius = radius };

            Assert.Throws<ArgumentNullException>(() => circle.GetArea(param));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(100.6)]
        public void CircleGetAreaRadiusCorrect(double radius)
        {
            var circle = new Circle();

            var param = new ParamOfCircle { Radius = radius };

            var s = circle.GetArea(param);

            Assert.True(s > 0);
        }
    }
}
