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
        public ParamOfCircle Parameters { get; set; }

        public void SetParameters(ParamOfCircle data)
        {
            Parameters = data;
        }

        public double GetArea()
        {
            if (Parameters == null)
            {
                throw new ArgumentNullException(nameof(Parameters));
            }

            if (Parameters.Radius <= 0)
            {
                throw new ArgumentNullException(nameof(Parameters.Radius));
            }

            var s = Math.PI * Math.Pow(Parameters.Radius, 2);

            return s;
        }
    }
}
