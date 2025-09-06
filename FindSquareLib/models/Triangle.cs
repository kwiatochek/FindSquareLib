namespace FindAreaLib.models;

/// <summary>
/// Класс треугольника
/// </summary>
public class Triangle : Figure
{
    /// <summary>
    /// Консруктор класса
    /// </summary>
    /// <param name="a">Первая сторона</param>
    /// <param name="b">Вторая сторона</param>
    /// <param name="c">Третья сторона</param>
    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException($"Стороны должны быть положительными ({a}, {b}, {c})");
        }

        if ((a + b <= c) || (a + c <= b) || (b + c <= a))
        {
            throw new Exception("Эта фигура не является треугольником");
        }

        _sides = new double[]
        {
            a,
            b,
            c
        };            
    }
}
