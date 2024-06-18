using LeetCode.Algorithms.ExcelSheetColumnTitle;

namespace LeetCode.Tests.Algorithms.ExcelSheetColumnTitle;

public abstract class ExcelSheetColumnTitleTestsBase<T> where T : IExcelSheetColumnTitle, new()
{
    [TestMethod]
    [DataRow(1, "A")]
    [DataRow(28, "AB")]
    [DataRow(701, "ZY")]
    public void ConvertToTitle_GivenColumnNumber_ReturnsExpectedTitle(int columnNumber, string expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ConvertToTitle(columnNumber);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}