namespace FindAreaLib.models;

/// <summary>
/// Абстрактный класс для представления фигуры
/// </summary>
public abstract class Figure
{
    /// <summary>
    /// Поле для хранения сторон фигуры
    /// </summary>
    protected double[] _sides = [];

    /// <summary>
    /// Метод для вычисления площади фигуры
    /// </summary>
    /// <returns>Значение площади фигуры</returns>
    public abstract double GetArea();
}
