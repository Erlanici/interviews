﻿using FindAreaLibrary.Dto;
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

            Assert.Throws<ArgumentNullException>(() => triangle.GetArea(null));
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

            Assert.Throws<ArgumentNullException>(() => triangle.GetArea(param));
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(1, 2.5, 3.4)]
        [InlineData(2, 2.5, 3)]
        public void TriangleGetAreaSideCorrect(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle();

            var param = new ParamOfTriangle { SideA = sideA, SideB = sideB, SideC = sideC };

            var s = triangle.GetArea(param);

            Assert.True(s > 0);
        }

        [Theory]
        [InlineData(300, 4, 5)]
        public void TriangleGetAreaSideNotCorrect(double sideA, double sideB, double sideC)
        {
            var triangle = new Triangle();

            var param = new ParamOfTriangle { SideA = sideA, SideB = sideB, SideC = sideC };

            Assert.Throws<ArgumentOutOfRangeException>(() => triangle.GetArea(param));
        }
    }
}
