using FindAreaLibrary.Abstract;
using FindAreaLibrary.Dto;
using System;

namespace FindAreaLibrary.Figure
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : IFigure<ParamOfCircle>
    {
        public double GetArea(ParamOfCircle data)
        {
            if (data?.Radius <= 0)
            {
                throw new ArgumentNullException(nameof(ParamOfCircle.Radius));
            }

            var s = Math.PI * Math.Pow(data.Radius, 2);

            return s;
        }
    }
}
