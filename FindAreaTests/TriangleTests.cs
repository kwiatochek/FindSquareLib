using FindAreaLib.models;

namespace FindAreaTests;

/// <summary>
/// Класс для тестирования нахождения площади треугольника
/// </summary>
[TestClass]
public sealed class TriangleTests
{
    /// <summary>
    /// Проверка расчета площади
    /// </summary>
    [TestMethod]
    public void FindArea_Test()
    {
        Figure triangle = new Triangle(3, 4, 5);

        Assert.AreEqual(6, triangle.GetArea());
    }
    /// <summary>
    /// Проверка выброса исключения в случае создания треугольника с отрицательной стороной
    /// </summary>
    [TestMethod]
    public void FindAreaWithNegativeRadius_Test()
    {
        Assert.ThrowsException<ArgumentException>(() => new Triangle(-2, 3, 4));
    }
    /// <summary>
    /// Проверка выброса исключения в случае создания трегольника, для которого не выполняется
    /// неравентсво треугольника
    /// </summary>
    [TestMethod]
    public void FindAreaWithNonValidTriangle_Test()
    {
        Assert.ThrowsException<Exception>(() => new Triangle(1, 1, 4));
    }

}
