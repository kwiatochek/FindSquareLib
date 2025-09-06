namespace FindAreaLib.models;

/// <summary>
/// Абстрактный класс для представления фигуры
/// </summary>
public abstract class Figure
{
    /// <summary>
    /// Поле для хранения сторон фигуры
    /// </summary>
    protected double[]? _sides;

    /// <summary>
    /// Метод для вычисления площади фигуры, основывающийся на количестве сторон
    /// <b>для упрощения добавления новых фигур</b>
    /// </summary>
    /// <returns>Значение площади фигуры</returns>
    public double GetArea()
    {
        switch (_sides?.Length)
        {
            case 1:
                return _sides[0] * _sides[0] * Math.PI;

            case 3:
                if (IsRightTriangle(_sides, out var legs))
                {
                    return legs.Item1 * legs.Item2 / 2;
                }

                var per = _sides.Sum()/2;

                return Math.Sqrt(
                    per * (per - _sides[0]) * (per - _sides[1]) * (per - _sides[2])
                    );

            default:
                return -1;
        }
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
