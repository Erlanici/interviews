using FindAreaLibrary.Abstract;
using FindAreaLibrary.Dto;
using System;

namespace FindAreaLibrary.Figure
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : IFigure<ParamOfTriangle>, ITriangle
    {
        public ParamOfTriangle Parameters { get; set; }

        public void SetParameters(ParamOfTriangle data)
        {
            Parameters = data;
        }

        public double GetArea()
        {
            #region Exception

            if (Parameters == null)
            {
                throw new ArgumentNullException(nameof(Parameters));
            }

            if (Parameters.SideA <= 0)
            {
                throw new ArgumentNullException(nameof(ParamOfTriangle.SideA));
            }

            if (Parameters.SideB <= 0 || Parameters.SideC <= 0)
            {
                throw new ArgumentNullException(nameof(ParamOfTriangle.SideB));
            }

            if (Parameters.SideC <= 0)
            {
                throw new ArgumentNullException(nameof(ParamOfTriangle.SideC));
            }

            #endregion Exception

            // вычислим полупериметр
            var p = (Parameters.SideA + Parameters.SideB + Parameters.SideC) / 2;

            //формула Герона
            var multiplication = p * (p - Parameters.SideA) * (p - Parameters.SideB) * (p - Parameters.SideC);

            if (multiplication <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(multiplication));
            }

            var s = Math.Sqrt(multiplication);

            return s;
        }

        public bool IsRightTriangle()
        {
            var right = (Parameters.SideA * Parameters.SideA + Parameters.SideB * Parameters.SideB == Parameters.SideC * Parameters.SideC) 
                || (Parameters.SideA * Parameters.SideA + Parameters.SideC * Parameters.SideC == Parameters.SideB * Parameters.SideB) 
                || (Parameters.SideC * Parameters.SideC + Parameters.SideB * Parameters.SideB == Parameters.SideA * Parameters.SideA);

            return right;
        }
    }
}
