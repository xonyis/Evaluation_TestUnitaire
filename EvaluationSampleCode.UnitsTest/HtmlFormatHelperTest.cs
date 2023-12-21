namespace EvaluationSampleCode.UnitsTest;

[TestClass]
public class HtmlFormatHelpersTests
{
    [TestMethod]
    public void GetBoldFormat_ReturnsBoldTxt()
    {
        // Arrange
        var helper = new HtmlFormatHelper();
        var content = "Ceci est un test";

        // Act
        var result = helper.GetBoldFormat(content);

        // Assert
        Assert.AreEqual("<b>Ceci est un test</b>", result);
    }

    [TestMethod]
    public void GetItalicFormat_ReturnsItalicTxt()
    {
        // Arrange
        var helper = new HtmlFormatHelper();
        var content = "Hello world";

        // Act
        var result = helper.GetItalicFormat(content);

        // Assert
        Assert.AreEqual("<i>Hello world</i>", result);
    }

    [TestMethod]
    public void GetFormattedListElements_ReturnsFormattedList()
    {
        // Arrange
        var helper = new HtmlFormatHelper();
        var contents = new List<string> {"1","2","3","4"};

        // Act
        var result = helper.GetFormattedListElements(contents);

        // Assert
        Assert.AreEqual("<ul><li>1</li><li>2</li><li>3</li><li>4</li></ul>", result);
    }
}
