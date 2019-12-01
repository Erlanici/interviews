namespace FindAreaLibrary.Abstract
{
    /// <summary>
    /// Геометрическая фигура
    /// </summary>
    public interface IFigure<T>
    {
        /// <summary>
        /// Параметры фигуры (например, радиус, стороны, углы)
        /// </summary>
        T Parameters { get; set; }

        /// <summary>
        /// Задать значение параметров
        /// </summary>
        /// <param name="data"></param>
        void SetParameters(T data);

        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <returns>Площадь</returns>
        double GetArea();
    }
}
