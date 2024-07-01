using LeetCode.Algorithms.ThreeConsecutiveOdds;

namespace LeetCode.Tests.Algorithms.ThreeConsecutiveOdds;

public abstract class ThreeConsecutiveOddsTestsBase<T> where T : IThreeConsecutiveOdds, new()
{
    [TestMethod]
    [DataRow(new[] { 2, 6, 4, 1 }, false)]
    [DataRow(new[] { 1, 2, 34, 3, 4, 5, 7, 23, 12 }, true)]
    public void ThreeConsecutiveOdds_WithVariousArrays_ReturnsExpectedResult(int[] arr, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = solution.ThreeConsecutiveOdds(arr);

        Assert.AreEqual(expectedResult, actualResult);
    }
}