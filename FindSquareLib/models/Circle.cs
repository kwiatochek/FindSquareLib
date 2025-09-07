namespace FindAreaLib.models;

/// <summary>
/// Класс круга
/// </summary>
public class Circle : Figure
{
    /// <summary>
    /// Конструктор класса
    /// </summary>
    /// <param name="rad">Значение радиуса</param>
    public Circle(double rad) 
    {
        if (rad <= 0)
        {
            throw new ArgumentException($"Radius must be positive ({rad})");
        }

        _sides = new double[]
        { 
            rad 
        };
    }

    public override double GetArea()
    {
        return _sides[0] * _sides[0] * Math.PI;
    }
}
