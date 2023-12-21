namespace EvaluationSampleCode.UnitsTest;

[TestClass]
public class MathOperationsTests
{
    [TestMethod]
    [DataRow(2,2, 4)]
    [DataRow(-5, 7, 2)]
    [DataRow(105, 34, 139)]
    public void Add_ReturnsCorectResult(int numberOne, int numberTwo, int expectedResult)
    {
        // Arrange
        var mathOperations = new MathOperations();

        // Act
        var result = mathOperations.Add(numberOne, numberTwo);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    [DataRow(10, 2, 5f)]
    [DataRow(-10, 2, -5f)]
    [DataRow(10, -2, -5f)] 
    public void Divide_NonZero_ReturnsCorrectResult(int numberOne, int numberTwo, float expectedResult)
    {
        // Arrange
        var mathOperations = new MathOperations();

        // Act
        var result = mathOperations.Divide(numberOne, numberTwo);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [TestMethod]
    [DataRow(50, 0)]
    public void Divide_ByZero_ThrowsArgumentException(int numberOne, int numberTwo)
    {
        // Arrange
        var mathOperations = new MathOperations();

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => mathOperations.Divide(numberOne, numberTwo));
    }
}
