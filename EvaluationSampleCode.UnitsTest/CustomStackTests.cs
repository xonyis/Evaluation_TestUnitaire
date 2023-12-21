namespace EvaluationSampleCode.UnitsTest;

[TestClass]
public class CustomStackTests
{
    [TestMethod]
    public void Count_EmptyStack_ReturnsZero()
    {
        // Arrange
        var customStack = new CustomStack();

        // Act
        var count = customStack.Count();

        // Assert
        Assert.AreEqual(0, count);
    }
}
