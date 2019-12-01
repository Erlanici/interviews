namespace FindAreaLibrary.Abstract
{
    /// <summary>
    /// Геометрическая фигура
    /// </summary>
    public interface IFigure<T>
    {
        /// <summary>
        /// Получить площадь фигуры
        /// </summary>
        /// <param name="data">Параметры фигуры, необходимые для определения площади</param>
        /// <returns>Площадь</returns>
        double GetArea(T data);
    }
}
