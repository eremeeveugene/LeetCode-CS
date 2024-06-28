using LeetCode.Algorithms.ValidPerfectSquare;

namespace LeetCode.Tests.Algorithms.ValidPerfectSquare;

public abstract class ValidPerfectSquareTestsBase<T> where T : IValidPerfectSquare, new()
{
    [TestMethod]
    [DataRow(16, true)]
    [DataRow(14, false)]
    [DataRow(2147483647, false)]
    public void IsPerfectSquare_GivenNumber_ReturnsWhetherNumberIsPerfectSquare(int num, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.IsPerfectSquare(num);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}