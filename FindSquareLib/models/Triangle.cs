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

    public override double GetArea()
    {
        if (IsRightTriangle(_sides, out var legs))
        {
            return legs.Item1 * legs.Item2 / 2;
        }

        var per = _sides.Sum() / 2;

        return Math.Sqrt(
            per * (per - _sides[0]) * (per - _sides[1]) * (per - _sides[2])
            );
    }

    /// <summary>
    /// Метод для проверки, является ли треугольник прямоугольным <br/>
    /// В случае успеха возвращает кортеж со значениями катетов
    /// </summary>
    /// <param name="sides">Массив сторон</param>
    /// <param name="legs">Кортеж катетов</param>
    /// <returns>Является ли треугольник прямоугольным</returns>
    private static bool IsRightTriangle(double[] sides, out (double, double) legs)
    {
        var a = sides[0];
        var b = sides[1];
        var c = sides[2];

        legs = (0, 0);
        if (a * a == b * b + c * c)
        {
            legs = (b, c);

        }
        if (a * a + b * b == c * c)
        {
            legs = (a, b);
        }
        if (a * a + c * c == b * b)
        {
            legs = (a, c);
        }

        return legs != (0, 0);
    }
}
