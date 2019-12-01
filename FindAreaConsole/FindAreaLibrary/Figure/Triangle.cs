using FindAreaLibrary.Abstract;
using FindAreaLibrary.Dto;
using System;

namespace FindAreaLibrary.Figure
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IFigure<ParamOfTriangle>
    {
        public double GetArea(ParamOfTriangle data)
        {
            #region Exception

            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (data.SideA <= 0)
            {
                throw new ArgumentNullException(nameof(ParamOfTriangle.SideA));
            }

            if (data.SideB <= 0 || data.SideC <= 0)
            {
                throw new ArgumentNullException(nameof(ParamOfTriangle.SideB));
            }

            if (data.SideC <= 0)
            {
                throw new ArgumentNullException(nameof(ParamOfTriangle.SideC));
            }

            #endregion Exception

            // вычислим полупериметр
            var p = (data.SideA + data.SideB + data.SideC) / 2;

            //формула Герона
            var multiplication = p * (p - data.SideA) * (p - data.SideB) * (p - data.SideC);

            if (multiplication <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(multiplication));
            }

            var s = Math.Sqrt(multiplication);

            return s;
        }
    }
}
