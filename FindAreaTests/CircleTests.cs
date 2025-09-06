using FindAreaLib.models;

namespace FindAreaTests;

/// <summary>
/// Класс для тестирования круга
/// </summary>
[TestClass]
public sealed class CircleTests
{
    /// <summary>
    /// Проверка расчета площади
    /// </summary>
    [TestMethod]
    public void FindArea_Test()
    {
        Figure circle = new Circle(5);

        Assert.AreEqual(25 * Math.PI, circle.GetArea());
    }
    /// <summary>
    /// Проверка выброса исключения в случае создания круга с отрицательным радиусом
    /// </summary>
    [TestMethod]
    public void FindAreaWithNegativeRadius_Test()
    {
        Assert.ThrowsException<ArgumentException>(() => new Circle(-5));
    }
}
