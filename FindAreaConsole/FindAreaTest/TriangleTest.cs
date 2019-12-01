using FindAreaLibrary.Dto;
using FindAreaLibrary.Figure;
using System;
using Xunit;

namespace FindAreaTest
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleGetAreaNoData()
        {
            var triangle = new Triangle();

            triangle.SetParameters(null);

            Assert.Throws<ArgumentNullException>(() => triangle.GetArea());
        }

        [Theory]
        [InlineData(-1, 2, 3.4)]
        [InlineData(0, 2, 3.4)]
        [InlineData(2, -1, 3.4)]
        [InlineData(2, 0, 3.4)]
        [InlineData(2, 3.4, -1)]
        [InlineData(2, 3.4, 0)]
        public void TriangleGetAreaSideLess(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle();

            var param = new ParamOfTriangle { SideA = sideA, SideB = sideB, SideC = sideC };

            triangle.SetParameters(param);

            Assert.Throws<ArgumentNullException>(() => triangle.GetArea());
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(1, 2.5, 3.4)]
        [InlineData(2, 2.5, 3)]
        public void TriangleGetAreaSideCorrect(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle();

            var param = new ParamOfTriangle { SideA = sideA, SideB = sideB, SideC = sideC };

            triangle.SetParameters(param);

            var s = triangle.GetArea();

            Assert.True(s > 0);
        }

        [Theory]
        [InlineData(300, 4, 5)]
        public void TriangleGetAreaSideNotCorrect(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle();

            var param = new ParamOfTriangle { SideA = sideA, SideB = sideB, SideC = sideC };

            triangle.SetParameters(param);

            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.GetArea());
        }

        [Theory]
        [InlineData(300, 4, 5)]
        public void TriangleSetParameters(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle();

            var param = new ParamOfTriangle { SideA = sideA, SideB = sideB, SideC = sideC };

            triangle.SetParameters(param);

            Assert.True(triangle.Parameters?.SideA == sideA);
        }

        [Theory]
        [InlineData(300, 4, 5)]
        public void TriangleIsRightTriangleNotRight(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle();

            var param = new ParamOfTriangle { SideA = sideA, SideB = sideB, SideC = sideC };

            triangle.SetParameters(param);

            var right = triangle.IsRightTriangle();

            Assert.False(right);
        }

        [Theory]
        [InlineData(4, 5, 3)]
        public void TriangleIsRightTriangleRight(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle();

            var param = new ParamOfTriangle { SideA = sideA, SideB = sideB, SideC = sideC };

            triangle.SetParameters(param);

            var right = triangle.IsRightTriangle();

            Assert.True(right);
        }
    }
}
