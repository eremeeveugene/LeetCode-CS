using LeetCode.Algorithms.SumOfSquareNumbers;

namespace LeetCode.Tests.Algorithms.SumOfSquareNumbers;

public abstract class SumOfSquareNumbersTestsBase<T> where T : ISumOfSquareNumbers, new()
{
    [TestMethod]
    [DataRow(0, true)]
    [DataRow(1, true)]
    [DataRow(2, true)]
    [DataRow(3, false)]
    [DataRow(4, true)]
    [DataRow(5, true)]
    [DataRow(6, false)]
    [DataRow(7, false)]
    [DataRow(8, true)]
    [DataRow(9, true)]
    [DataRow(2147483600, true)]
    public void JudgeSquareSum_GivenInput_ReturnsWhetherSumOfSquares(int c, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.JudgeSquareSum(c);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}